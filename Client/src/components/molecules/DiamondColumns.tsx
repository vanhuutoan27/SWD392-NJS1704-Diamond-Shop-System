"use client";

import { ColumnDef } from "@tanstack/react-table";
import { IDiamond } from "@/types/diamond.interface";
import { Link } from "react-router-dom";
import { ChevronRight } from "lucide-react";

export const columns: ColumnDef<IDiamond>[] = [
  {
    accessorKey: "shape",
    header: () => (
      <div className="text-center font-medium text-primary">Shape</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "weight",
    header: () => (
      <div className="text-center font-medium text-primary">Weight (cts)</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "color",
    header: () => (
      <div className="text-center font-medium text-primary">Color</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "clarify",
    header: () => (
      <div className="text-center font-medium text-primary">Clarify</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "certification",
    header: () => (
      <div className="text-center font-medium text-primary">Certification</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return (
        <div className="text-center font-semibold text-red-500">{value}</div>
      );
    },
  },
  {
    accessorKey: "size",
    header: () => (
      <div className="text-center font-medium text-primary">Size (mm)</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "fluorescence",
    header: () => (
      <div className="text-center font-medium text-primary">Fluorescence</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "qualityOfCut",
    header: () => (
      <div className="text-center font-medium text-primary">Quality Of Cut</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "price",
    header: () => (
      <div className="text-center font-medium text-primary">Price (VND)</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
    },
  },
  {
    accessorKey: "details",
    header: () => (
      <div className="text-center font-medium text-primary">Details</div>
    ),

    cell: () => (
      <Link
        to=""
        target="_blank"
        rel="noopener noreferrer"
        className="flex items-center font-semibold text-red-500 transition-all duration-300 hover:translate-x-1"
      >
        Details <ChevronRight size={20} />
      </Link>
    ),
  },
];
