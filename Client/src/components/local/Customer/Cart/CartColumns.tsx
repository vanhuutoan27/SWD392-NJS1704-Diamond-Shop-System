import { ColumnDef } from "@tanstack/react-table"
import { Minus, Plus } from "lucide-react"
import { Link } from "react-router-dom"

import { ICart, IDiamondCart, IJewelryCart } from "@/types/cart.interface"

import { formatCurrency } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

export const cartColumns = (
  updateItemQuantity: (productId: string, newQuantity: number) => void,
  incrementQuantity: (productId: string) => void,
  decrementQuantity: (productId: string) => void
): ColumnDef<ICart>[] => [
  {
    accessorKey: "images",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">Image</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string
      return (
        <div className="flex cursor-pointer justify-center">
          <img
            src={value}
            alt="No Image"
            className="h-14 w-14 rounded-sm object-cover"
          />
        </div>
      )
    }
  },
  {
    accessorKey: "productName",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">
        Product Name
      </div>
    ),
    cell: (info) => {
      const row = info.row.original

      const productName =
        row.productType === "Diamond"
          ? `Natural Diamond ${(row as IDiamondCart).size}mm`
          : (row as IJewelryCart).jewelryName

      return (
        <div className="slow text-center font-semibold uppercase hover:text-secondary">
          {row.productType === "Diamond" ? (
            <Link
              to={`/diamond/${row.productId}`}
              target="_blank"
              rel="noopener noreferrer"
            >
              {productName}
            </Link>
          ) : (
            <Link
              to={`/jewelry/${row.productId}`}
              target="_blank"
              rel="noopener noreferrer"
            >
              {productName}
            </Link>
          )}
        </div>
      )
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
