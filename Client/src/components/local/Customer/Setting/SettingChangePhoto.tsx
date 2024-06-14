import React, { useState } from "react"

import { Camera, Upload } from "lucide-react"
import { toast } from "sonner"

import { IUser } from "@/types/user.interface"

import { userAvatar } from "@/lib/constants"

import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

import UploadPhotoDialog from "./UploadPhotoDialog"

interface SettingChangePhotoProps {
  user: IUser
  onSave: (user: IUser) => void
}

const SettingChangePhoto: React.FC<SettingChangePhotoProps> = ({
  user,
  onSave
}) => {
  const [formData, setFormData] = useState<IUser>(user)
  const [showUploadPhotoDialog, setShowUploadPhotoDialog] = useState(false)

  const handleSubmit = () => {
    onSave(formData)
    toast.success("Photo updated successfully")
  }

  const handleChangePhoto = () => {
    setShowUploadPhotoDialog(true)
  }

  const confirmCancel = () => {
    setFormData(user)
  }

  const confirmSave = () => {
    handleSubmit()
  }

  return (
    <>
      <form className="flex flex-col gap-4 rounded-md border-2 border-input bg-white p-5 shadow-md">
        <h4 className="mb-2 ml-2 text-lg font-medium">Your Avatar</h4>
        <div className="flex gap-4">
          <div className="group relative cursor-pointer">
            <img
              src={formData.avatar || userAvatar}
              className="h-16 w-16 rounded-full object-cover"
            />
            <div className="slow absolute inset-0 flex items-center justify-center rounded-full bg-black/30 opacity-0 group-hover:opacity-100">
              <Camera className="text-white" />
            </div>
          </div>

          <div className="flex flex-col justify-center gap-2">
            <span>Update Your Avatar</span>
            <span className="slow flex w-fit cursor-pointer text-sm text-red-600 hover:underline">
              Delete
            </span>
          </div>
        </div>
        <div
          className="mt-2 flex h-[150px] cursor-pointer flex-col items-center justify-center rounded-md border-[1px] border-dashed border-primary bg-slate-100 text-center"
          onClick={handleChangePhoto}
        >
          <div className="flex h-10 w-10 items-center justify-center rounded-full border-[1px] bg-white">
            <Upload size={20} className="text-primary" />
          </div>
          <div className="mt-4 flex justify-center text-center">
            <span className="text-sm text-primary">
              <span className="font-medium text-secondary">Click here</span> to
              upload the photo
            </span>
          </div>
        </div>
        <div className="mt-2 flex justify-end gap-4">
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

      {showUploadPhotoDialog && (
        <UploadPhotoDialog
          open={showUploadPhotoDialog}
          onClose={() => setShowUploadPhotoDialog(false)}
          onUpload={(newPhoto) => {
            setFormData({ ...formData, avatar: newPhoto })
            setShowUploadPhotoDialog(false)
            toast.success("Avatar updated successfully")
          }}
        />
      )}
    </>
  )
}

export default SettingChangePhoto
