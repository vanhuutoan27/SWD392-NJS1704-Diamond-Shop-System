"use client";

import { ColumnDef } from "@tanstack/react-table";
import { ICart, IJewelryCart } from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { Link } from "react-router-dom";
import { Minus, Plus } from "lucide-react";
import { Button } from "@/components/global/atoms/button";

export const cartJewelryColumns = (
  updateItemQuantity: (productId: string, newQuantity: number) => void,
  incrementQuantity: (productId: string) => void,
  decrementQuantity: (productId: string) => void,
): ColumnDef<ICart>[] => [
  {
    accessorKey: "productId",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">ID</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      const shortProductId = value.split("-")[0];
      return <div className="text-center">{shortProductId}</div>;
    },
  },
  {
    accessorKey: "image",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">Image</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return (
        <div className="flex cursor-pointer justify-center">
          <img src={value} alt="Product" className="h-14 w-14 object-cover" />
        </div>
      );
    },
  },
  {
    accessorKey: "jewelryName",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Jewelry Name
      </div>
    ),
    cell: (info) => {
      const value = info.getValue() as string;
      const row = info.row.original as IJewelryCart;

      return (
        <div className="slow text-center font-semibold hover:text-secondary">
          <Link
            to={`/jewelry/${row.productId}`}
            target="_blank"
            rel="noopener noreferrer"
          >
            {value}
          </Link>
        </div>
      );
    },
  },
  {
    accessorKey: "mainStoneSize",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Main Stone Size
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "sideStoneType",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Side Stone Type
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "sideStoneQuantity",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Side Stone Quantity
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "stoneWeight",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Side Stone Weight
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldType",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Gold Type
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldKarat",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Gold Karat
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldWeight",
    header: () => (
      <div className="flex cursor-pointer justify-center text-xs text-white">
        Gold Weight
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "quantity",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">
        Quantity
      </div>
    ),
    cell: (info) => {
      const row = info.row.original;
      const value: number = info.getValue() as number;
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
      );
    },
  },
  {
    accessorKey: "price",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">Price</div>
    ),
    cell: (info) => {
      const value: number = info.getValue() as number;
      return (
        <div className="text-center font-semibold text-red-500">
          {formatCurrency(value)}
        </div>
      );
    },
  },
];
