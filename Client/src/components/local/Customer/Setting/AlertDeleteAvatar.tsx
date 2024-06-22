import {
  AlertDialog,
  AlertDialogAction,
  AlertDialogCancel,
  AlertDialogContent,
  AlertDialogDescription,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogTitle,
  AlertDialogTrigger
} from "@/components/global/atoms/alert-dialog"
import { Button } from "@/components/global/atoms/button"

interface AlertDeleteAvatarProps {
  title: string
  description: string
  action: string
  onConfirm: () => void
}

function AlertDeleteAvatar({
  title,
  description,
  action,
  onConfirm
}: AlertDeleteAvatarProps) {
  return (
    <AlertDialog>
      <AlertDialogTrigger asChild>
        <span className="slow flex w-fit cursor-pointer text-sm text-red-600 hover:underline">
          Delete
        </span>
      </AlertDialogTrigger>
      <AlertDialogContent>
        <AlertDialogHeader>
          <AlertDialogTitle className="text-xl">{title}</AlertDialogTitle>
          <AlertDialogDescription className="text-secondary">
            {description}
          </AlertDialogDescription>
        </AlertDialogHeader>
        <AlertDialogFooter className="mt-2">
          <AlertDialogCancel>Cancel</AlertDialogCancel>
          <AlertDialogAction asChild>
            <Button type="button" onClick={onConfirm} variant="destructive">
              {action}
            </Button>
          </AlertDialogAction>
        </AlertDialogFooter>
      </AlertDialogContent>
    </AlertDialog>
  )
}

export default AlertDeleteAvatar
