import React, { useState } from "react";
import { useForm, SubmitHandler } from "react-hook-form";
import { z } from "zod";
import { zodResolver } from "@hookform/resolvers/zod";
import { diamondSchema } from "@/schemas/AddDiamondForm";
import { Button } from "@/components/global/atoms/button";

type DiamondFormValues = z.infer<typeof diamondSchema>;

const CreateDiamondForm: React.FC = () => {
  const [imageUrl, setImageUrl] = useState<string>("");

  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
  } = useForm<DiamondFormValues>({
    resolver: zodResolver(diamondSchema),
  });

  // Watch the image URL field
  const watchImageUrl = watch("image");

  // Update image URL state when the field changes
  React.useEffect(() => {
    setImageUrl(watchImageUrl);
  }, [watchImageUrl]);

  const onSubmit: SubmitHandler<DiamondFormValues> = (data) => {
    console.log("Diamond data:", data);
  };

  return (
    <div className="bg-white p-4">
      <h2 className="mb-4 text-2xl font-bold">Create New Diamond</h2>
      <form onSubmit={handleSubmit(onSubmit)} className="space-y-4">
        <div>
          <label className="block text-sm font-medium text-gray-700">
            Image URL
          </label>
          <input
            type="text"
            {...register("image")}
            placeholder="Enter the image URL"
            className="input-field"
          />
          {errors.image && (
            <p className="mt-1 text-sm text-red-500">{errors.image.message}</p>
          )}
          {imageUrl && (
            <img
              src={imageUrl}
              alt="Diamond"
              className="mt-2 h-40 w-40 object-cover"
            />
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Shape
          </label>
          <input
            type="text"
            {...register("shape")}
            placeholder="Enter the diamond shape (e.g., Round, Pear)"
            className="input-field"
          />
          {errors.shape && (
            <p className="mt-1 text-sm text-red-500">{errors.shape.message}</p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Weight (in carats)
          </label>
          <input
            type="number"
            {...register("weight", { valueAsNumber: true })}
            placeholder="Enter the diamond weight (e.g., 1.5)"
            className="input-field"
          />
          {errors.weight && (
            <p className="mt-1 text-sm text-red-500">{errors.weight.message}</p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Color Level
          </label>
          <input
            type="text"
            {...register("colorLevel")}
            placeholder="Enter the color level (e.g., D, F)"
            className="input-field"
          />
          {errors.colorLevel && (
            <p className="mt-1 text-sm text-red-500">
              {errors.colorLevel.message}
            </p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Clarity
          </label>
          <input
            type="text"
            {...register("clarity")}
            placeholder="Enter the clarity (e.g., VVS2, IF)"
            className="input-field"
          />
          {errors.clarity && (
            <p className="mt-1 text-sm text-red-500">
              {errors.clarity.message}
            </p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Certification
          </label>
          <input
            type="text"
            {...register("certification")}
            placeholder="Enter the certification (e.g., GIA)"
            className="input-field"
          />
          {errors.certification && (
            <p className="mt-1 text-sm text-red-500">
              {errors.certification.message}
            </p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Size (in mm)
          </label>
          <input
            type="number"
            {...register("size", { valueAsNumber: true })}
            placeholder="Enter the size in mm (e.g., 10.5)"
            className="input-field"
          />
          {errors.size && (
            <p className="mt-1 text-sm text-red-500">{errors.size.message}</p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Fluorescence
          </label>
          <input
            type="text"
            {...register("fluorescence")}
            placeholder="Enter the fluorescence (e.g., None, Medium)"
            className="input-field"
          />
          {errors.fluorescence && (
            <p className="mt-1 text-sm text-red-500">
              {errors.fluorescence.message}
            </p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Quality of Cut
          </label>
          <input
            type="text"
            {...register("qualityOfCut")}
            placeholder="Enter the quality of cut (e.g., Excellent)"
            className="input-field"
          />
          {errors.qualityOfCut && (
            <p className="mt-1 text-sm text-red-500">
              {errors.qualityOfCut.message}
            </p>
          )}
        </div>

        <div>
          <label className="block text-sm font-medium text-gray-700">
            Price (in VND)
          </label>
          <input
            type="number"
            {...register("price", { valueAsNumber: true })}
            placeholder="Enter the price (e.g., 535790600)"
            className="input-field"
          />
          {errors.price && (
            <p className="mt-1 text-sm text-red-500">{errors.price.message}</p>
          )}
        </div>
        <Button type="submit">Create Diamond</Button>
      </form>
    </div>
  );
};

export default CreateDiamondForm;
