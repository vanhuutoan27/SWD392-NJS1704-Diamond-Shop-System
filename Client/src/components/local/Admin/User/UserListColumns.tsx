"use client"

import { useState } from "react"

import { ColumnDef } from "@tanstack/react-table"
import {
  ArrowUpDown,
  Copy,
  Eye,
  MoreHorizontal,
  PencilLine
} from "lucide-react"
import { Link } from "react-router-dom"

import { IUser } from "@/types/user.interface"

import { useChangeUserStatus } from "@/apis/userApi"

import { formatDate } from "@/lib/utils"

import Chip from "@/components/global/atoms/Chip"
import { Button } from "@/components/global/atoms/button"
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"

import ViewUserDialog from "./ViewUserDialog"

export const columns: ColumnDef<IUser>[] = [
  {
    accessorKey: "id",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">User ID</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      const shortId = value.split("-")[0]
      return <span className="font-semibold">{shortId}</span>
    }
  },
  {
    accessorKey: "fullName",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Full Name</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      const userId = info.row.original.id
      return (
        <Link
          to={`/profile/${userId}`}
          className="slow cursor-pointer text-left font-semibold hover:text-secondary"
        >
          {value}
        </Link>
      )
    }
  },
  {
    accessorKey: "email",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Email</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{info.getValue() as string}</span>
  },
  {
    accessorKey: "dateCreated",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center justify-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Created On</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <span className="flex justify-center">{formatDate(value)}</span>
    }
  },
  {
    accessorKey: "isActive",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center justify-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Status</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => {
      const value: boolean = info.getValue() as boolean
      // console.log(value);

      return (
        <span className="flex justify-center">
          <Chip
            content={value === true ? "Active" : "Inactive"}
            color={value === true ? "#16a34a" : "#f44336"}
          />
        </span>
      )
    }
  },
  {
    id: "actions",
    header: () => (
      <div className="flex cursor-pointer select-none pl-1 text-white">
        Actions
      </div>
    ),
    cell: ({ row }) => {
      const user = row.original
      const [isViewDialogOpen, setIsViewDialogOpen] = useState(false)

      const { mutate: changeUserStatus } = useChangeUserStatus()

      const handleStatusChange = () => {
        changeUserStatus(user.id)
      }

      const handleViewDetailsClick = () => {
        setIsViewDialogOpen(true)
      }

      return (
        <div>
          <DropdownMenu>
            <DropdownMenuTrigger asChild>
              <Button variant="ghost" className="ml-4 h-8 w-8 p-0">
                <span className="sr-only">Open menu</span>
                <MoreHorizontal size={20} />
              </Button>
            </DropdownMenuTrigger>
            <DropdownMenuContent align="end" className="p-2">
              <DropdownMenuLabel>Actions</DropdownMenuLabel>
              <DropdownMenuItem
                onClick={() => {
                  navigator.clipboard.writeText(user.id)
                }}
                className="text-sm"
              >
                <Copy size={16} className="mr-2" />
                <span>Copy ID</span>
              </DropdownMenuItem>
              <DropdownMenuItem
                onClick={handleStatusChange}
                className="text-sm"
              >
                <PencilLine size={16} className="mr-2" />
                <span>{user.isActive ? "Deactivate" : "Activate"}</span>
              </DropdownMenuItem>
              <DropdownMenuItem
                onClick={handleViewDetailsClick}
                className="text-sm"
              >
                <Eye size={16} className="mr-2" />
                <span>View Details</span>
              </DropdownMenuItem>
            </DropdownMenuContent>
          </DropdownMenu>

          {isViewDialogOpen && (
            <ViewUserDialog
              userId={user.id}
              onClose={() => setIsViewDialogOpen(false)}
            />
          )}
        </div>
      )
    }
  }
]
