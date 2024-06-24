import React from "react"

import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"

import { UserPermissionLabels } from "./UserPermissionLabels"

interface UserPermissionSelectProps {
  value: number
  isEditing: boolean
}

const UserPermissionSelect: React.FC<UserPermissionSelectProps> = ({
  value,
  isEditing
}) => {
  if (!isEditing) {
    return <span className="font-medium">{UserPermissionLabels[value]}</span>
  }

  return (
    <Select value={value.toString()}>
      <SelectTrigger className="w-[180px] font-medium">
        <SelectValue placeholder="Permission" />
      </SelectTrigger>
      <SelectContent>
        <SelectGroup>
          {Object.entries(UserPermissionLabels).map(([key, label]) => (
            <SelectItem key={key} value={key} className="font-medium">
              {label}
            </SelectItem>
          ))}
        </SelectGroup>
      </SelectContent>
    </Select>
  )
}

export default UserPermissionSelect
