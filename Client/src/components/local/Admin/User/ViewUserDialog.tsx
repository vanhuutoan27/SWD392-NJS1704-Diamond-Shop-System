import { Button } from "@/components/global/atoms/button";
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle,
} from "@/components/global/atoms/dialog";
import { useGetUserById } from "@/apis/userApi";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";
import { Loader } from "@/components/global/atoms/Loader";
import { useState, useEffect } from "react";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";

function ViewUserDialog({
  userId,
  onClose,
}: {
  userId: string;
  onClose: () => void;
}) {
  const { data: userDetails, isLoading, error } = useGetUserById(userId || "");
  const [isEditing, setIsEditing] = useState(false);
  const [formData, setFormData] = useState({
    roles: "",
    email: "",
    fullName: "",
    phoneNumber: "",
    address: "",
  });

  useEffect(() => {
    if (userDetails) {
      setFormData({
        roles: userDetails.roles[0] || "",
        email: userDetails.email || "",
        fullName: userDetails.fullName || "",
        phoneNumber: userDetails.phoneNumber || "",
        address: userDetails.address || "",
      });
    }
  }, [userDetails]);

  if (!userDetails || isLoading) {
    return <Loader />;
  }

  if (error) {
    return <NotFoundPage />;
  }

  const handleEditClick = () => {
    setIsEditing((prev) => !prev);
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSelectChange = (value: string) => {
    setFormData((prev) => ({ ...prev, roles: value }));
  };

  return (
    <Dialog open={true} onOpenChange={onClose}>
      <DialogContent>
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View User
          </DialogTitle>
        </DialogHeader>
        <div className="grid gap-4 p-2">
          <div className="grid grid-cols-4 items-center">
            <span className="text-sm font-medium">Role</span>
            <div className="col-span-3">
              {isEditing ? (
                <Select
                  value={formData.roles}
                  onValueChange={handleSelectChange}
                >
                  <SelectTrigger className="col-span-3 mt-1 h-11 w-full px-5">
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
              ) : (
                <input
                  type="text"
                  value={userDetails.roles[0]}
                  className="input-field"
                  readOnly
                  tabIndex={-1}
                />
              )}
            </div>
          </div>
          <div className="grid grid-cols-4 items-center">
            <span className="text-sm font-medium">Email</span>
            <div className="col-span-3">
              {isEditing ? (
                <input
                  type="email"
                  name="email"
                  value={formData.email}
                  onChange={handleChange}
                  className="input-field"
                />
              ) : (
                <input
                  type="email"
                  value={userDetails.email}
                  className="input-field"
                  readOnly
                  tabIndex={-1}
                />
              )}
            </div>
          </div>
          <div className="grid grid-cols-4 items-center">
            <span className="text-sm font-medium">Full name</span>
            <div className="col-span-3">
              {isEditing ? (
                <input
                  type="text"
                  name="fullName"
                  value={formData.fullName}
                  onChange={handleChange}
                  className="input-field"
                />
              ) : (
                <input
                  type="text"
                  value={userDetails.fullName}
                  className="input-field"
                  readOnly
                  tabIndex={-1}
                />
              )}
            </div>
          </div>
          <div className="grid grid-cols-4 items-center">
            <span className="text-sm font-medium">Phone</span>
            <div className="col-span-3">
              {isEditing ? (
                <input
                  type="text"
                  name="phoneNumber"
                  value={formData.phoneNumber}
                  onChange={handleChange}
                  className="input-field"
                />
              ) : (
                <input
                  type="text"
                  value={userDetails.phoneNumber}
                  className="input-field"
                  readOnly
                  tabIndex={-1}
                />
              )}
            </div>
          </div>
          <div className="grid grid-cols-4 items-center">
            <span className="text-sm font-medium">Address</span>
            <div className="col-span-3">
              {isEditing ? (
                <input
                  type="text"
                  name="address"
                  value={formData.address}
                  onChange={handleChange}
                  className="input-field"
                />
              ) : (
                <input
                  type="text"
                  value={userDetails.address}
                  className="input-field"
                  readOnly
                  tabIndex={-1}
                />
              )}
            </div>
          </div>
        </div>
        <div className="flex justify-end gap-4">
          <div className="justify-between gap-4 hidden">
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

          <Button onClick={onClose}>Close</Button>
        </div>
      </DialogContent>
    </Dialog>
  );
}

export default ViewUserDialog;
