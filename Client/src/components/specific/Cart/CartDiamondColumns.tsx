"use client";

import { ColumnDef } from "@tanstack/react-table";
import { ICart } from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { X } from "lucide-react";

// Helper function to format numbers conditionally
const formatNumber = (num: number) => {
  const decimalPart = num.toString().split(".")[1];
  if (decimalPart) {
    if (decimalPart.length === 1) {
      return num.toFixed(1);
    } else if (decimalPart.length === 2) {
      return num.toFixed(2);
    }
  }
  return num.toFixed(1);
};

export const cartDiamondColumns: ColumnDef<ICart>[] = [
  {
    accessorKey: "productId",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">ID</div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
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
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
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
      );
    },
    cell: (info) => {
      const value: number = parseFloat(info.getValue() as string);
      return <div className="text-center">{formatNumber(value)}</div>;
    },
  },
  {
    accessorKey: "color",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Color
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "clarify",
    header: ({ column }) => {
      return (
        <div
          className="flex cursor-pointer justify-center text-white"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          Clarify
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
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
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return (
        <div className="text-center font-semibold text-red-500">{value}</div>
      );
    },
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
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
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
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
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
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "quantity",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Quantity
        </div>
      );
    },
    cell: (info) => {
      const value: number = info.getValue() as number;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "price",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Price
        </div>
      );
    },
    cell: (info) => {
      const value: number = info.getValue() as number;
      return (
        <div className="text-center font-semibold text-red-500">
          {formatCurrency(value)}
        </div>
      );
    },
  },
  {
    accessorKey: "action",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Actions
        </div>
      );
    },
    cell: () => {
      return (
        <div className="flex justify-center">
          <X
            size={20}
            className="cursor-pointer text-red-800 transition-all duration-300 hover:text-red-800/80"
          />
        </div>
      );
    },
  },
];
