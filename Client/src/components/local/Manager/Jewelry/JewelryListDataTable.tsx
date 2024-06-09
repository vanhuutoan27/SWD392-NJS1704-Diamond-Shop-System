"use client";

import * as React from "react";
import {
  ColumnDef,
  ColumnFiltersState,
  SortingState,
  flexRender,
  getCoreRowModel,
  getFilteredRowModel,
  getPaginationRowModel,
  getSortedRowModel,
  useReactTable,
} from "@tanstack/react-table";

import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/global/atoms/table";
import { Input } from "@/components/global/atoms/input";
import { Search } from "lucide-react";
import { Button } from "@/components/global/atoms/button";
import DataTablePagination from "@/components/global/molecules/DataTablePagination";
import AddJewelryDialog from "./AddJewelryDialog";

interface DataTableProps<TData, TValue> {
  columns: ColumnDef<TData, TValue>[];
  data: TData[];
}

export function DataTable<TData, TValue>({
  columns,
  data,
}: DataTableProps<TData, TValue>) {
  const [sorting, setSorting] = React.useState<SortingState>([]);
  const [columnFilters, setColumnFilters] = React.useState<ColumnFiltersState>(
    [],
  );
  const [currentPage, setCurrentPage] = React.useState(1);
  const itemsPerPage = 7;

  const paginatedData = React.useMemo(() => {
    const startIndex = (currentPage - 1) * itemsPerPage;
    const endIndex = startIndex + itemsPerPage;
    return data.slice(startIndex, endIndex);
  }, [data, currentPage]);

  const table = useReactTable({
    data: paginatedData,
    columns,
    onSortingChange: setSorting,
    getCoreRowModel: getCoreRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    getSortedRowModel: getSortedRowModel(),
    onColumnFiltersChange: setColumnFilters,
    getFilteredRowModel: getFilteredRowModel(),
    state: {
      sorting,
      columnFilters,
    },
  });

  const totalPages = Math.ceil(data.length / itemsPerPage);

  return (
    <>
      <div className="mb-8 flex items-center justify-between gap-4">
        <div className="flex w-full items-center gap-4">
          <div className="relative flex w-full items-center">
            <Search
              className="absolute left-3 top-1/2 mb-1 -translate-y-1/2"
              size={16}
            />
            <Input
              placeholder="Search Jewelry by ID..."
              value={
                (table.getColumn("jewelryId")?.getFilterValue() as string) ?? ""
              }
              onChange={(event) =>
                table.getColumn("jewelryId")?.setFilterValue(event.target.value)
              }
              className="w-[400px] max-w-sm border border-secondary bg-white pl-10"
            />
          </div>
        </div>

        <div className="flex gap-4">
          {/* <Button className="flex gap-2" variant={"destructive"}>
            <Import size={20} /> Import
          </Button> */}
          <Button className="flex gap-2 bg-gray-800 pl-5 hover:bg-gray-900">
            <AddJewelryDialog />
          </Button>
        </div>
      </div>

      <div className="overflow-hidden rounded-md border bg-white shadow-md">
        <Table>
          <TableHeader className="bg-gray-800 hover:bg-gray-900">
            {table.getHeaderGroups().map((headerGroup) => (
              <TableRow key={headerGroup.id}>
                {headerGroup.headers.map((header) => {
                  return (
                    <TableHead key={header.id}>
                      {header.isPlaceholder
                        ? null
                        : flexRender(
                            header.column.columnDef.header,
                            header.getContext(),
                          )}
                    </TableHead>
                  );
                })}
              </TableRow>
            ))}
          </TableHeader>
          <TableBody>
            {table.getRowModel().rows?.length ? (
              table.getRowModel().rows.map((row) => (
                <TableRow
                  key={row.id}
                  data-state={row.getIsSelected() && "selected"}
                >
                  {row.getVisibleCells().map((cell) => (
                    <TableCell key={cell.id}>
                      {flexRender(
                        cell.column.columnDef.cell,
                        cell.getContext(),
                      )}
                    </TableCell>
                  ))}
                </TableRow>
              ))
            ) : (
              <TableRow>
                <TableCell
                  colSpan={columns.length}
                  className="h-24 text-center"
                >
                  No results.
                </TableCell>
              </TableRow>
            )}
          </TableBody>
        </Table>
      </div>

      <DataTablePagination
        currentPage={currentPage}
        totalPages={totalPages}
        setCurrentPage={setCurrentPage}
      />
    </>
  );
}
