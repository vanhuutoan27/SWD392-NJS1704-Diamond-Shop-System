"use client";

import { formatDate, getUserStatus } from "@/lib/utils";
import { IUser, IUserStatus } from "@/types/user.interface";
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
import Chip from "@/components/global/atoms/Chip";
import { Link } from "react-router-dom";

export const columns: ColumnDef<IUser>[] = [
  {
    accessorKey: "userId",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">User ID</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <span className="font-semibold">{value}</span>;
    },
  },
  {
    accessorKey: "name",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Full Name</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      const userId = info.row.original.userId;
      return (
        <Link
          to={`/admin/${userId}`}
          className="slow cursor-pointer text-left font-semibold hover:text-secondary"
        >
          {value}
        </Link>
      );
    },
  },
  {
    accessorKey: "email",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Email</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <span>{value}</span>;
    },
  },
  {
    accessorKey: "createdOn",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Created On</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <span>{formatDate(value)}</span>;
    },
  },
  {
    accessorKey: "status",
    header: ({ column }) => {
      return (
        <div
          className="flex select-none items-center"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
        >
          <span className="flex cursor-pointer text-white">Status</span>
          <ArrowUpDown className="ml-2 cursor-pointer text-white" size={16} />
        </div>
      );
    },
    cell: (info) => {
      const value: IUserStatus = info.getValue() as IUserStatus;
      return <Chip content={getUserStatus(value)} color={"#16a34a"} />;
    },
  },
  {
    id: "actions",
    header: () => (
      <div className="flex cursor-pointer select-none pl-1 text-white">
        Actions
      </div>
    ),
    cell: ({ row }) => {
      const user = row.original;

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
              onClick={() => navigator.clipboard.writeText(user.userId)}
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
