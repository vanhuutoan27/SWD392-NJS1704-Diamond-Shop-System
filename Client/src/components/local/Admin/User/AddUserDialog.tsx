import React, { useState } from "react";
import { Button } from "@/components/global/atoms/button";
import {
  Dialog,
  DialogContent,
  DialogFooter,
  DialogHeader,
  DialogTitle,
} from "@/components/global/atoms/dialog";
import { Eye, EyeOff, Plus } from "lucide-react";
import { userSchema } from "@/schemas/UserForm";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent";

function AddUserDialog() {
  const [isDialogOpen, setIsDialogOpen] = useState(false);

  const [role, setRole] = useState("");
  const [email, setEmail] = useState("");
  const [name, setName] = useState("");
  const [phone, setPhone] = useState("");
  const [address, setAddress] = useState("");
  const [password, setPassword] = useState("");
  const [errors, setErrors] = useState<Record<string, string>>({});

  const [isShowPassword, setIsShowPassword] = useState(false);
  const [isFormChanged, setIsFormChanged] = useState(false);

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword);
  };

  const handleClear = () => {
    setRole("");
    setEmail("");
    setName("");
    setPhone("");
    setAddress("");
    setPassword("");
    setErrors({});
    setIsFormChanged(false);
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();

    const formData = {
      role: role || "Customer",
      email,
      name,
      phone,
      address,
      password,
    };

    const result = userSchema.safeParse(formData);
    if (result.success) {
      console.log(formData);
      setErrors({});
      setIsFormChanged(false);
      setIsDialogOpen(false);
    } else {
      const flattenedErrors: Record<string, string> = {};
      result.error.errors.map((err) => {
        if (err.path) {
          flattenedErrors[err.path[0]] = err.message;
        }
      });
      setErrors(flattenedErrors);
    }
  };

  const handleChangeRole = (value: string) => {
    setRole(value);
    setIsFormChanged(true);
  };

  const handleInputChange =
    (setter: React.Dispatch<React.SetStateAction<string>>) =>
    (e: React.ChangeEvent<HTMLInputElement>) => {
      setter(e.target.value);
      setIsFormChanged(true);
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
        <Plus size={20} /> Add User
      </Button>
      {isDialogOpen && (
        <Dialog open={isDialogOpen} onOpenChange={setIsDialogOpen}>
          <DialogContent>
            <DialogHeader>
              <DialogTitle className="text-center text-xl font-semibold">
                Add User
              </DialogTitle>
            </DialogHeader>
            <form onSubmit={handleSubmit} className="grid gap-4 py-2">
              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Role</span>
                <Select value={role} onValueChange={handleChangeRole}>
                  <SelectTrigger className="col-span-3 mb-1 h-11 w-full rounded-md border-[1.5px] bg-transparent px-5 py-3 text-sm text-secondary outline-none">
                    <SelectValue placeholder="Select Role" />
                  </SelectTrigger>
                  <SelectContent>
                    <SelectGroup>
                      <SelectItem value="Customer">Customer</SelectItem>
                      <SelectItem value="SalesStaff">Sales Staff</SelectItem>
                      <SelectItem value="DeliveryStaff">
                        Delivery Staff
                      </SelectItem>
                      <SelectItem value="Manager">Manager</SelectItem>
                      <SelectItem value="Admin">Admin</SelectItem>
                    </SelectGroup>
                  </SelectContent>
                </Select>
              </div>

              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Email</span>
                <div className="col-span-3">
                  <input
                    value={email}
                    onChange={handleInputChange(setEmail)}
                    className="input-field"
                    placeholder="Enter Email"
                  />
                  {errors.email && (
                    <p className="text-sm text-red-600">{errors.email}</p>
                  )}
                </div>
              </div>

              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Full name</span>
                <div className="col-span-3">
                  <input
                    value={name}
                    onChange={handleInputChange(setName)}
                    placeholder="Enter Full name"
                    className="input-field"
                  />
                  {errors.name && (
                    <p className="text-sm text-red-600">{errors.name}</p>
                  )}
                </div>
              </div>

              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Phone</span>
                <div className="col-span-3">
                  <input
                    value={phone}
                    onChange={handleInputChange(setPhone)}
                    className="input-field"
                    placeholder="Enter Phone"
                  />
                  {errors.phone && (
                    <p className="text-sm text-red-600">{errors.phone}</p>
                  )}
                </div>
              </div>

              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Address</span>
                <div className="col-span-3">
                  <input
                    value={address}
                    onChange={handleInputChange(setAddress)}
                    className="input-field"
                    placeholder="Enter Address"
                  />
                  {errors.address && (
                    <p className="text-sm text-red-600">{errors.address}</p>
                  )}
                </div>
              </div>

              <div className="grid grid-cols-4 items-center">
                <span className="text-sm">Password</span>
                <div className="col-span-3">
                  <div className="relative mb-1 flex items-center rounded-md border-[1.5px] bg-transparent px-5">
                    <input
                      type={isShowPassword ? "text" : "password"}
                      value={password}
                      onChange={handleInputChange(setPassword)}
                      placeholder={"Enter Password"}
                      className="mr-3 w-full rounded-md bg-transparent py-3 text-sm outline-none"
                    />
                    {isShowPassword ? (
                      <Eye
                        size={20}
                        className="cursor-pointer select-none text-primary"
                        onClick={toggleShowPassword}
                      />
                    ) : (
                      <EyeOff
                        size={20}
                        className="cursor-pointer select-none text-slate-400"
                        onClick={toggleShowPassword}
                      />
                    )}
                  </div>
                  {errors.password && (
                    <p className="text-sm text-red-600">{errors.password}</p>
                  )}
                </div>
              </div>

              <DialogFooter className="mt-4">
                {isFormChanged ? (
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
      )}
    </>
  );
}

export default AddUserDialog;
