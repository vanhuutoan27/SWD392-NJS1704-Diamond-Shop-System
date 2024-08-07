import { useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import { Eye, EyeOff, KeyRound, Mail } from "lucide-react"
import { Link } from "react-router-dom"
import { toast } from "sonner"

import { IUser } from "@/types/user.interface"

import { useChangePasswordUser } from "@/apis/userApi"

import {
  AlertDialog,
  AlertDialogAction,
  AlertDialogContent,
  AlertDialogDescription,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogTitle
} from "@/components/global/atoms/alert-dialog"
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

interface SettingPasswordFormProps {
  user: IUser
}

function SettingPasswordForm({ user }: SettingPasswordFormProps) {
  const { logout } = useAuthContext()

  const [isShowOldPassword, setIsShowOldPassword] = useState(false)
  const [isShowNewPassword, setIsShowNewPassword] = useState(false)
  const [isShowConfirmPassword, setIsShowConfirmPassword] = useState(false)
  const [passwordData, setPasswordData] = useState({
    oldPassword: "",
    newPassword: "",
    confirmPassword: ""
  })
  const [errors, setErrors] = useState<{ [key: string]: string }>({})
  const [isDialogOpen, setIsDialogOpen] = useState(false)

  const handlePasswordChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target
    setPasswordData({ ...passwordData, [name]: value })
  }

  const { mutate: changePassword } = useChangePasswordUser()

  const handlePasswordSubmit = () => {
    if (passwordData.newPassword !== passwordData.confirmPassword) {
      toast.error("New password and confirm password do not match")
    } else {
      changePassword(
        {
          oldPassword: passwordData.oldPassword,
          newPassword: passwordData.newPassword
        },
        {
          onSuccess: () => {
            toast.success("Password changed successfully")
            setIsDialogOpen(true)
          }
        }
      )
    }
  }
  const confirmCancel = () => {
    setPasswordData({
      oldPassword: "",
      newPassword: "",
      confirmPassword: ""
    })
    setErrors({})
  }

  return (
    <>
      <form
        onSubmit={(e) => e.preventDefault()}
        className="flex flex-col gap-4 rounded-md border-2 border-input bg-white p-5 shadow-md"
      >
        <h4 className="mb-2 ml-2 text-lg font-medium">Password</h4>
        <div className="w-full">
          <div className="relative">
            <input
              name="email"
              type="email"
              value={user.email}
              placeholder="Email"
              readOnly
              className="input-field bg-slate-100 pl-12"
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

        <div className="w-full">
          <div className="relative">
            <input
              name="oldPassword"
              type={isShowOldPassword ? "text" : "password"}
              value={passwordData.oldPassword}
              placeholder="Current Password"
              onChange={handlePasswordChange}
              className="mb-1 w-full select-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <KeyRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
            {isShowOldPassword ? (
              <Eye
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-primary"
                onClick={() => setIsShowOldPassword(!isShowOldPassword)}
              />
            ) : (
              <EyeOff
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-slate-400"
                onClick={() => setIsShowOldPassword(!isShowOldPassword)}
              />
            )}
          </div>
          {errors.oldPassword && (
            <div className="text-sm text-red-600">{errors.oldPassword}</div>
          )}
        </div>

        <div className="w-full">
          <div className="relative">
            <input
              name="newPassword"
              type={isShowNewPassword ? "text" : "password"}
              value={passwordData.newPassword}
              placeholder="New Password"
              onChange={handlePasswordChange}
              className="mb-1 w-full select-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <KeyRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
            {isShowNewPassword ? (
              <Eye
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-primary"
                onClick={() => setIsShowNewPassword(!isShowNewPassword)}
              />
            ) : (
              <EyeOff
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-slate-400"
                onClick={() => setIsShowNewPassword(!isShowNewPassword)}
              />
            )}
          </div>
          {errors.newPassword && (
            <div className="text-sm text-red-600">{errors.newPassword}</div>
          )}
        </div>

        <div className="w-full">
          <div className="relative">
            <input
              name="confirmPassword"
              type={isShowConfirmPassword ? "text" : "password"}
              value={passwordData.confirmPassword}
              placeholder="Confirm New Password"
              onChange={handlePasswordChange}
              className="mb-1 w-full select-none rounded-md border-[1.5px] bg-slate-100 py-3 pl-10 pr-5 text-sm outline-none"
            />
            <KeyRound
              size={20}
              className="absolute left-3 top-3 flex text-secondary"
            />
            {isShowConfirmPassword ? (
              <Eye
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-primary"
                onClick={() => setIsShowConfirmPassword(!isShowConfirmPassword)}
              />
            ) : (
              <EyeOff
                size={16}
                className="absolute right-4 top-[14px] cursor-pointer text-slate-400"
                onClick={() => setIsShowConfirmPassword(!isShowConfirmPassword)}
              />
            )}
          </div>
          {errors.confirmPassword && (
            <div className="text-sm text-red-600">{errors.confirmPassword}</div>
          )}
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
            onConfirm={handlePasswordSubmit}
          />
        </div>
      </form>

      <AlertDialog open={isDialogOpen} onOpenChange={setIsDialogOpen}>
        <AlertDialogContent>
          <AlertDialogHeader>
            <AlertDialogTitle>Password Changed</AlertDialogTitle>
            <AlertDialogDescription>
              Your password has been changed successfully. Please log in again.
            </AlertDialogDescription>
          </AlertDialogHeader>
          <AlertDialogFooter>
            <AlertDialogAction
              onClick={() => {
                setIsDialogOpen(false)
                logout()
              }}
            >
              <Link to="/login">OK</Link>
            </AlertDialogAction>
          </AlertDialogFooter>
        </AlertDialogContent>
      </AlertDialog>
    </>
  )
}

export default SettingPasswordForm
