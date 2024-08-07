"use client"

// import { useState } from "react"
import { useState } from "react"

import { ColumnDef } from "@tanstack/react-table"
import { ArrowUpDown, Ban, Copy, Eye, MoreHorizontal } from "lucide-react"

import { IOrder, OrderStatus } from "@/types/order.interface"

import { useUpdateOrderStatus } from "@/apis/orderApi"

import { formatCurrency, formatDate, getPaymentMethodString } from "@/lib/utils"

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
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"

import OrderStatusChip from "../../Manager/Order/OrderStatusChip"
import ViewOrderDialog from "../../Manager/Order/ViewOrderDialog"

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
      const shortProductId = value.split("-")[0]
      return <span>{shortProductId}</span>
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
      return <span>{value}</span>
    }
  },

  {
    accessorKey: "paymentMethod",
    header: () => {
      return (
        <div className="flex select-none items-center">
          <span className="flex cursor-pointer text-white">Payment Method</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return <span>{getPaymentMethodString(value)}</span>
    }
  },
  {
    accessorKey: "total",
    header: () => {
      return (
        <div className="flex select-none items-center">
          <span className="flex cursor-pointer text-white">Total</span>
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return <span>{formatCurrency(value)}</span>
    }
  },
  {
    accessorKey: "dateCreated",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Date Created</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      )
    },
    cell: (info) => <span>{formatDate(info.getValue() as string)}</span>
  },
  {
    accessorKey: "receiptDay",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
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
          className="flex select-none items-center"
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
      const [isAlertDialogOpen, setIsAlertDialogOpen] = useState(false)
      const updateOrderStatusMutation = useUpdateOrderStatus()

      const handleViewDetailsClick = () => {
        setIsViewDialogOpen(true)
      }

      const handleCancelOrderClick = () => {
        setIsAlertDialogOpen(true)
      }

      const handleConfirmCancelOrder = () => {
        updateOrderStatusMutation.mutate(
          { orderId: order.orderId, orderStatus: 4 },
          {
            onSuccess: () => {
              window.location.reload()
            }
          }
        )
        setIsAlertDialogOpen(false)
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
              <DropdownMenuItem
                onClick={handleViewDetailsClick}
                className="text-sm"
              >
                <Eye size={16} className="mr-2" />
                <span>View Details</span>
              </DropdownMenuItem>
              <DropdownMenuItem
                onClick={handleCancelOrderClick}
                className="text-sm"
                disabled={order.orderStatus === 4}
              >
                <Ban size={16} className="mr-2" />
                <span>Cancel Order</span>
              </DropdownMenuItem>
            </DropdownMenuContent>
          </DropdownMenu>

          {isViewDialogOpen && (
            <ViewOrderDialog
              orderId={order.orderId}
              isAllowEdit={false}
              onClose={() => setIsViewDialogOpen(false)}
            />
          )}

          {isAlertDialogOpen && (
            <AlertDialog
              open={isAlertDialogOpen}
              onOpenChange={setIsAlertDialogOpen}
            >
              <AlertDialogTrigger asChild />
              <AlertDialogContent>
                <AlertDialogHeader>
                  <AlertDialogTitle className="text-xl">
                    Cancel Order
                  </AlertDialogTitle>
                  <AlertDialogDescription className="text-secondary">
                    Are you sure you want to cancel this order?
                  </AlertDialogDescription>
                </AlertDialogHeader>
                <AlertDialogFooter className="mt-2">
                  <AlertDialogCancel
                    onClick={() => setIsAlertDialogOpen(false)}
                  >
                    Cancel
                  </AlertDialogCancel>
                  <AlertDialogAction asChild>
                    <Button
                      type="button"
                      onClick={handleConfirmCancelOrder}
                      variant="destructive"
                    >
                      Confirm
                    </Button>
                  </AlertDialogAction>
                </AlertDialogFooter>
              </AlertDialogContent>
            </AlertDialog>
          )}
        </div>
      )
    }
  }
]
