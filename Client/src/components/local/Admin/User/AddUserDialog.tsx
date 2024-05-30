import { useState } from "react";
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
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent";
import { useForm, UseFormStateReturn } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";
import { INewUser } from "@/types/user.interface";
import { toast } from "sonner";
import { usePostUser } from "@/api/userApi";

function AddUserDialog() {
  const [isDialogOpen, setIsDialogOpen] = useState(false);
  const [isShowPassword, setIsShowPassword] = useState(false);
  const [role, setRole] = useState("Customer");

  const {
    register,
    handleSubmit,
    reset,
    formState: { errors, isDirty },
  } = useForm<INewUser, UseFormStateReturn<INewUser>>({
    resolver: zodResolver(userSchema),
    defaultValues: {
      email: "",
      fullName: "",
      phone: "",
      address: "",
      password: "",
    },
  });

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword);
  };

  const handleClear = () => {
    reset();
  };

  const { mutate: addNewUser } = usePostUser();

  const onSubmit = async (data: INewUser) => {
    try {
      const formData = { ...data, role };
      // console.log("Submitting form data:", formData);

      addNewUser(formData, {
        onSuccess: () => {
          toast.success("Created a new user successfully");
          handleClear();
          setIsDialogOpen(false);
        },
        onError: () => {
          toast.error("Create a new user failed");
        },
      });
    } catch (error) {
      console.error("Error submitting form", error);
      toast.error("Create a new user failed");
    }
  };

  const handleConfirmCancel = () => {
    handleClear();
    setIsDialogOpen(false);
  };

  const handleRoleChange = (value: string) => {
    setRole(value);
  };

  return (
    <>
      <Button
        onClick={() => setIsDialogOpen(true)}
        className="flex gap-2 bg-gray-800 pl-5 hover:bg-gray-900"
      >
        <Plus size={20} /> Add User
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
        <DialogContent>
          <DialogHeader>
            <DialogTitle className="text-center text-xl font-semibold">
              Add User
            </DialogTitle>
          </DialogHeader>
          <form onSubmit={handleSubmit(onSubmit)} className="grid gap-4 p-2">
            <div className="grid grid-cols-4 items-center">
              <span className="text-sm font-medium">Role</span>
              <Select value={role} onValueChange={handleRoleChange}>
                <SelectTrigger className="col-span-3">
                  <SelectValue placeholder="Select Role" />
                </SelectTrigger>
                <SelectContent>
                  <SelectGroup>
                    <SelectItem value="Customer">Customer</SelectItem>
                    <SelectItem value="SaleStaff">Sale Staff</SelectItem>
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
              <span className="text-sm font-medium">Email</span>
              <div className="col-span-3">
                <input
                  {...register("email")}
                  className="input-field"
                  placeholder="Enter Email"
                />
                {errors.email && (
                  <p className="ml-2 text-sm text-red-600">
                    {errors.email?.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-4 items-center">
              <span className="text-sm font-medium">Full name</span>
              <div className="col-span-3">
                <input
                  {...register("fullName")}
                  className="input-field"
                  placeholder="Enter Full name"
                />
                {errors.fullName && (
                  <p className="ml-2 text-sm text-red-600">
                    {errors.fullName?.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-4 items-center">
              <span className="text-sm font-medium">Phone</span>
              <div className="col-span-3">
                <input
                  {...register("phone")}
                  className="input-field"
                  placeholder="Enter Phone"
                />
                {errors.phone && (
                  <p className="ml-2 text-sm text-red-600">
                    {errors.phone?.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-4 items-center">
              <span className="text-sm font-medium">Address</span>
              <div className="col-span-3">
                <input
                  {...register("address")}
                  className="input-field"
                  placeholder="Enter Address"
                />
                {errors.address && (
                  <p className="ml-2 text-sm text-red-600">
                    {errors.address?.message}
                  </p>
                )}
              </div>
            </div>

            <div className="grid grid-cols-4 items-center">
              <span className="text-sm font-medium">Password</span>
              <div className="col-span-3">
                <div className="relative mb-1 flex items-center rounded-md border-[1.5px] bg-transparent px-5">
                  <input
                    type={isShowPassword ? "text" : "password"}
                    {...register("password")}
                    className="mr-3 w-full rounded-md bg-transparent py-3 text-sm outline-none"
                    placeholder="Enter Password"
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
                  <p className="ml-2 text-sm text-red-600">
                    {errors.password?.message}
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

export default AddUserDialog;
