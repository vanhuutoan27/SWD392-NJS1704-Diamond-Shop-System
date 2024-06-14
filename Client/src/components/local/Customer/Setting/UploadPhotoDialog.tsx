import { useState } from "react"

import { getDownloadURL, ref, uploadBytesResumable } from "firebase/storage"

import { diamoonDB } from "@/lib/firebase"

import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"
import { Input } from "@/components/global/atoms/input"

interface UploadPhotoDialogProps {
  open: boolean
  onClose: () => void
  onUpload: (newPhoto: string) => void
}

function UploadPhotoDialog({
  open,
  onClose,
  onUpload
}: UploadPhotoDialogProps) {
  const [newPhoto, setNewPhoto] = useState<File | null>(null)
  const [uploadProgress, setUploadProgress] = useState(0)

  const handleSave = () => {
    if (newPhoto) {
      const storageRef = ref(diamoonDB, `Test/${newPhoto.name}`)
      const uploadTask = uploadBytesResumable(storageRef, newPhoto)

      uploadTask.on(
        "state_changed",
        (snapshot) => {
          const progress =
            (snapshot.bytesTransferred / snapshot.totalBytes) * 100
          setUploadProgress(progress)
        },
        (error) => {
          console.error("Upload failed:", error)
        },
        async () => {
          const downloadURL = await getDownloadURL(uploadTask.snapshot.ref)
          onUpload(downloadURL)
        }
      )
    }
  }

  return (
    <Dialog open={open} onOpenChange={onClose}>
      <DialogContent className="sm:max-w-[425px]">
        <DialogHeader>
          <DialogTitle className="text-xl">Upload Photo</DialogTitle>
          <DialogDescription className="text-secondary">
            Select a new photo to upload. Click save when you're done.
          </DialogDescription>
        </DialogHeader>
        <Input
          type="file"
          accept="image/*"
          className="w-full"
          onChange={(e) => {
            if (e.target.files && e.target.files[0]) {
              const reader = new FileReader()
              reader.onload = () => {
                setNewPhoto(e.target.files![0])
              }
              reader.readAsDataURL(e.target.files[0])
            }
          }}
        />
        {uploadProgress > 0 && (
          <div className="h-2.5 w-full rounded-full bg-gray-200">
            <div
              className="h-2.5 rounded-full bg-primary"
              style={{ width: `${uploadProgress}%` }}
            ></div>
          </div>
        )}
        <DialogFooter className="mt-2">
          <Button variant="secondary" onClick={onClose}>
            Cancel
          </Button>
          <Button type="button" onClick={handleSave}>
            Upload
          </Button>
        </DialogFooter>
      </DialogContent>
    </Dialog>
  )
}

export default UploadPhotoDialog
