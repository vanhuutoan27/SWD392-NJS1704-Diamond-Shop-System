"use client"

import { useState } from "react"

import { ColumnDef } from "@tanstack/react-table"
import { ArrowUpDown, Copy, Eye, MoreHorizontal } from "lucide-react"

import { IInvoice } from "@/types/invoice.interface"

import { formatCurrencyWithoutVND, formatDate } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"

// import ViewInvoiceDialog from "./ViewInvoiceDialog"

export const columns: ColumnDef<IInvoice>[] = [
  {
    accessorKey: "invoiceId",
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
    accessorKey: "order.customerName",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Customer Name</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span className="font-semibold">{info.getValue() as string}</span>
    )
  },
  {
    accessorKey: "createDate",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Create date</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span className="font-semibold">
        {formatDate(info.getValue() as string)}
      </span>
    )
  },
  {
    accessorKey: "order.total",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Total</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span className="font-semibold">
        {formatCurrencyWithoutVND(info.getValue() as number)}
      </span>
    )
  },

  {
    id: "actions",
    header: () => (
      <div className="flex cursor-pointer select-none pl-1 text-white">
        Actions
      </div>
    ),
    cell: ({ row }) => {
      const invoice = row.original
      // const [isViewDialogOpen, setIsViewDialogOpen] = useState(false)

      // const handleViewDetailsClick = () => {
      //   setIsViewDialogOpen(true)
      // }
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
                onClick={() => navigator.clipboard.writeText(invoice.invoiceId)}
                className="text-sm"
              >
                <Copy size={16} className="mr-2" />
                <span>Copy ID</span>
              </DropdownMenuItem>
              <DropdownMenuItem
                // onClick={handleViewDetailsClick}
                className="text-sm"
              >
                <Eye size={16} className="mr-2" />
                <span>View Details</span>
              </DropdownMenuItem>
            </DropdownMenuContent>
          </DropdownMenu>
          {/* {isViewDialogOpen && (
            <ViewInvoiceDialog
              invoiceId={invoice.invoiceId}
              onClose={() => setIsViewDialogOpen(false)}
            />
          )} */}
        </div>
      )
    }
  }
]
