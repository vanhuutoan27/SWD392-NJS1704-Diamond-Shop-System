"use client"

import { ColumnDef } from "@tanstack/react-table"

import { IUserRoleConfigItem } from "@/types/user.interface"

import UserPermissionSelect from "@/components/local/Admin/User/UserPermissionSelect"

export const columns = (
  isEditing: boolean
): ColumnDef<IUserRoleConfigItem>[] => [
  {
    accessorKey: "permissionName",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Role</span>
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <span className="font-semibold">{value}</span>
    }
  },
  {
    accessorKey: "diamond",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Diamond</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span>
          <UserPermissionSelect value={value} isEditing={isEditing} />
        </span>
      )
    }
  },
  {
    accessorKey: "jewelry",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Jewelry</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span>
          <UserPermissionSelect value={value} isEditing={isEditing} />
        </span>
      )
    }
  },
  {
    accessorKey: "user",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">User</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span>
          <UserPermissionSelect value={value} isEditing={isEditing} />
        </span>
      )
    }
  },
  {
    accessorKey: "order",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Order</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span>
          <UserPermissionSelect value={value} isEditing={isEditing} />
        </span>
      )
    }
  },
  {
    accessorKey: "invoice",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Invoice</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span>
          <UserPermissionSelect value={value} isEditing={isEditing} />
        </span>
      )
    }
  }
]
