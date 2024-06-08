import { useEffect, useRef, useState } from "react";
import { useGetJewelryById } from "@/api/jewelryApi";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle,
} from "@/components/global/atoms/dialog";
import { Button } from "@/components/global/atoms/button";
import { Skeleton } from "@/components/global/atoms/skeleton";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";
import { formatDate } from "@/lib/utils";
import { Loader } from "@/components/global/atoms/Loader";

function ViewDiamondDialog({
  jewelryId,
  onClose,
}: {
  jewelryId: string;
  onClose: () => void;
}) {
  const {
    data: jewelryDetails,
    isLoading,
    error,
  } = useGetJewelryById(jewelryId);

  const [imageLoaded, setImageLoaded] = useState(false);
  const [isEditing, setIsEditing] = useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);
  const [formData, setFormData] = useState({
    jewelryId: "",
    skuID: "",
    jewelryName: "",
    jewelryCategory: "",
    mainStoneSize: "",
    sideStoneType: "",
    sideStoneQuantity: 0,
    stoneWeight: 0,
    goldType: "",
    goldKarat: "",
    goldWeight: 0,
    price: 0,
    images: "",
    dateCreated: "",
    dateModified: "",
  });

  const dialogRef = useRef<HTMLDivElement | null>(null);

  useEffect(() => {
    if (jewelryDetails) {
      setSelectedImageIndex(0); // Reset selected image index when jewelry details change
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
        dateModified: jewelryDetails.dateModified || "",
      });
    }
  }, [jewelryDetails]);

  const handleEditClick = () => {
    setIsEditing((prev) => !prev);
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSelectChange = (name: string, value: string) => {
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  if (!jewelryDetails || isLoading) {
    return <Loader />;
  }

  if (error) {
    return <NotFoundPage />;
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent ref={dialogRef} className="min-w-[800px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Jewelry Details
          </DialogTitle>
        </DialogHeader>
        <div className="mt-4 grid grid-cols-8 gap-4">
          <div className="col-span-4 row-span-3 flex flex-col items-center justify-center rounded-md">
            {!imageLoaded && (
              <Skeleton className="h-[250px] w-[250px] rounded-md border-2 border-gray-800" />
            )}
            <img
              src={jewelryDetails.images[selectedImageIndex]} // Use selectedImageIndex to determine which image to display
              alt="Diamond"
              onLoad={() => setImageLoaded(true)}
              className={`h-[250px] w-[250px] rounded-md border-2 border-gray-800 object-cover ${imageLoaded ? "block" : "hidden"}`}
            />
            <div className="mt-2">
              {jewelryDetails.images.map((_image: string, index: number) => (
                <button
                  key={index}
                  onClick={() => setSelectedImageIndex(index)} // Update selectedImageIndex on button click
                  className={`mx-1 rounded-full p-1 ${
                    index === selectedImageIndex ? "bg-blue-500" : "bg-gray-300"
                  }`}
                />
              ))}
            </div>
          </div>

          <div className="col-span-4">
            <span className="ml-1 text-sm font-medium">Jewelry ID</span>
            <input
              type="text"
              name="jewelryId"
              value={formData.skuID}
              readOnly
              className="input-field mt-1"
              tabIndex={-1}
            />
          </div>
          <div className="col-span-4">
            <span className="ml-1 text-sm font-medium">Jewelry Category</span>
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
            <span className="ml-1 text-sm font-medium">Stone Type</span>
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

          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Stone Size</span>
            {isEditing ? (
              <input
                type="text"
                placeholder="e.g., Round 5ly"
                className="input-field mt-1"
              />
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.mainStoneSize}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>

          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Stone Quantity</span>
            {isEditing ? (
              <input
                type="number"
                placeholder="e.g., Round 5ly"
                className="input-field mt-1"
              />
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.sideStoneQuantity}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>

          <div className="col-span-2">
            <span className="ml-1 text-sm font-medium">Stone Weight</span>
            {isEditing ? (
              <input
                type="number"
                placeholder="e.g., Round 5ly"
                className="input-field mt-1"
              />
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.stoneWeight}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
        </div>

        <div className="mt-1 grid grid-cols-9 gap-4">
          <div className="col-span-3">
            <span className="ml-1 text-sm font-medium">Gold Type</span>
            {isEditing ? (
              <Select
                value={formData.goldType}
                onValueChange={(value) => handleSelectChange("goldType", value)}
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

          <div className="col-span-3">
            <span className="ml-1 text-sm font-medium">Gold Karat</span>
            {isEditing ? (
              <input
                type="text"
                placeholder="e.g., Round 5ly"
                className="input-field mt-1"
              />
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.goldKarat}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>

          <div className="col-span-3">
            <span className="ml-1 text-sm font-medium">Gold Weight</span>
            {isEditing ? (
              <input
                type="text"
                placeholder="e.g., Round 5ly"
                className="input-field mt-1"
              />
            ) : (
              <input
                type="text"
                name="shape"
                value={formData.goldWeight}
                readOnly
                className="input-field mt-1"
                tabIndex={-1}
              />
            )}
          </div>
        </div>
        <div className="mt-1 grid grid-cols-5 gap-4">
        <div className="col-span-2">
          <span className="ml-1 text-sm font-medium">Price (VND)</span>
          <input
            type="number"
            name="price"
            value={formData.price}
            onChange={handleChange}
            readOnly={!isEditing}
            className="input-field mt-1"
            tabIndex={-1}
          />
        </div>
        <div className="col-span-3">
          <span className="ml-1 text-sm font-medium">Name</span>
          <input
            type="text"
            name="jewelryName"
            value={formData.jewelryName}
            onChange={handleChange}
            readOnly
            className="input-field mt-1"
            tabIndex={-1}
          />
        </div>
        </div>
        

        <div className="mt-4 flex justify-between gap-4">
          <div className="flex justify-between gap-4">
            <Button type="button" onClick={handleEditClick}>
              {isEditing ? "Save" : "Edit"}
            </Button>
            {isEditing && (
              <Button
                type="button"
                variant={"secondary"}
                onClick={handleEditClick}
              >
                Cancel
              </Button>
            )}
          </div>
          <Button type="button" onClick={onClose}>
            Close
          </Button>
        </div>
      </DialogContent>
    </Dialog>
  );
}

export default ViewDiamondDialog;
