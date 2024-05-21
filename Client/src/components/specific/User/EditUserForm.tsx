import React, { useState } from "react";
import { IUser } from "@/types/user.interface";
import { z } from "zod";

// Define the user schema with zod
const userSchema = z.object({
  name: z.string().nonempty("Name is required"),
  email: z.string().nonempty("Email is required").email("Email is invalid"),
  phone: z.string().nonempty("Phone number is required"),
});

interface EditUserFormProps {
  user: IUser;
  onSave: (user: IUser) => void;
}

const EditUserForm: React.FC<EditUserFormProps> = ({ user, onSave }) => {
  const [formData, setFormData] = useState<IUser>(user);
  const [errors, setErrors] = useState<{ [key: string]: string }>({});

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>,
  ) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const validate = () => {
    const result = userSchema.safeParse(formData);
    if (!result.success) {
      const newErrors: { [key: string]: string } = {};
      for (const issue of result.error.issues) {
        newErrors[issue.path[0]] = issue.message;
      }
      return newErrors;
    }
    return {};
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    const newErrors = validate();
    if (Object.keys(newErrors).length > 0) {
      setErrors(newErrors);
    } else {
      onSave(formData);
    }
  };

  const handleCancel = () => {
    window.location.reload(); // Refresh the page
  };

  return (
    <form
      onSubmit={handleSubmit}
      className="flex max-h-screen flex-col justify-between space-y-5 border-2 border-gray-100 bg-white shadow-md"
    >
      <div className="border-b-2 border-gray-100 p-3">
        <p className="ml-3">Personal Information</p>{" "}
      </div>
      <div className="ml-5 w-full pr-10">
        <label
          htmlFor="name"
          className="block text-sm font-medium text-gray-700"
        >
          Full Name
        </label>
        <input
          id="name"
          name="name"
          type="text"
          value={formData.name}
          onChange={handleChange}
          className="mt-1 w-full rounded-sm border border-gray-300 bg-blue-100 p-2  shadow-sm"
        />
        {errors.name && (
          <div className="text-sm text-red-600">{errors.name}</div>
        )}
      </div>

      <div className="ml-5 w-full pr-10">
        <label
          htmlFor="phone"
          className="block text-sm font-medium text-gray-700 "
        >
          Phone
        </label>
        <input
          id="phone"
          name="phone"
          type="text"
          value={formData.phone}
          onChange={handleChange}
          className="mt-1 w-full rounded-sm border border-gray-300 bg-blue-100 p-2  shadow-sm"
        />
        {errors.phone && (
          <div className="text-sm text-red-600">{errors.phone}</div>
        )}
      </div>

      <div className="ml-5 w-full pr-10">
        <div>
          <label
            htmlFor="email"
            className="ml-1 block text-sm font-medium text-gray-700"
          >
            Email Address
          </label>
          <input
            id="email"
            name="email"
            type="email"
            value={formData.email}
            onChange={handleChange}
            className="mt-1 w-full rounded-sm border border-gray-300 bg-blue-100 p-2  shadow-sm"
          />
          {errors.email && (
            <div className="text-sm text-red-600">{errors.email}</div>
          )}
        </div>
      </div>

      <div className="mr-5 flex justify-end">
        <button
          type="button"
          onClick={handleCancel}
          className="rounded-md border-2 bg-white px-2 py-2 text-sm font-medium text-black hover:border-red-600 hover:bg-red-600"
        >
          Cancel
        </button>
        <button
          type="submit"
          className="rounded-md bg-blue-600 px-4 py-2 text-sm font-medium text-white hover:bg-blue-700"
        >
          Save
        </button>
      </div>
    </form>
  );
};

export default EditUserForm;
