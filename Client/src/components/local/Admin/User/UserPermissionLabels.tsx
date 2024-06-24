import { CirclePlus, Eye, EyeOff, Pencil, Star } from "lucide-react"

import { IUserPermission } from "@/types/user.interface"

export const UserPermissionLabels: { [key: number]: JSX.Element } = {
  [IUserPermission.AccessDenied]: (
    <div className="flex items-center gap-2">
      <EyeOff size={20} /> Access Denied
    </div>
  ),
  [IUserPermission.View]: (
    <div className="flex items-center gap-2">
      <Eye size={20} /> View
    </div>
  ),
  [IUserPermission.Modify]: (
    <div className="flex items-center gap-2">
      <Pencil size={20} /> Modify
    </div>
  ),
  [IUserPermission.Create]: (
    <div className="flex items-center gap-2">
      <CirclePlus size={20} /> Create
    </div>
  ),
  [IUserPermission.FullAccess]: (
    <div className="flex items-center gap-2">
      <Star size={20} /> Full Access
    </div>
  )
}
