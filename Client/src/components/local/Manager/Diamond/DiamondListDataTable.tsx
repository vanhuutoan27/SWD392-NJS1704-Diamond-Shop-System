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
import { Plus, Search } from "lucide-react";
import ListPagination from "@/components/global/molecules/ListPagination";
import { Button } from "@/components/global/atoms/button";
import { Link } from "react-router-dom";
import DiamondFilterButton from "./DiamondFilterButton";

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
  const itemsPerPage = 6;

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
      <div className="mb-4 flex items-center justify-between gap-4">
        <div className="flex w-full items-center gap-4">
          <div className="relative items-center">
            <Search
              className="absolute left-3 top-1/2 mb-1 -translate-y-1/2"
              size={16}
            />
            <Input
              placeholder="Filter Diamond by ID..."
              value={
                (table.getColumn("diamondId")?.getFilterValue() as string) ?? ""
              }
              onChange={(event) =>
                table.getColumn("diamondId")?.setFilterValue(event.target.value)
              }
              className="w-[300px] max-w-sm border border-secondary bg-white pl-10"
            />
          </div>
          <DiamondFilterButton setColumnFilters={setColumnFilters} />
        </div>
        <div className="flex gap-4">
          <Link to="/admin/diamond-new">
            <Button className="flex gap-2 bg-gray-800 pl-5 hover:bg-gray-900">
              <Plus size={20} /> Add Diamond
            </Button>
          </Link>
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
                    <TableCell key={cell.id} className="text-center">
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
      <ListPagination
        currentPage={currentPage}
        totalPages={totalPages}
        setCurrentPage={setCurrentPage}
      />
    </>
  );
}
