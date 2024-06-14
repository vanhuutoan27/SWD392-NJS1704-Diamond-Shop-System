"use client"

import { ColumnDef } from "@tanstack/react-table"
import { ChevronRight } from "lucide-react"
import { Link } from "react-router-dom"

import { IDiamond } from "@/types/diamond.interface"

// Helper function to format numbers conditionally
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

export const formatPrice = (amount: number) => {
  return new Intl.NumberFormat("vi-VN").format(amount)
}

export const columns: ColumnDef<IDiamond>[] = [
  {
    accessorKey: "shape",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Shape
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "weight",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Weight (cts)
        </div>
      )
    },
    cell: (info) => {
      const value: number = parseFloat(info.getValue() as string)
      return <div className="text-center">{formatNumber(value)}</div>
    }
  },
  {
    accessorKey: "colorLevel",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Color
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "clarity",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Clarity
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "certification",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Certification
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return (
        <div className="text-center font-semibold text-red-500">{value}</div>
      )
    }
  },
  {
    accessorKey: "size",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Size (mm)
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "fluorescence",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Fluorescence
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center uppercase">{value}</div>
    }
  },
  {
    accessorKey: "qualityOfCut",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Quality Of Cut
        </div>
      )
    },
    cell: (info) => {
      const value: string = info.getValue() as string
      return <div className="text-center">{value}</div>
    }
  },
  {
    accessorKey: "price",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Price (VND)
        </div>
      )
    },
    cell: (info) => {
      const value: number = info.getValue() as number
      return <div className="text-center">{formatPrice(value)}</div>
    }
  },
  {
    accessorKey: "details",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Details
        </div>
      )
    },
    cell: (info) => {
      const diamondId = info.row.original.diamondId

      return (
        <Link
          to={`/diamond/${diamondId}`}
          target="_blank"
          rel="noopener noreferrer"
          className="slow flex items-center font-semibold text-red-500 hover:translate-x-1"
        >
          Details <ChevronRight size={20} />
        </Link>
      )
    }
  }
]
