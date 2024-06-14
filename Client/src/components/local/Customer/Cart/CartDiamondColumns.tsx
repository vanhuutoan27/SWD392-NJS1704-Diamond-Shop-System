"use client"

import { ColumnDef } from "@tanstack/react-table"
import { Minus, Plus } from "lucide-react"

import { ICart } from "@/types/cart.interface"

import { formatCurrency } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

const formatNumber = (num: number) => {
  const decimalPart = num.toString().split(".")[1]
  if (decimalPart) {
    if (decimalPart.length === 1) {
      return num.toFixed(1)
    } else if (decimalPart.length === 2) {
      return num.toFixed(2)
    }
  }
  return num.toFixed(1)
}

export const cartDiamondColumns = (
  updateItemQuantity: (productId: string, newQuantity: number) => void,
  incrementQuantity: (productId: string) => void,
  decrementQuantity: (productId: string) => void
): ColumnDef<ICart>[] => [
  {
    accessorKey: "productId",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">ID</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      const shortProductId = value.split("-")[0]
      return <div className="text-center">{shortProductId}</div>
    }
  },
  {
    accessorKey: "shape",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Shape
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "weight",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-xs text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Weight (cts)
      </div>
    ),
    cell: (info) => {
      const value: number = parseFloat(info.getValue() as string)
      return <div className="text-center">{formatNumber(value)}</div>
    }
  },
  {
    accessorKey: "colorLevel",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Color
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "clarity",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Clarity
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "certification",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Certification
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return (
        <div className="text-center font-semibold text-red-500">{value}</div>
      )
    }
  },
  {
    accessorKey: "size",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-xs text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Size (mm)
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "fluorescence",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Fluorescence
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center uppercase">{value}</div>
    }
  },
  {
    accessorKey: "qualityOfCut",
    header: ({ column }) => (
      <div
        className="flex cursor-pointer justify-center text-xs text-white"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        Quality Of Cut
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "quantity",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">
        Quantity
      </div>
    ),
    cell: (info) => {
      const row = info.row.original
      const value: number = info.getValue() as number
      return (
        <div className="flex items-center justify-center gap-2">
          <Button
            type="button"
            variant={"secondary"}
            className="h-8 w-8 border-input p-0"
            onClick={() => decrementQuantity(row.productId)}
          >
            <Minus size={12} strokeWidth={3} />
          </Button>
          <input
            type="text"
            value={value}
            className="w-10 rounded-md border-[1.5px] bg-transparent py-2 text-center text-sm outline-none"
            onChange={(e) =>
              updateItemQuantity(row.productId, parseInt(e.target.value, 10))
            }
          />
          <Button
            type="button"
            variant={"secondary"}
            className="h-8 w-8 border-input p-0"
            onClick={() => incrementQuantity(row.productId)}
          >
            <Plus size={12} strokeWidth={3} />
          </Button>
        </div>
      )
    }
  },
  {
    accessorKey: "price",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">Price</div>
    ),
    cell: (info) => {
      const value: number = info.getValue() as number
      return (
        <div className="text-center font-semibold text-red-500">
          {formatCurrency(value)}
        </div>
      )
    }
  }
]
