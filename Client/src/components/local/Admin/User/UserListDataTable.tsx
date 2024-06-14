"use client"

import * as React from "react"

import {
  ColumnDef,
  ColumnFiltersState,
  SortingState,
  flexRender,
  getCoreRowModel,
  getFilteredRowModel,
  getSortedRowModel,
  useReactTable
} from "@tanstack/react-table"
import { Search } from "lucide-react"

import { Input } from "@/components/global/atoms/input"
import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow
} from "@/components/global/atoms/table"
import ListPagination from "@/components/global/molecules/DataTablePagination"

import AddUserDialog from "./AddUserDialog"

interface DataTableProps<TData, TValue> {
  columns: ColumnDef<TData, TValue>[]
  data: TData[]
}

export function DataTable<TData, TValue>({
  columns,
  data
}: DataTableProps<TData, TValue>) {
  const [sorting, setSorting] = React.useState<SortingState>([])
  const [columnFilters, setColumnFilters] = React.useState<ColumnFiltersState>(
    []
  )
  const [currentPage, setCurrentPage] = React.useState(1)
  const itemsPerPage = 7

  const table = useReactTable({
    data,
    columns,
    onSortingChange: setSorting,
    getCoreRowModel: getCoreRowModel(),
    getSortedRowModel: getSortedRowModel(),
    onColumnFiltersChange: setColumnFilters,
    getFilteredRowModel: getFilteredRowModel(),
    state: {
      sorting,
      columnFilters
    }
  })

  const filteredData = table
    .getFilteredRowModel()
    .rows.map((row) => row.original)

  const paginatedData = React.useMemo(() => {
    const startIndex = (currentPage - 1) * itemsPerPage
    const endIndex = startIndex + itemsPerPage
    return filteredData.slice(startIndex, endIndex)
  }, [filteredData, currentPage])

  const totalPages = Math.ceil(filteredData.length / itemsPerPage)

  React.useEffect(() => {
    if (currentPage > totalPages) {
      setCurrentPage(1)
    }
  }, [filteredData, currentPage, totalPages])

  return (
    <>
      <div className="mb-4 flex items-center justify-between">
        <div className="relative flex w-full items-center py-4">
          <Search className="absolute left-3 mb-1" size={16} />
          <Input
            placeholder="Search User by Email..."
            value={(table.getColumn("email")?.getFilterValue() as string) ?? ""}
            onChange={(event) =>
              table.getColumn("email")?.setFilterValue(event.target.value)
            }
            className="max-w-sm border border-secondary bg-white pl-10"
          />
        </div>

        <div className="flex gap-4">
          <AddUserDialog />
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
                            header.getContext()
                          )}
                    </TableHead>
                  )
                })}
              </TableRow>
            ))}
          </TableHeader>
          <TableBody>
            {paginatedData.length ? (
              paginatedData.map((row, rowIndex) => (
                <TableRow key={rowIndex}>
                  {table
                    .getRowModel()
                    .rows[rowIndex]?.getVisibleCells()
                    .map((cell) => (
                      <TableCell key={cell.id}>
                        {flexRender(cell.column.columnDef.cell, {
                          ...cell.getContext(),
                          row: {
                            ...cell.getContext().row,
                            original: row
                          }
                        })}
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
  )
}
