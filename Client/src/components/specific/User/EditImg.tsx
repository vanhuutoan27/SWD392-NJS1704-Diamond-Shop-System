import React, { useState } from "react";
import { IUser } from "@/types/user.interface";
import { Upload } from "lucide-react";

// Define the user schema with zod

interface EditUserFormProps {
  user: IUser;
  onSave: (user: IUser) => void;
}

const EditUserForm: React.FC<EditUserFormProps> = ({ user }) => {
  const [formData, setFormData] = useState<IUser>(user);

  const handleCancel = () => {
    setFormData(user); // Reset form data to the initial user prop
  };

  return (
    <form className="flex max-h-[404px] flex-col justify-between space-y-5 border-2 border-gray-100 bg-white pb-8 shadow-md">
      <div className="border-b-2 border-gray-100 p-3">
        <p className="ml-3">Your Photo</p>{" "}
      </div>

      <div className="ml-5 flex w-full pr-10">
        <div className="flex w-1/3 items-center">
          <img
            src={formData.avatar}
            className="h-20 w-20 rounded-full object-cover"
          />
        </div>

        <div className="flex w-2/3 flex-col justify-center">
          <p className="text-sm">Edit your photo</p>
          <button className="flex cursor-pointer text-xs text-gray-500 hover:text-blue-700">
            Delete
          </button>
        </div>
      </div>

      <div className="ml-5 mr-5 flex h-[178px] cursor-pointer items-center justify-center border-[1px] border-dashed border-blue-700 bg-blue-50">
        <div className="flex flex-col items-center justify-center text-center">
          <div className="flex h-10 w-10 items-center justify-center rounded-full border-[1px]  bg-white hover:bg-gray-100">
            <Upload className="pb-1 text-blue-800" />
          </div>
          <div className="mt-2 flex justify-center text-center">
            <span className="font-mono text-sm text-blue-500 hover:text-blue-800">
              Click here to upload the photo
            </span>
          </div>
        </div>
      </div>

      <div className="mr-5 flex justify-end">
        <button
          type="button"
          onClick={handleCancel}
          className="rounded-md border-2 bg-white px-2 py-2 text-sm font-medium text-black hover:border-red-600 hover:bg-red-600 hover:text-white"
        >
          Cancel
        </button>
        <button
          type="submit"
          className="rounded-md bg-blue-600 px-4 py-2 text-sm font-medium text-white hover:bg-blue-800"
        >
          Save
        </button>
      </div>
    </form>
  );
};

export default EditUserForm;
