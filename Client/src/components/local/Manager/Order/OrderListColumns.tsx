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

import { IOrder, OrderStatus } from "@/types/order.interface"

import { formatCurrency, formatDate, getPaymentMethodString } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"

import OrderStatusChip from "./OrderStatusChip"
import ViewOrderDialog from "./ViewOrderDialog"

export const columns: ColumnDef<IOrder>[] = [
  {
    accessorKey: "orderId",
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
    accessorKey: "customerName",
    header: () => {
      return (
        <div className="flex select-none items-center">
          <span className="flex cursor-pointer text-white">Customer</span>
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <span className="font-semibold">{value}</span>
    }
  },
  {
    accessorKey: "paymentMethod",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center justify-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Payment Method</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span className="flex justify-center">
          {getPaymentMethodString(value)}
        </span>
      )
    }
  },
  {
    accessorKey: "total",
    header: () => {
      return (
        <div className="flex select-none items-center justify-center">
          <span className="flex cursor-pointer text-white">Total</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <span className="flex justify-center">{formatCurrency(value)}</span>
      )
    }
  },
  {
    accessorKey: "dateCreated",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center justify-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Date Created</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span className="flex justify-center">
        {formatDate(info.getValue() as string)}
      </span>
    )
  },
  {
    accessorKey: "receiptDay",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center justify-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Date Receipt</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => (
      <span>
        {info.getValue() === null
          ? "NaN"
          : formatDate(info.getValue() as string)}
      </span>
    )
  },
  {
    accessorKey: "orderStatus",
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
      const value: number = info.getValue() as number
      return (
        <span className="flex justify-center">
          <OrderStatusChip content={value as OrderStatus} />
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
      const order = row.original
      const [isViewDialogOpen, setIsViewDialogOpen] = useState(false)

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
                onClick={() => navigator.clipboard.writeText(order.orderId)}
                className="text-sm"
              >
                <Copy size={16} className="mr-2" />
                <span>Copy ID</span>
              </DropdownMenuItem>
              <DropdownMenuItem className="text-sm">
                <PencilLine size={16} className="mr-2" />
                <span>Change Status</span>
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
            <ViewOrderDialog
              orderId={order.orderId}
              isAllowEdit={true}
              onClose={() => setIsViewDialogOpen(false)}
            />
          )}
        </div>
      )
    }
  }
]
