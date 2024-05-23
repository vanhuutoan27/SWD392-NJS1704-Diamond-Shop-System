import React, { useState, useEffect } from "react";
import { IUser } from "@/types/user.interface";
import { getUsername } from "@/lib/utils";
import {
  CircleUserRound,
  Eye,
  EyeOff,
  Info,
  KeyRound,
  Mail,
  MapPin,
  Phone,
  User,
} from "lucide-react";
import { userSchema } from "@/schemas/UserForm";
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent";
import { toast } from "sonner";

interface SettingFormProps {
  user: IUser;
  onSave: (user: IUser) => void;
}

function SettingForm({ user, onSave }: SettingFormProps) {
  const [isShowPassword, setIsShowPassword] = useState(false);
  const [formData, setFormData] = useState<IUser>(user);
  const [errors, setErrors] = useState<{ [key: string]: string }>({});
  const [username, setUsername] = useState<string>("");

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword);
  };

  useEffect(() => {
    setUsername(getUsername(formData.email) || "");
  }, [formData.email]);

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
      result.error.issues.forEach((issue) => {
        const path = issue.path[0] as string;
        newErrors[path] = issue.message;
      });
      return newErrors;
    }
    return {};
  };

  const handleSubmit = () => {
    const newErrors = validate();
    if (Object.keys(newErrors).length > 0) {
      setErrors(newErrors);
      toast.error("Incorrect information entered !");
    } else {
      onSave(formData);
      setErrors({});
      toast.success("Information updated successfully");
    }
  };

  const confirmCancel = () => {
    setFormData(user);
    setErrors({});
  };

  const confirmSave = () => {
    handleSubmit();
  };

  return (
    <form
      onSubmit={(e) => e.preventDefault()}
      className="flex flex-col gap-4 rounded-md border-2 border-input bg-white p-5 shadow-md"
    >
      <h4 className="mb-2 ml-2 text-lg font-medium">Personal Information</h4>

      <div className="flex justify-between gap-4">
        <div className="w-full">
          <div className="relative">
            <input
              name="name"
              type="text"
              value={formData.name}
              placeholder="Full Name"
              onChange={handleChange}
              className="mb-1 w-full rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <User
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>

          {errors.name && (
            <div className="text-sm text-red-600">{errors.name}</div>
          )}
        </div>

        <div className="w-full">
          <div className="relative">
            <input
              name="phone"
              type="text"
              value={formData.phone}
              placeholder="Phone"
              onChange={handleChange}
              className="mb-1 w-full rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <Phone
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>

          {errors.phone && (
            <div className="text-sm text-red-600">{errors.phone}</div>
          )}
        </div>
      </div>

      <div className="w-full">
        <div className="relative">
          <input
            name="email"
            type="email"
            value={formData.email}
            placeholder="Email"
            onChange={handleChange}
            className="mb-1 w-full rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
          />
          <Mail
            size={20}
            className="absolute left-3 top-3 flex text-secondary"
          />
        </div>

        {errors.email && (
          <div className="text-sm text-red-600">{errors.email}</div>
        )}
      </div>

      <div className="flex justify-between gap-4">
        <div className="w-full">
          <div className="relative">
            <input
              name="username"
              type="text"
              value={username}
              readOnly
              className="mb-1 w-full rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <CircleUserRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>
        </div>

        <div className="w-full">
          <div className="relative">
            <input
              name="password"
              type={isShowPassword ? "text" : "password"}
              value={formData.password}
              placeholder="Password"
              onChange={handleChange}
              className="mb-1 w-full select-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />

            <KeyRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />

            {isShowPassword ? (
              <Eye
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-primary"
                onClick={toggleShowPassword}
              />
            ) : (
              <EyeOff
                size={16}
                className="absolute right-4 top-[14px]  cursor-pointer text-slate-400"
                onClick={toggleShowPassword}
              />
            )}
          </div>

          {errors.password && (
            <div className="text-sm text-red-600">{errors.password}</div>
          )}
        </div>
      </div>

      <div className="w-full">
        <div className="relative">
          <input
            name="address"
            type="text"
            value={formData.address}
            placeholder="Address"
            onChange={handleChange}
            className="mb-1 w-full rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
          />
          <MapPin
            size={20}
            className="absolute left-3 top-3 flex text-secondary"
          />
        </div>

        {errors.address && (
          <div className="text-sm text-red-600">{errors.address}</div>
        )}
      </div>

      <div className="w-full">
        <div className="relative">
          <textarea
            name="bio"
            rows={5}
            value={
              "Diamond buyers are often discerning individuals who seek the highest quality gems. They prioritize clarity, cut, and carat weight, aiming for stones with exceptional brilliance and rarity. Their investment reflects a blend of luxury and timeless elegance."
            }
            placeholder="Bio"
            className="mb-1 w-full resize-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            readOnly
          />
          <Info
            size={20}
            className="absolute left-3 top-3 flex text-secondary"
          />
        </div>
      </div>

      <div className="flex justify-end gap-4">
        <AlertDialogComponent
          variant="secondary"
          actionBtn="Cancel"
          title="Confirm Cancel"
          description="Are you sure you want to cancel? All changes will be lost."
          action="Confirm"
          onConfirm={confirmCancel}
        />

        <AlertDialogComponent
          variant="default"
          actionBtn="Save"
          title="Confirm Save"
          description="Are you sure you want to save these changes?"
          action="Save"
          onConfirm={confirmSave}
        />
      </div>
    </form>
  );
}

export default SettingForm;
