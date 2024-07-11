import { useState } from "react"

import { jewelrySchema } from "@/schemas/AddJewelryForm"
import { zodResolver } from "@hookform/resolvers/zod"
import { getDownloadURL, ref, uploadBytesResumable } from "firebase/storage"
import { Plus } from "lucide-react"
import { Controller, SubmitHandler, useForm } from "react-hook-form"
import { z } from "zod"

import { IJewelryPost } from "@/types/jewelry.interface"

import { usePostJewelry } from "@/apis/jewelryApi"

import { diamoonDB } from "@/lib/firebase"

import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogFooter,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"
import { Input } from "@/components/global/atoms/input"
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"
import {
  Tabs,
  TabsContent,
  TabsList,
  TabsTrigger
} from "@/components/global/molecules/UploadImageTab"

type JewelryFormValues = z.infer<typeof jewelrySchema>

function AddJewelryDialog() {
  const [isDialogOpen, setIsDialogOpen] = useState<boolean>(false)
  const [newPhotos, setNewPhotos] = useState<(File | null)[]>([null, null])
  const [uploadProgress, setUploadProgress] = useState([0, 0])

  const postJewelry = usePostJewelry()

  const handleSave = async () => {
    const urls = await Promise.all(
      newPhotos.map(
        (photo, index) =>
          new Promise<string | null>((resolve, reject) => {
            if (photo) {
              const storageRef = ref(
                diamoonDB,
                `/Products/Jewelry/${photo.name}`
              )
              const uploadTask = uploadBytesResumable(storageRef, photo)

              uploadTask.on(
                "state_changed",
                (snapshot) => {
                  const progress =
                    (snapshot.bytesTransferred / snapshot.totalBytes) * 100
                  setUploadProgress((prev) => {
                    const newProgress = [...prev]
                    newProgress[index] = progress
                    return newProgress
                  })
                },
                (error) => {
                  console.error("Upload failed:", error)
                  reject(error)
                },
                async () => {
                  const downloadURL = await getDownloadURL(
                    uploadTask.snapshot.ref
                  )
                  resolve(downloadURL)
                }
              )
            } else {
              resolve(null)
            }
          })
      )
    )
    return urls.filter((url) => url !== null) as string[]
  }

  const {
    register,
    handleSubmit,
    control,
    reset,
    formState: { errors, isDirty }
  } = useForm<JewelryFormValues>({
    resolver: zodResolver(jewelrySchema)
  })

  const onSubmit: SubmitHandler<JewelryFormValues> = async (data) => {
    try {
      const downloadURLs = await handleSave()

      const generatedJewelryName = `${data.goldKarat} ${data.sideStoneType} ${data.jewelryCategory}`

      const jewelryData: IJewelryPost = {
        jewelryCategory: data.jewelryCategory,
        jewelryName: generatedJewelryName,
        mainStoneSize: data.mainStoneSize,
        sideStoneType: data.sideStoneType,
        sideStoneQuantity: data.sideStoneQuantity,
        stoneWeight: data.stoneWeight,
        goldType: data.goldType,
        goldKarat: data.goldKarat,
        goldWeight: data.goldWeight,
        price: data.price,
        images: downloadURLs
      }

      console.log("Jewelry data:", JSON.stringify(jewelryData, null, 2))
      postJewelry.mutate(jewelryData, {
        onSuccess: () => {
          setIsDialogOpen(false)
          handleClear()
        }
      })
    } catch (error) {
      console.error("Error saving jewelry:", error)
    }
  }

  const handleClear = () => {
    reset({})
    setUploadProgress([0, 0])
    setNewPhotos([null, null])
  }

  const handleConfirmCancel = () => {
    handleClear()
    setIsDialogOpen(false)
  }

  return (
    <>
      <Button
        onClick={() => setIsDialogOpen(true)}
        className="flex gap-2 bg-gray-800 pl-5 hover:bg-gray-900"
      >
        <Plus size={20} />
        Add Jewelry
      </Button>

      <Dialog
        open={isDialogOpen}
        onOpenChange={(open) => {
          if (!open) {
            handleClear()
          }
          setIsDialogOpen(open)
        }}
      >
        <DialogContent className="min-w-[1000px]">
          <DialogHeader>
            <DialogTitle className="text-center text-xl font-semibold">
              Add Jewelry
            </DialogTitle>
          </DialogHeader>
          <form onSubmit={handleSubmit(onSubmit)} className="grid gap-4 p-2">
            <div className="flex justify-between gap-4">
              {newPhotos.map((photo, index) => (
                <div
                  key={index}
                  className="flex min-h-40 min-w-40 items-center justify-center rounded-md border-2 border-gray-800"
                >
                  {photo ? (
                    <img
                      src={URL.createObjectURL(photo)}
                      alt={`New Jewelry ${index + 1}`}
                      className="h-40 w-40 rounded-md border-[1px] border-gray-800 object-cover"
                    />
                  ) : (
                    "No Image"
                  )}
                </div>
              ))}

              <Tabs defaultValue="upload" className="w-full">
                <TabsList className="mt-1 grid w-full grid-cols-2 gap-4">
                  <TabsTrigger value="upload">Upload</TabsTrigger>
                </TabsList>

                <TabsContent value="upload">
                  {[0, 1].map((_, index) => (
                    <div key={index}>
                      <Input
                        type="file"
                        accept="image/*"
                        className="input-field mt-1"
                        onChange={(e) => {
                          if (e.target.files && e.target.files[0]) {
                            setNewPhotos((prev) => {
                              const newPhotos = [...prev]
                              newPhotos[index] = e.target.files![0]
                              return newPhotos
                            })
                          }
                        }}
                      />

                      {uploadProgress[index] > 0 && (
                        <div className="mt-2 h-2.5 w-full rounded-full bg-gray-200">
                          <div
                            className="h-2.5 rounded-full bg-gray-900"
                            style={{ width: `${uploadProgress[index]}%` }}
                          ></div>
                        </div>
                      )}
                    </div>
                  ))}
                </TabsContent>

                <TabsContent value="url">
                  <Input
                    type="text"
                    {...register("images")}
                    placeholder="Image URL"
                    className="input-field mt-1"
                  />
                </TabsContent>

                {errors.images && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.images.message}
                  </p>
                )}
              </Tabs>
            </div>

            <div className="grid grid-cols-3 items-center gap-4">
              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">
                  Jewelry Category
                </span>
                <Controller
                  control={control}
                  name="jewelryCategory"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Category" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="Earrings">Earrings</SelectItem>
                          <SelectItem value="Pendant">Pendant</SelectItem>
                          <SelectItem value="Bracelet">Bracelet</SelectItem>
                          <SelectItem value="Ring">Ring</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.jewelryCategory && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.jewelryCategory.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">
                  Main Stone Size
                </span>
                <input
                  type="text"
                  placeholder="e.g., Round 5ly"
                  className="input-field mt-1"
                  {...register("mainStoneSize")}
                />
                {errors.mainStoneSize && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.mainStoneSize.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">
                  Side Stone Type
                </span>
                <Controller
                  control={control}
                  name="sideStoneType"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Stone type" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="Diamond">Diamond</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.sideStoneType && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.sideStoneType.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">
                  Side Stone Quantity
                </span>
                <input
                  type="number"
                  placeholder="e.g., 15"
                  className="input-field mt-1"
                  {...register("sideStoneQuantity", { valueAsNumber: true })}
                />
                {errors.sideStoneQuantity && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.sideStoneQuantity.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">
                  Side Stone Weight
                </span>
                <input
                  type="text"
                  placeholder="e.g., 0.04"
                  className="input-field mt-1"
                  {...register("stoneWeight", { valueAsNumber: true })}
                />
                {errors.stoneWeight && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.stoneWeight.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">Gold Type</span>
                <Controller
                  control={control}
                  name="goldType"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Gold Type" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="White gold">White gold</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.goldType && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.goldType.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">Gold Karat</span>
                <Controller
                  control={control}
                  name="goldKarat"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Gold Karat" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="14K">14K</SelectItem>
                          <SelectItem value="18K">18K</SelectItem>
                          <SelectItem value="22K">22K</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.goldKarat && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.goldKarat.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">Gold Weight</span>
                <input
                  type="text"
                  placeholder="e.g., 1.04"
                  {...register("goldWeight", { valueAsNumber: true })}
                  className="input-field mt-1"
                />
                {errors.goldWeight && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.goldWeight.message}
                  </p>
                )}
              </div>

              <div className="col-span-1">
                <span className="ml-1 text-sm font-medium">Price (VND)</span>
                <input
                  type="number"
                  {...register("price", { valueAsNumber: true })}
                  className="input-field mt-1"
                />
                {errors.price && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.price.message}
                  </p>
                )}
              </div>
            </div>

            <DialogFooter className="mt-4">
              {isDirty ? (
                <AlertDialogComponent
                  variant="secondary"
                  actionBtn="Cancel"
                  title="Discard changes?"
                  description="You have unsaved changes. Are you sure you want to discard them?"
                  action="Discard"
                  onConfirm={handleConfirmCancel}
                />
              ) : (
                <Button
                  type="button"
                  variant={"secondary"}
                  onClick={() => setIsDialogOpen(false)}
                >
                  Cancel
                </Button>
              )}
              <Button type="button" onClick={handleClear}>
                Clear
              </Button>
              <Button type="submit">Save</Button>
            </DialogFooter>
          </form>
        </DialogContent>
      </Dialog>
    </>
  )
}

export default AddJewelryDialog
