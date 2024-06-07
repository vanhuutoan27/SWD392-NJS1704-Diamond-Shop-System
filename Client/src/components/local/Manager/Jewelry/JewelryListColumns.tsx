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
import { IJewelry } from "@/types/jewelry.interface";

export const columns: ColumnDef<IJewelry>[] = [
  {
    accessorKey: "jewelryId",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">ID</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      const shortId = value.split("-")[0];
      return <span className="font-semibold">{shortId}</span>;
    },
  },
  {
    accessorKey: "jewelryCategory",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Category</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "jewelryName",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Name</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => (
      <span className="font-semibold">{info.getValue() as string}</span>
    ),
  },
  {
    accessorKey: "mainStoneSize",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">
            Main Stone Size
          </span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "sideStoneType",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">
            Side Stone Type
          </span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => <span>{info.getValue() as string}</span>,
  },
  {
    accessorKey: "goldType",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Gold Type</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
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
      const jewelry = row.original;

      return (
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
              onClick={() => navigator.clipboard.writeText(jewelry.jewelryId)}
              className="text-sm"
            >
              <Copy size={16} className="mr-2" />
              <span>Copy ID</span>
            </DropdownMenuItem>
            <DropdownMenuItem className="text-sm">
              <Eye size={16} className="mr-2" />
              <span>View Details</span>
            </DropdownMenuItem>
          </DropdownMenuContent>
        </DropdownMenu>
      );
    },
  },
];
