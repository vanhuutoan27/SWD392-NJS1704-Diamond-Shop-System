import { useEffect, useState } from "react"

import { jewelrySchema } from "@/schemas/AddJewelryForm"
import { zodResolver } from "@hookform/resolvers/zod"
import { getDownloadURL, ref, uploadBytesResumable } from "firebase/storage"
import { Plus } from "lucide-react"
import { Controller, SubmitHandler, useForm } from "react-hook-form"
import { z } from "zod"

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
  const [imageUrl, setImageUrl] = useState<string>("")
  const [isDialogOpen, setIsDialogOpen] = useState<boolean>(false)
  const [newPhoto, setNewPhoto] = useState<File | null>(null)
  const [uploadProgress, setUploadProgress] = useState(0)
  const [imageMethod, setImageMethod] = useState<"upload" | "url">("upload")

  const handleSave = () => {
    if (newPhoto) {
      const storageRef = ref(diamoonDB, `/Products/Jewelry/${newPhoto.name}`)
      const uploadTask = uploadBytesResumable(storageRef, newPhoto)

      uploadTask.on(
        "state_changed",
        (snapshot) => {
          const progress =
            (snapshot.bytesTransferred / snapshot.totalBytes) * 100
          setUploadProgress(progress)
        },
        (error) => {
          console.error("Upload failed:", error)
        },
        async () => {
          const downloadURL = await getDownloadURL(uploadTask.snapshot.ref)
          setImageUrl(downloadURL)
        }
      )
    }
  }

  const {
    register,
    handleSubmit,
    control,
    reset,
    watch,
    formState: { errors, isDirty }
  } = useForm<JewelryFormValues>({
    resolver: zodResolver(jewelrySchema)
  })

  const watchImageUrl = watch("images")

  useEffect(() => {
    if (imageMethod === "url") {
      setImageUrl(watchImageUrl)
    }
  }, [watchImageUrl, imageMethod])

  const onSubmit: SubmitHandler<JewelryFormValues> = (data) => {
    if (imageMethod === "upload") {
      handleSave()
    }
    console.log("Jewelry data:", data)
    setIsDialogOpen(false)
  }

  const handleClear = () => {
    reset({
      jewelryCategory: "",
      jewelryName: "",
      mainStoneSize: "",
      sideStoneType: "",
      sideStoneQuantity: undefined,
      stoneWeight: undefined,
      goldType: "",
      goldKarat: undefined,
      goldWeight: undefined,
      images: ""
    })
    setUploadProgress(0)
    setNewPhoto(null)
    setImageUrl("")
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
              <div className="flex min-h-40 min-w-40 items-center justify-center rounded-md border-2 border-gray-800">
                {imageMethod === "url" && imageUrl ? (
                  <img
                    src={imageUrl}
                    alt="Diamond"
                    className="h-40 w-40 rounded-md border-2 border-gray-800 object-cover"
                  />
                ) : newPhoto ? (
                  <img
                    src={URL.createObjectURL(newPhoto)}
                    alt="Diamond"
                    className="h-40 w-40 rounded-md border-2 border-gray-800 object-cover"
                  />
                ) : (
                  "No Image"
                )}
              </div>

              <Tabs
                defaultValue="upload"
                className="w-full"
                onValueChange={(value) =>
                  setImageMethod(value as "upload" | "url")
                }
              >
                <span className="ml-1 text-sm font-medium">
                  Choose 1 of the 2 ways below to set an image for the product
                </span>

                <TabsList className="mt-1 grid w-full grid-cols-2 gap-4">
                  <TabsTrigger value="upload">Upload</TabsTrigger>
                  <TabsTrigger value="url">URL</TabsTrigger>
                </TabsList>

                <TabsContent value="upload">
                  <Input
                    type="file"
                    accept="image/*"
                    className="input-field mt-1"
                    onChange={(e) => {
                      if (e.target.files && e.target.files[0]) {
                        setNewPhoto(e.target.files[0])
                      }
                    }}
                  />

                  {uploadProgress > 0 && (
                    <div className="mt-2 h-2.5 w-full rounded-full bg-gray-200">
                      <div
                        className="h-2.5 rounded-full bg-gray-900"
                        style={{ width: `${uploadProgress}%` }}
                      ></div>
                    </div>
                  )}
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
                <span className="ml-1 text-sm font-medium">Jewelry Name</span>
                <input
                  type="text"
                  className="input-field mt-1"
                  {...register("jewelryName")}
                />
                {errors.jewelryName && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.jewelryName.message}
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
                  type="number"
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
                          <SelectItem value="WhiteGold">White gold</SelectItem>
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
                  type="number"
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