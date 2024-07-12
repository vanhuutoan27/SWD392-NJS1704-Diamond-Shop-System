"use client"

import { ColumnDef } from "@tanstack/react-table"

import { IOrder, OrderStatus } from "@/types/order.interface"

import { formatCurrency, getPaymentMethodString } from "@/lib/utils"

import OrderStatusChip from "../../Admin/Order/OrderStatusChip"

export const columns: ColumnDef<IOrder>[] = [
  {
    accessorKey: "_id",
    header: () => {
      return (
        <div className="flex select-none items-center">
          <span className="flex cursor-pointer text-white">ID</span>
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <span>{value}</span>
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
          <span className="flex cursor-pointer text-white">Payment</span>
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
    accessorKey: "orderStatus",
    header: () => {
      return (
        <div className="flex select-none items-center">
          <span className="flex cursor-pointer text-white">Status</span>
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
  }
]
