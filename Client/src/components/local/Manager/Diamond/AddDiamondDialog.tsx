import { useEffect, useState } from "react";
import { useForm, SubmitHandler, Controller } from "react-hook-form";
import { z } from "zod";
import { zodResolver } from "@hookform/resolvers/zod";
import { Button } from "@/components/global/atoms/button";
import {
  Dialog,
  DialogContent,
  DialogFooter,
  DialogHeader,
  DialogTitle,
} from "@/components/global/atoms/dialog";
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent";
import { ref, uploadBytesResumable, getDownloadURL } from "firebase/storage";
import { diamoonDB } from "@/lib/firebase";
import { Input } from "@/components/global/atoms/input";
import {
  Tabs,
  TabsContent,
  TabsList,
  TabsTrigger,
} from "@/components/global/molecules/UploadImageTab";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";
import { diamondSchema } from "@/schemas/AddDiamondForm";
import {
  IDiamondClarity,
  IDiamondColor,
  IDiamondShape,
  IDiamondFluorescence,
  IDiamondQualityOfCut,
  IDiamondCertification,
} from "@/types/diamond.interface";

type DiamondFormValues = z.infer<typeof diamondSchema>;

function AddDiamondDialog() {
  const [imageUrl, setImageUrl] = useState<string>("");
  const [isDialogOpen, setIsDialogOpen] = useState<boolean>(false);
  const [newPhoto, setNewPhoto] = useState<File | null>(null);
  const [uploadProgress, setUploadProgress] = useState(0);
  const [imageMethod, setImageMethod] = useState<"upload" | "url">("upload");

  const handleSave = () => {
    if (newPhoto) {
      const storageRef = ref(diamoonDB, `Test/${newPhoto.name}`);
      const uploadTask = uploadBytesResumable(storageRef, newPhoto);

      uploadTask.on(
        "state_changed",
        (snapshot) => {
          const progress =
            (snapshot.bytesTransferred / snapshot.totalBytes) * 100;
          setUploadProgress(progress);
        },
        (error) => {
          console.error("Upload failed:", error);
        },
        async () => {
          const downloadURL = await getDownloadURL(uploadTask.snapshot.ref);
          setImageUrl(downloadURL);
        },
      );
    }
  };

  const {
    register,
    handleSubmit,
    control,
    reset,
    watch,
    formState: { errors, isDirty },
  } = useForm<DiamondFormValues>({
    resolver: zodResolver(diamondSchema),
  });

  const watchImageUrl = watch("image");

  useEffect(() => {
    if (imageMethod === "url") {
      setImageUrl(watchImageUrl);
    }
  }, [watchImageUrl, imageMethod]);

  const onSubmit: SubmitHandler<DiamondFormValues> = (data) => {
    if (imageMethod === "upload") {
      handleSave();
    } else {
      console.log("Diamond data:", data);
    }
    setIsDialogOpen(false);
  };

  const handleClear = () => {
    reset({
      shape: "",
      weight: undefined,
      colorLevel: "",
      clarity: "",
      certification: "",
      size: undefined,
      fluorescence: "",
      qualityOfCut: "",
      image: "",
    });
    setUploadProgress(0);
    setNewPhoto(null);
    setImageUrl("");
  };

  const handleConfirmCancel = () => {
    handleClear();
    setIsDialogOpen(false);
  };

  return (
    <>
      <Button
        onClick={() => setIsDialogOpen(true)}
        className="flex gap-2 bg-gray-800 pl-5 hover:bg-gray-900"
      >
        Add Diamond
      </Button>

      <Dialog
        open={isDialogOpen}
        onOpenChange={(open) => {
          if (!open) {
            handleClear();
          }
          setIsDialogOpen(open);
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
                        setNewPhoto(e.target.files[0]);
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
                    {...register("image")}
                    placeholder="Image URL"
                    className="input-field mt-1"
                  />
                </TabsContent>

                {errors.image && (
                  <p className="mt-1 text-sm text-red-600">
                    {errors.image.message}
                  </p>
                )}
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
                        field.onChange(value);
                        console.log("Shape:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select shape" />
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
                        field.onChange(value);
                        console.log("Color:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
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
                        field.onChange(value);
                        console.log("Clarity:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
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
                        field.onChange(value);
                        console.log("Certification:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
                        <SelectValue placeholder="Select certification" />
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
                        field.onChange(value);
                        console.log("Fluorescence:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
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
                        field.onChange(value);
                        console.log("Quality of Cut:", value);
                      }}
                    >
                      <SelectTrigger className="mt-1 w-full">
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
  );
}

export default AddDiamondDialog;
