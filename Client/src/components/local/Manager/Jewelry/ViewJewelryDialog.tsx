import { useEffect, useRef, useState } from "react"

import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetJewelryById } from "@/apis/jewelryApi"

import { formatCurrencyWithoutVND, formatDate } from "@/lib/utils"

import { Loader } from "@/components/global/atoms/Loader"
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
  jewelryId,
  onClose
}: {
  jewelryId: string
  onClose: () => void
}) {
  const {
    data: jewelryDetails,
    isLoading,
    error
  } = useGetJewelryById(jewelryId)

  const [imageLoaded, setImageLoaded] = useState(false)
  const [isEditing, setIsEditing] = useState(false)
  const [selectedImageIndex, setSelectedImageIndex] = useState(0)
  const [formData, setFormData] = useState({
    jewelryId: "",
    skuID: "",
    images: "",
    jewelryCategory: "",
    jewelryName: "",
    mainStoneSize: "",
    sideStoneType: "",
    sideStoneQuantity: 0,
    stoneWeight: 0,
    goldType: "",
    goldKarat: "",
    goldWeight: 0,
    price: 0,
    dateCreated: "",
    dateModified: ""
  })

  const dialogRef = useRef<HTMLDivElement | null>(null)

  useEffect(() => {
    if (jewelryDetails) {
      setSelectedImageIndex(0)

      setFormData({
        jewelryId: jewelryDetails.jewelryId || "",
        skuID: jewelryDetails.skuID || "",
        jewelryName: jewelryDetails.jewelryName || "",
        jewelryCategory: jewelryDetails.jewelryCategory || "",
        mainStoneSize: jewelryDetails.mainStoneSize || "",
        sideStoneType: jewelryDetails.sideStoneType || "",
        sideStoneQuantity: jewelryDetails.sideStoneQuantity || 0,
        stoneWeight: jewelryDetails.stoneWeight || 0,
        goldType: jewelryDetails.goldType || "",
        goldKarat: jewelryDetails.goldKarat || "",
        goldWeight: jewelryDetails.goldWeight || 0,
        price: jewelryDetails.price || 0,
        images: jewelryDetails.images[0] || "",
        dateCreated: jewelryDetails.dateCreated || "",
        dateModified: jewelryDetails.dateModified || ""
      })
    }
  }, [jewelryDetails])

  const handleEditClick = () => {
    setIsEditing((prev) => !prev)
  }

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleSelectChange = (name: string, value: string) => {
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleConfirmCancel = () => {
    if (jewelryDetails) {
      setFormData({
        jewelryId: jewelryDetails.jewelryId || "",
        skuID: jewelryDetails.skuID || "",
        jewelryName: jewelryDetails.jewelryName || "",
        jewelryCategory: jewelryDetails.jewelryCategory || "",
        mainStoneSize: jewelryDetails.mainStoneSize || "",
        sideStoneType: jewelryDetails.sideStoneType || "",
        sideStoneQuantity: jewelryDetails.sideStoneQuantity || 0,
        stoneWeight: jewelryDetails.stoneWeight || 0,
        goldType: jewelryDetails.goldType || "",
        goldKarat: jewelryDetails.goldKarat || "",
        goldWeight: jewelryDetails.goldWeight || 0,
        price: jewelryDetails.price || 0,
        images: jewelryDetails.images[0] || "",
        dateCreated: jewelryDetails.dateCreated || "",
        dateModified: jewelryDetails.dateModified || ""
      })
    }
    setIsEditing(false)
  }

  if (!jewelryDetails || isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent ref={dialogRef} className="min-w-[1200px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Jewelry Details
          </DialogTitle>
        </DialogHeader>
        <div>
          <div className="grid grid-cols-8 gap-4">
            <div className="col-span-2 flex flex-col items-center rounded-md">
              {!imageLoaded && (
                <Skeleton className="h-[250px] w-[250px] rounded-md border-2 border-gray-800" />
              )}
              <img
                src={jewelryDetails.images[selectedImageIndex]}
                onLoad={() => setImageLoaded(true)}
                className={`h-[250px] w-[250px] rounded-md border-2 border-gray-800 object-cover ${imageLoaded ? "block" : "hidden"}`}
              />
              <div className="mt-2">
                {jewelryDetails.images.map((_image: string, index: number) => (
                  <button
                    key={index}
                    onClick={() => setSelectedImageIndex(index)}
                    className={`slow mx-1 rounded-full p-[5px] ${
                      index === selectedImageIndex
                        ? "bg-primary px-4"
                        : "bg-gray-300"
                    }`}
                  />
                ))}
              </div>
            </div>

            <div className="col-span-6">
              <div className="mb-4">
                <span className="ml-1 text-sm font-medium">Jewelry ID</span>
                <input
                  type="text"
                  name="jewelryId"
                  value={formData.skuID}
                  readOnly
                  className="input-field mt-1 w-full"
                  tabIndex={-1}
                />
              </div>
              <div className="grid grid-cols-3 gap-4">
                <div>
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
                <div>
                  <span className="ml-1 text-sm font-medium">
                    Date Modified
                  </span>
                  <input
                    type="text"
                    name="dateModified"
                    value={formatDate(formData.dateModified)}
                    readOnly
                    className="input-field mt-1"
                    tabIndex={-1}
                  />
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">
                    Jewelry Category
                  </span>
                  {isEditing ? (
                    <Select
                      value={formData.jewelryCategory}
                      onValueChange={(value) =>
                        handleSelectChange("jewelryCategory", value)
                      }
                    >
                      <SelectTrigger className="mt-1 h-11 w-full px-5">
                        <SelectValue placeholder="Select category" />
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
                  ) : (
                    <input
                      type="text"
                      name="jewelryCategory"
                      value={formData.jewelryCategory}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">Jewelry Name</span>
                  <input
                    type="text"
                    name="jewelryName"
                    value={formData.jewelryName}
                    onChange={handleChange}
                    readOnly={!isEditing}
                    className="input-field mt-1"
                    tabIndex={-1}
                  />
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">
                    Main Stone Size
                  </span>
                  {isEditing ? (
                    <input
                      type="text"
                      placeholder="e.g., Round 5ly"
                      className="input-field mt-1"
                      value={formData.mainStoneSize}
                      name="mainStoneSize"
                      onChange={handleChange}
                    />
                  ) : (
                    <input
                      type="text"
                      name="mainStoneSize"
                      value={formData.mainStoneSize}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">
                    Side Stone Type
                  </span>
                  {isEditing ? (
                    <Select
                      value={formData.sideStoneType}
                      onValueChange={(value) =>
                        handleSelectChange("sideStoneType", value)
                      }
                    >
                      <SelectTrigger className="mt-1 h-11 w-full px-5">
                        <SelectValue placeholder="Select category" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="Diamond">Diamond</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  ) : (
                    <input
                      type="text"
                      name="sideStoneType"
                      value={formData.sideStoneType}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">
                    Side Stone Quantity
                  </span>
                  {isEditing ? (
                    <input
                      type="number"
                      placeholder="e.g., 5"
                      className="input-field mt-1"
                      value={formData.sideStoneQuantity}
                      name="sideStoneQuantity"
                      onChange={handleChange}
                    />
                  ) : (
                    <input
                      type="text"
                      name="sideStoneQuantity"
                      value={formData.sideStoneQuantity}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">
                    Side Stone Weight
                  </span>
                  {isEditing ? (
                    <input
                      type="number"
                      placeholder="e.g., 1.5"
                      className="input-field mt-1"
                      value={formData.stoneWeight}
                      name="stoneWeight"
                      onChange={handleChange}
                    />
                  ) : (
                    <input
                      type="text"
                      name="stoneWeight"
                      value={formData.stoneWeight}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">Gold Type</span>
                  {isEditing ? (
                    <Select
                      value={formData.goldType}
                      onValueChange={(value) =>
                        handleSelectChange("goldType", value)
                      }
                    >
                      <SelectTrigger className="mt-1 h-11 w-full px-5">
                        <SelectValue placeholder="Select category" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectGroup>
                          <SelectItem value="White gold">White gold</SelectItem>
                        </SelectGroup>
                      </SelectContent>
                    </Select>
                  ) : (
                    <input
                      type="text"
                      name="goldType"
                      value={formData.goldType}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">Gold Karat</span>
                  {isEditing ? (
                    <input
                      type="text"
                      placeholder="e.g., 18k"
                      className="input-field mt-1"
                      value={formData.goldKarat}
                      name="goldKarat"
                      onChange={handleChange}
                    />
                  ) : (
                    <input
                      type="text"
                      name="goldKarat"
                      value={formData.goldKarat}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
                  <span className="ml-1 text-sm font-medium">Gold Weight</span>
                  {isEditing ? (
                    <input
                      type="text"
                      placeholder="e.g., 5"
                      className="input-field mt-1"
                      value={formData.goldWeight}
                      name="goldWeight"
                      onChange={handleChange}
                    />
                  ) : (
                    <input
                      type="text"
                      name="goldWeight"
                      value={formData.goldWeight}
                      readOnly
                      className="input-field mt-1"
                      tabIndex={-1}
                    />
                  )}
                </div>

                <div>
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
            </div>
          </div>

          <div className="mt-4 flex justify-between gap-4">
            <div className="flex justify-between gap-4">
              <Button type="button" onClick={handleEditClick}>
                {isEditing ? "Save" : "Edit"}
              </Button>
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
            </div>
            <Button type="button" onClick={onClose}>
              Close
            </Button>
          </div>
        </div>
      </DialogContent>
    </Dialog>
  )
}

export default ViewDiamondDialog