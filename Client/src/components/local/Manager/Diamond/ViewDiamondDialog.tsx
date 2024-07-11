import { useEffect, useRef, useState } from "react"

import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"
import { getDownloadURL, ref, uploadBytesResumable } from "firebase/storage"

import {
  IDiamondCertification,
  IDiamondClarity,
  IDiamondColor,
  IDiamondFluorescence,
  IDiamondQualityOfCut,
  IDiamondShape
} from "@/types/diamond.interface"

import { useGetDiamondById, useUpdateDiamond } from "@/apis/diamondApi"

import { diamondImage } from "@/lib/constants"
import { diamoonDB } from "@/lib/firebase"
import { formatCurrencyWithoutVND, formatDate } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"
import { Skeleton } from "@/components/global/atoms/skeleton"
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

function ViewDiamondDialog({
  diamondId,
  onClose
}: {
  diamondId: string
  onClose: () => void
}) {
  const { data: diamondDetails, error } = useGetDiamondById(diamondId)

  const updateDiamond = useUpdateDiamond()

  const [imageLoaded, setImageLoaded] = useState(false)
  const [isEditing, setIsEditing] = useState(false)
  const [newImage, setNewImage] = useState<File | null>(null)
  const [_, setUploadProgress] = useState(0)
  const [formData, setFormData] = useState({
    diamondId: "",
    shape: "",
    colorLevel: "",
    clarity: "",
    certification: "",
    fluorescence: "",
    qualityOfCut: "",
    weight: 0,
    size: 0,
    price: 0,
    image: diamondImage,
    dateCreated: "",
    dateModified: "",
    productType: "",
    skuID: "",
    images: "",
    status: 0
  })

  const dialogRef = useRef<HTMLDivElement | null>(null)

  useEffect(() => {
    if (diamondDetails) {
      setFormData({
        diamondId: diamondDetails.diamondId || "",
        shape: diamondDetails.shape || "",
        colorLevel: diamondDetails.colorLevel || "",
        clarity: diamondDetails.clarity || "",
        certification: diamondDetails.certification || "",
        fluorescence: diamondDetails.fluorescence.toUpperCase() || "",
        qualityOfCut: diamondDetails.qualityOfCut || "",
        weight: diamondDetails.weight || 0,
        size: diamondDetails.size || 0,
        price: diamondDetails.price || 0,
        image: diamondDetails.images || diamondImage || "",
        dateCreated: diamondDetails.dateCreated || "",
        dateModified: diamondDetails.dateModified || "",
        productType: diamondDetails.productType || "",
        skuID: diamondDetails.skuID || "",
        images: diamondDetails.images || "",
        status: diamondDetails.status || 0
      })
    }
  }, [diamondDetails])

  const handleEditClick = async () => {
    if (isEditing) {
      try {
        let updatedImage = formData.image
        if (newImage) {
          updatedImage = await handleImageUpload(newImage)
        }
        const updatedFormData = {
          ...formData,
          image: updatedImage
        }
        await updateDiamond.mutateAsync(updatedFormData)
        setFormData(updatedFormData)
        console.log("Updated Data:", updatedFormData)
        setIsEditing(false)
      } catch (error) {
        console.error("Error updating diamond:", error)
      }
    } else {
      setIsEditing(true)
    }
  }

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleSelectChange = (name: string, value: string) => {
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleImageChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (e.target.files && e.target.files[0]) {
      setNewImage(e.target.files[0])
      // Immediately update the image preview
      const newImageUrl = URL.createObjectURL(e.target.files[0])
      setFormData((prev) => ({ ...prev, image: newImageUrl }))
    }
  }

  const handleImageUpload = (image: File): Promise<string> => {
    return new Promise((resolve, reject) => {
      const storageRef = ref(diamoonDB, `/Products/Diamonds/${image.name}`)
      const uploadTask = uploadBytesResumable(storageRef, image)

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
    })
  }

  const handleConfirmCancel = () => {
    if (diamondDetails) {
      setFormData({
        diamondId: diamondDetails.diamondId || "",
        shape: diamondDetails.shape || "",
        colorLevel: diamondDetails.colorLevel || "",
        clarity: diamondDetails.clarity || "",
        certification: diamondDetails.certification || "",
        fluorescence: diamondDetails.fluorescence.toUpperCase() || "",
        qualityOfCut: diamondDetails.qualityOfCut || "",
        weight: diamondDetails.weight || 0,
        size: diamondDetails.size || 0,
        price: diamondDetails.price || 0,
        image: diamondDetails.images || diamondImage || "",
        dateCreated: diamondDetails.dateCreated || "",
        dateModified: diamondDetails.dateModified || "",
        productType: diamondDetails.productType || "",
        skuID: diamondDetails.skuID || "",
        images: diamondDetails.images || "",
        status: diamondDetails.status || 0
      })
    }
    setIsEditing(false)
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent ref={dialogRef} className="min-w-[800px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Diamond Details
          </DialogTitle>
        </DialogHeader>
        <div className="mt-4 grid grid-cols-6 gap-4">
          <div className="relative col-span-2 row-span-2 flex flex-col items-center justify-center rounded-md">
            {!imageLoaded && (
              <Skeleton className="h-[200px] w-[200px] rounded-md border-2 border-gray-800" />
            )}
            <img
              src={formData.image || diamondImage}
              alt="Diamond"
              onLoad={() => setImageLoaded(true)}
              className={`h-[200px] w-[200px] rounded-md border-2 border-gray-800 object-cover ${
                imageLoaded ? "block" : "hidden"
              }`}
            />
            {isEditing && (
              <input
                type="file"
                id="fileInput"
                className="absolute inset-0 cursor-pointer opacity-0"
                accept="image/*"
                onChange={handleImageChange}
              />
            )}
          </div>
          <div className="col-span-4">
            <span className="ml-1 text-sm font-medium">Diamond ID</span>
            <input
              type="text"
              name="diamondId"
              value={formData.diamondId}
              readOnly
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Date Created</span>
            <input
              type="text"
              name="dateCreated"
              value={formatDate(formData.dateCreated)}
              readOnly
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Date Modified</span>
            <input
              type="text"
              name="dateModified"
              value={formatDate(formData.dateModified)}
              readOnly
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Shape</span>
            {isEditing ? (
              <Select
                value={formData.shape}
                onValueChange={(value) => handleSelectChange("shape", value)}
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select shape" />
                </SelectTrigger>
                <SelectContent>
                  <SelectGroup>
                    {IDiamondShape.map((shape) => (
                      <SelectItem key={shape.shapeName} value={shape.shapeName}>
                        {shape.shapeName}
                      </SelectItem>
                    ))}
                  </SelectGroup>
                </SelectContent>
              </Select>
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.shape}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Color</span>
            {isEditing ? (
              <Select
                value={formData.colorLevel}
                onValueChange={(value) =>
                  handleSelectChange("colorLevel", value)
                }
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select color" />
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
            ) : (
              <input
                type="text"
                name="colorLevel"
                value={formData.colorLevel}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Clarity</span>
            {isEditing ? (
              <Select
                value={formData.clarity}
                onValueChange={(value) => handleSelectChange("clarity", value)}
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select clarity" />
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
            ) : (
              <input
                type="text"
                name="clarity"
                value={formData.clarity}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Certification</span>
            {isEditing ? (
              <Select
                value={formData.certification}
                onValueChange={(value) =>
                  handleSelectChange("certification", value)
                }
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select certification" />
                </SelectTrigger>
                <SelectContent>
                  <SelectGroup>
                    {IDiamondCertification.map((certification) => (
                      <SelectItem key={certification} value={certification}>
                        {certification}
                      </SelectItem>
                    ))}
                  </SelectGroup>
                </SelectContent>
              </Select>
            ) : (
              <input
                type="text"
                name="certification"
                value={formData.certification}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Fluorescence</span>
            {isEditing ? (
              <Select
                value={formData.fluorescence}
                onValueChange={(value) =>
                  handleSelectChange("fluorescence", value)
                }
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select fluorescence" />
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
            ) : (
              <input
                type="text"
                name="fluorescence"
                value={formData.fluorescence}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Quality of Cut</span>
            {isEditing ? (
              <Select
                value={formData.qualityOfCut}
                onValueChange={(value) =>
                  handleSelectChange("qualityOfCut", value)
                }
              >
                <SelectTrigger className="mt-1 h-11 w-full px-5">
                  <SelectValue placeholder="Select quality of cut" />
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
            ) : (
              <input
                type="text"
                name="qualityOfCut"
                value={formData.qualityOfCut}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Weight (carats)</span>
            <input
              type="number"
              name="weight"
              value={formData.weight}
              onChange={handleChange}
              readOnly={!isEditing}
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Size (mm)</span>
            <input
              type="number"
              name="size"
              value={formData.size}
              onChange={handleChange}
              readOnly={!isEditing}
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Price (VND)</span>
            <input
              type={isEditing ? "number" : "text"}
              name="price"
              value={
                isEditing
                  ? formData.price
                  : formatCurrencyWithoutVND(formData.price)
              }
              onChange={handleChange}
              readOnly={!isEditing}
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
        </div>

        <div className="mt-4 flex justify-end gap-4">
          <div className="flex justify-between gap-4">
            {isEditing && (
              <AlertDialogComponent
                variant="secondary"
                actionBtn="Cancel"
                title="Discard changes?"
                description="You have unsaved changes. Are you sure you want to discard them?"
                action="Discard"
                onConfirm={handleConfirmCancel}
              />
            )}
            <Button type="button" onClick={handleEditClick}>
              {isEditing ? "Save" : "Edit"}
            </Button>
          </div>
        </div>
      </DialogContent>
    </Dialog>
  )
}

export default ViewDiamondDialog
