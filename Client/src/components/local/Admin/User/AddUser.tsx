import React, { useState } from "react";
import { Button } from "@/components/global/atoms/button";
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from "@/components/global/atoms/dialog";
import { Input } from "@/components/global/atoms/input";
import { Eye, EyeOff, Plus } from "lucide-react";
import { userSchema } from "@/schemas/UserForm";
import { toast } from "sonner";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";

export function AddUser() {
  const [isShowPassword, setIsShowPassword] = useState(false);
  const [role, setRole] = useState("");
  const [email, setEmail] = useState("");
  const [fullName, setFullName] = useState("");
  const [phone, setPhone] = useState("");
  const [address, setAddress] = useState("");
  const [password, setPassword] = useState("");
  const [errors, setErrors] = useState<Record<string, string>>({});

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword);
  };

  const handleCancel = () => {
    // Reset form fields and errors
    setRole("");
    setEmail("");
    setFullName("");
    setPhone("");
    setAddress("");
    setPassword("");
    setErrors({});
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    const userData = { email, name: fullName, phone, address, password, role };
    const validationResult = userSchema.safeParse(userData);
    if (validationResult.success) {
      // Add API call or logic to save user data
      console.log("DATA FORM:", userData);
      setErrors({});
      toast.success("Add new user successfully");
    } else {
      // Convert Zod error object to a flattened error object
      const flattenedErrors: Record<string, string> = {};
      validationResult.error.errors.map((err) => {
        if (err.path) {
          flattenedErrors[err.path[0]] = err.message;
        }
      });
      setErrors(flattenedErrors);
    }
  };

  const handleChangeRole = (value: string) => {
    console.log("Selected Role:", value); // Log the selected role
    setRole(value); // Update role state with the selected value
  };

  return (
    <Dialog>
      <DialogTrigger asChild>
        <Button className="flex gap-2 pl-5">
          <Plus size={20} /> Add User
        </Button>
      </DialogTrigger>
      <DialogContent>
        <DialogHeader>
          <DialogTitle className="text-center">Add User</DialogTitle>
          <DialogDescription className="text-center">
            Add new user. Click save when you're done.
          </DialogDescription>
        </DialogHeader>
        <form onSubmit={handleSubmit} className="grid gap-4 py-2">
          <div className="grid grid-cols-4 items-center gap-4">
            <label htmlFor="role">Role</label>
            <Select>
              <SelectTrigger className="col-span-3 border-gray-950 text-sm text-black">
                <SelectValue placeholder="Select Role" />
              </SelectTrigger>
              <SelectContent>
                <SelectGroup>
                  <SelectItem
                    value="customer"
                    onSelect={() => handleChangeRole("customer")}
                  >
                    Customer
                  </SelectItem>
                  <SelectItem
                    value="salesStaff"
                    onSelect={() => handleChangeRole("salesStaff")}
                  >
                    SalesStaff
                  </SelectItem>
                  <SelectItem
                    value="deliveryStaff"
                    onSelect={() => handleChangeRole("deliveryStaff")}
                  >
                    DeliveryStaff
                  </SelectItem>
                  <SelectItem
                    value="manager"
                    onSelect={() => handleChangeRole("manager")}
                  >
                    Manager
                  </SelectItem>
                  <SelectItem
                    value="admin"
                    onSelect={() => handleChangeRole("admin")}
                  >
                    Admin
                  </SelectItem>
                </SelectGroup>
              </SelectContent>
            </Select>
            {errors.role && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.role}
              </p>
            )}
          </div>
          <div className="grid grid-cols-4 items-center gap-4">
            <label htmlFor="email">Email</label>
            <Input
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              className="col-span-3"
              placeholder="Enter Email"
            />
            {errors.email && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.email}
              </p>
            )}
          </div>

          <div className="grid grid-cols-4 items-center gap-4">
            <label htmlFor="fullname">Full name</label>
            <Input
              id="fullname"
              value={fullName}
              onChange={(e) => setFullName(e.target.value)}
              placeholder="Enter Full name"
              className="col-span-3 bg-white"
            />
            {errors.name && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.name}
              </p>
            )}
          </div>
          <div className="grid grid-cols-4 items-center gap-4">
            <label htmlFor="phone">Phone</label>
            <Input
              id="phone"
              value={phone}
              onChange={(e) => setPhone(e.target.value)}
              className="col-span-3"
              placeholder="Enter Phone"
            />
            {errors.phone && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.phone}
              </p>
            )}
          </div>
          <div className="grid grid-cols-4 items-center gap-4">
            <label htmlFor="address">Address</label>
            <Input
              id="address"
              value={address}
              onChange={(e) => setAddress(e.target.value)}
              className="col-span-3"
              placeholder="Enter Address"
            />
            {errors.address && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.address}
              </p>
            )}
          </div>
          <div className="relative grid grid-cols-4 items-center gap-4">
            <label htmlFor="password">Password</label>
            <div className="relative col-span-3">
              <input
                name="password"
                type={isShowPassword ? "text" : "password"}
                value={password}
                placeholder="Enter Password"
                onChange={(e) => setPassword(e.target.value)}
                className="w-full rounded-md border-[1.5px] border-gray-950 p-2 text-sm font-normal text-gray-700"
              />
              {isShowPassword ? (
                <Eye
                  size={16}
                  className="absolute right-3 top-1/2 -translate-y-1/2 transform cursor-pointer"
                  onClick={toggleShowPassword}
                />
              ) : (
                <EyeOff
                  size={16}
                  className="absolute right-3 top-1/2 -translate-y-1/2 transform cursor-pointer"
                  onClick={toggleShowPassword}
                />
              )}
            </div>
            {errors.password && (
              <p className="col-span-4 text-end text-sm text-red-500">
                {errors.password}
              </p>
            )}
          </div>

          <DialogFooter className="mt-2 max-sm:flex max-sm:flex-col">
            <Button
              type="button"
              onClick={handleCancel}
              className="w-20 max-sm:ml-0 max-sm:w-1/3"
            >
              Cancel
            </Button>
            <Button type="submit" className="w-20 max-sm:ml-0 max-sm:w-1/3">
              Save
            </Button>
          </DialogFooter>
        </form>
      </DialogContent>
    </Dialog>
  );
}
