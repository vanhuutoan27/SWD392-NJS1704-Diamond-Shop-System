"use client";

import { ColumnDef } from "@tanstack/react-table";
import { ICart, IJewelryCart } from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { Link } from "react-router-dom";
import { X } from "lucide-react";

export const cartJewelryColumns: ColumnDef<ICart>[] = [
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
    accessorKey: "image",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Image
        </div>
      );
    },
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
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Jewelry Name
        </div>
      );
    },
    cell: (info) => {
      const value = info.getValue() as string;
      const row = info.row.original as IJewelryCart;

      return (
        <div className="text-center font-semibold transition-all duration-300 hover:text-[#888]">
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
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Main Stone Size
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "sideStoneType",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Side Stone Type
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "sideStoneQuantity",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Side Stone Quantity
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "sideStoneWeight",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Side Stone Weight
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldType",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Gold Type
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldKarat",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Gold Karat
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "goldWeight",
    header: () => {
      return (
        <div className="flex cursor-pointer justify-center text-white">
          Gold Weight
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
