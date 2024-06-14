import { useEffect, useState } from "react"

import { CircleUserRound, Info, Mail, MapPin, Phone, User } from "lucide-react"
import { toast } from "sonner"

import { IUpdateUser, IUser } from "@/types/user.interface"

import { usePutUser } from "@/apis/userApi"

import { getUsername } from "@/lib/utils"

import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

interface SettingInformationFormProps {
  user: IUser
}

function SettingInformationForm({ user }: SettingInformationFormProps) {
  const [formData, setFormData] = useState<IUser>(user)
  const [username, setUsername] = useState<string>("")

  const { mutate: saveUser } = usePutUser()

  useEffect(() => {
    setUsername(getUsername(formData.email) || "")
  }, [formData.email])

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.target
    setFormData((prevData) => ({ ...prevData, [name]: value }))
  }

  const handleSubmit = () => {
    const { id, email, fullName, phoneNumber, address, roles } = formData

    if (!id) {
      toast.error("User ID is missing, cannot update profile")
      return
    }

    const role = roles.length > 0 ? roles[0] : ""

    const newUserData: IUpdateUser = {
      id,
      email,
      fullName,
      phone: phoneNumber,
      address,
      role
    }

    // console.log("newUserData", newUserData);

    saveUser(newUserData)
  }

  const confirmCancel = () => {
    setFormData(user)
  }

  const confirmSave = () => {
    handleSubmit()
  }

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
              name="fullName"
              type="text"
              value={formData.fullName}
              placeholder="Full Name"
              onChange={handleChange}
              className="input-field bg-slate-100 pl-12"
            />
            <User
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>
        </div>

        <div className="w-full">
          <div className="relative">
            <input
              name="phoneNumber"
              type="text"
              value={formData.phoneNumber}
              placeholder="Phone"
              onChange={handleChange}
              className="input-field bg-slate-100 pl-12"
            />
            <Phone
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>
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
            className="input-field bg-slate-100 pl-12"
          />
          <Mail
            size={20}
            className="absolute left-3 top-3 flex text-secondary"
          />
        </div>
      </div>

      <div className="flex justify-between gap-4">
        <div className="w-full">
          <div className="relative">
            <input
              name="username"
              type="text"
              value={username}
              readOnly
              className="input-field bg-slate-100 pl-12"
            />
            <CircleUserRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
          </div>
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
            className="input-field bg-slate-100 pl-12"
          />
          <MapPin
            size={20}
            className="absolute left-3 top-3 flex text-secondary"
          />
        </div>
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
            readOnly
            className="mb-1 w-full resize-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
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
  )
}

export default SettingInformationForm
