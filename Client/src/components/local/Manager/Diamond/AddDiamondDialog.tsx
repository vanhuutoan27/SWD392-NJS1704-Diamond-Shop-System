import { useState } from "react"

import { diamondSchema } from "@/schemas/AddDiamondForm"
import { zodResolver } from "@hookform/resolvers/zod"
import { getDownloadURL, ref, uploadBytesResumable } from "firebase/storage"
import { Plus } from "lucide-react"
import { Controller, SubmitHandler, useForm } from "react-hook-form"
import { z } from "zod"

import {
  IDiamondCertification,
  IDiamondClarity,
  IDiamondColor,
  IDiamondFluorescence,
  IDiamondQualityOfCut,
  IDiamondShape
} from "@/types/diamond.interface"

import { usePostDiamond } from "@/apis/diamondApi"

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

type DiamondFormValues = z.infer<typeof diamondSchema>

function AddDiamondDialog() {
  const [isDialogOpen, setIsDialogOpen] = useState<boolean>(false)
  const [newPhoto, setNewPhoto] = useState<File | null>(null)
  const [uploadProgress, setUploadProgress] = useState(0)

  const postDiamond = usePostDiamond()

  const handleSave = async () => {
    return new Promise<string | null>((resolve, reject) => {
      if (newPhoto) {
        const storageRef = ref(diamoonDB, `/Products/Diamond/${newPhoto.name}`)
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
            reject(error)
          },
          async () => {
            const downloadURL = await getDownloadURL(uploadTask.snapshot.ref)
            resolve(downloadURL)
          }
        )
      } else {
        resolve(null)
      }
    })
  }

  const {
    register,
    handleSubmit,
    control,
    reset,
    formState: { errors, isDirty }
  } = useForm<DiamondFormValues>({
    resolver: zodResolver(diamondSchema)
  })

  const onSubmit: SubmitHandler<DiamondFormValues> = async (data) => {
    try {
      const downloadURL = await handleSave()

      const diamondData = {
        shape: data.shape,
        weight: data.weight,
        colorLevel: data.colorLevel,
        clarity: data.clarity,
        certification: data.certification,
        size: data.size,
        fluorescence: data.fluorescence,
        qualityOfCut: data.qualityOfCut,
        price: data.price,
        images: downloadURL || ""
      }

      console.log("Diamond data:", JSON.stringify(diamondData, null, 2))
      postDiamond.mutate(diamondData)
      setIsDialogOpen(false)
    } catch (error) {
      console.error("Error saving diamond:", error)
    }
  }

  const handleClear = () => {
    reset({
      shape: "",
      weight: 0,
      colorLevel: "",
      clarity: "",
      certification: "",
      size: 0,
      fluorescence: "",
      qualityOfCut: "",
      images: "",
      price: 0
    })
    setUploadProgress(0)
    setNewPhoto(null)
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
        Add Diamond
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
              Add Diamond
            </DialogTitle>
          </DialogHeader>
          <form onSubmit={handleSubmit(onSubmit)} className="grid gap-4 p-2">
            <div className="flex justify-between gap-4">
              <div className="flex min-h-40 min-w-40 items-center justify-center rounded-md border-2 border-gray-800">
                {newPhoto ? (
                  <img
                    src={URL.createObjectURL(newPhoto)}
                    alt="Diamond"
                    className="h-40 w-40 rounded-md border-[1px] border-gray-800 object-cover"
                  />
                ) : (
                  "No Image"
                )}
              </div>

              <Tabs defaultValue="upload" className="w-full">
                {/* <span className="ml-1 text-sm font-medium">
                  Choose 1 of the 2 ways below to set an image for the product
                </span> */}

                <TabsList className="mt-1 grid w-full grid-cols-2 gap-4">
                  <TabsTrigger value="upload">Upload</TabsTrigger>
                  {/* <TabsTrigger value="url">URL</TabsTrigger> */}
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
                    placeholder="Image URL"
                    className="input-field mt-1"
                  />
                </TabsContent>
              </Tabs>
            </div>

            <div className="grid grid-cols-8 items-center gap-4">
              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Shape</span>
                <Controller
                  control={control}
                  name="shape"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Shape" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondShape.map((shape) => (
                            <SelectItem
                              key={shape.shapeName}
                              value={shape.shapeName}
                            >
                              {shape.shapeName}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.shape && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.shape.message}
                  </p>
                )}
              </div>

              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Color</span>
                <Controller
                  control={control}
                  name="colorLevel"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Color" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondColor.map((color) => (
                            <SelectItem key={color} value={color}>
                              {color}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.colorLevel && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.colorLevel.message}
                  </p>
                )}
              </div>

              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Clarity</span>
                <Controller
                  control={control}
                  name="clarity"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Clarity" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondClarity.map((clarity) => (
                            <SelectItem key={clarity} value={clarity}>
                              {clarity}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.clarity && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.clarity.message}
                  </p>
                )}
              </div>

              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Certification</span>
                <Controller
                  control={control}
                  name="certification"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Certification" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondCertification.map((certification) => (
                            <SelectItem
                              key={certification}
                              value={certification}
                            >
                              {certification}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.certification && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.certification.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-6 items-center gap-4">
              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Fluorescence</span>
                <Controller
                  control={control}
                  name="fluorescence"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Fluorescence" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondFluorescence.map((fluorescence) => (
                            <SelectItem key={fluorescence} value={fluorescence}>
                              {fluorescence}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.fluorescence && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.fluorescence.message}
                  </p>
                )}
              </div>

              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Quality of Cut</span>
                <Controller
                  control={control}
                  name="qualityOfCut"
                  render={({ field }) => (
                    <Select
                      {...field}
                      onValueChange={(value) => {
                        field.onChange(value)
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select Quality of Cut" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          {IDiamondQualityOfCut.map((quality) => (
                            <SelectItem key={quality} value={quality}>
                              {quality}
                            </SelectItem>
                          ))}
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  )}
                />
                {errors.qualityOfCut && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.qualityOfCut.message}
                  </p>
                )}
              </div>

              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">
                  Weight (carats)
                </span>
                <input
                  type="number"
                  step="any"
                  {...register("weight", { valueAsNumber: true })}
                  placeholder="e.g., 1.5"
                  className="input-field mt-1"
                />
                {errors.weight && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.weight.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-6 items-center gap-4">
              <div className="col-span-2">
                <span className="ml-1 text-sm font-medium">Size (mm)</span>
                <input
                  type="number"
                  step="any"
                  {...register("size", { valueAsNumber: true })}
                  placeholder="e.g., 10.5"
                  className="input-field mt-1"
                />
                {errors.size && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.size.message}
                  </p>
                )}
              </div>

              <div className="col-span-4">
                <span className="ml-1 text-sm font-medium">Price (VND)</span>
                <input
                  type="number"
                  step="any"
                  {...register("price", { valueAsNumber: true })}
                  className="input-field no-arrows mt-1"
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

export default AddDiamondDialog
