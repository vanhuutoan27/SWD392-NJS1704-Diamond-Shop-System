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

import { IJewelry } from "@/types/jewelry.interface"

import { useChangeJewelryStatus } from "@/apis/jewelryApi"

import Chip from "@/components/global/atoms/Chip"
import { Button } from "@/components/global/atoms/button"
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"

import ViewJewelryDialog from "./ViewJewelryDialog"

export const columns: ColumnDef<IJewelry>[] = [
  {
    accessorKey: "skuID",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">ID</span>
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
    accessorKey: "jewelryCategory",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Category</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{info.getValue() as string}</span>
  },
  {
    accessorKey: "jewelryName",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Name</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span className="font-semibold">{info.getValue() as string}</span>
    )
  },
  {
    accessorKey: "mainStoneSize",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">
            Main Stone Size
          </span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{info.getValue() as string}</span>
  },
  {
    accessorKey: "sideStoneType",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">
            Side Stone Type
          </span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{info.getValue() as string}</span>
  },
  {
    accessorKey: "goldType",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Gold Type</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{info.getValue() as string}</span>
  },
  {
    accessorKey: "status",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Status</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => {
      const value: number = info.getValue() as number

      return (
        <span className="flex justify-center">
          <Chip
            content={value === 1 ? "Active" : "Inactive"}
            color={value === 1 ? "#16a34a" : "#f44336"}
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
      const jewelry = row.original
      const [isViewDialogOpen, setIsViewDialogOpen] = useState(false)

      const { mutate: changeJewelryStatus } = useChangeJewelryStatus()

      const handleStatusChange = () => {
        changeJewelryStatus(jewelry.jewelryId)
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
                onClick={() => navigator.clipboard.writeText(jewelry.jewelryId)}
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
                <span>{jewelry.status === 1 ? "Deactivate" : "Activate"}</span>
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
            <ViewJewelryDialog
              jewelryId={jewelry.jewelryId}
              onClose={() => setIsViewDialogOpen(false)}
            />
          )}
        </div>
      )
    }
  }
]
