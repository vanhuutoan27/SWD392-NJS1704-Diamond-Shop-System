import { ColumnDef } from "@tanstack/react-table";
import {
  ICart,
  ICartType,
  IDiamondCart,
  IJewelryCart,
} from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { Link } from "react-router-dom";
import { X } from "lucide-react";

export const cartColumns: ColumnDef<ICart>[] = [
  {
    accessorKey: "productId",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">ID</div>
    ),
    cell: (info) => {
      const value: string = info.getValue() as string;
      return <div className="text-center">{value}</div>;
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
    accessorKey: "productName",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">
        Product Name
      </div>
    ),
    cell: (info) => {
      const row = info.row.original;

      const productName =
        row.productType === ICartType.Diamond
          ? `KIM CƯƠNG TỰ NHIÊN x ${(row as IDiamondCart).size}`
          : (row as IJewelryCart).jewelryName;

      return (
        <div className="text-center font-semibold transition-all duration-300 hover:text-[#888]">
          {row.productType === ICartType.Diamond ? (
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
      );
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
      const value: number = info.getValue() as number;
      return <div className="text-center">{value}</div>;
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
  {
    accessorKey: "action",
    header: () => (
      <div className="flex cursor-pointer justify-center text-white">
        Actions
      </div>
    ),
    cell: () => (
      <div className="flex justify-center">
        <X
          size={20}
          className="cursor-pointer text-red-800 transition-all duration-300 hover:text-red-800/80"
        />
      </div>
    ),
  },
];
