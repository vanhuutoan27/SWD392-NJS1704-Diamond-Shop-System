"use client";

import { ColumnDef } from "@tanstack/react-table";
import { ArrowUpDown, Copy, Eye, MoreHorizontal } from "lucide-react";
import { Button } from "@/components/global/atoms/button";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuLabel,
  DropdownMenuTrigger,
} from "@/components/global/atoms/dropdown-menu";
import { IDiamond } from "@/types/diamond.interface";
import ViewDiamondDialog from "./ViewDiamondDialog";
import { useState } from "react";

export const columns: ColumnDef<IDiamond>[] = [
  {
    accessorKey: "diamondId",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">ID</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      const shortId = value.split("-")[0];
      return <span className="font-semibold">{shortId}</span>;
    },
  },
  {
    accessorKey: "shape",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Shape</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "weight",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Weight</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "colorLevel",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Color</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "clarity",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Clarity</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "certification",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Certification</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "size",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Size</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "fluorescence",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Fluorescence</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "qualityOfCut",
    header: ({ column }) => (
      <div
        className="flex select-none items-center justify-center"
        onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
      >
        <span className="flex cursor-pointer text-white">Quality Of Cut</span>
        <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
      </div>
    ),
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    id: "actions",
    header: () => (
      <div className="flex cursor-pointer select-none pl-1 text-white">
        Actions
      </div>
    ),
    cell: ({ row }) => {
      const diamond = row.original;
      const [isDialogOpen, setIsDialogOpen] = useState(false);

      const handleViewDetailsClick = () => {
        setIsDialogOpen(true);
      };

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
                onClick={() => navigator.clipboard.writeText(diamond.diamondId)}
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
            </DropdownMenuContent>
          </DropdownMenu>
          {isDialogOpen && (
            <ViewDiamondDialog
              diamondId={diamond.diamondId}
              onClose={() => setIsDialogOpen(false)}
            />
          )}
        </div>
      );
    },
  },
];
