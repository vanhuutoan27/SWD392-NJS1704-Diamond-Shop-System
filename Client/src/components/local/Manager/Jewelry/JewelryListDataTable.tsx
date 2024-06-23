"use client"

import * as React from "react"

import {
  ColumnDef,
  ColumnFiltersState,
  SortingState,
  flexRender,
  getCoreRowModel,
  getFilteredRowModel,
  getPaginationRowModel,
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
import DataTablePagination from "@/components/global/molecules/DataTablePagination"

import AddJewelryDialog from "./AddJewelryDialog"

interface JewelryData {
  jewelryId: string
  [key: string]: any
}

interface DataTableProps<TData> {
  columns: ColumnDef<TData, any>[]
  data: TData[]
}

export function DataTable<TData extends JewelryData>({
  columns,
  data
}: DataTableProps<TData>) {
  const [sorting, setSorting] = React.useState<SortingState>([])
  const [columnFilters, setColumnFilters] = React.useState<ColumnFiltersState>(
    []
  )
  const [currentPage, setCurrentPage] = React.useState(1)
  const [searchValue, setSearchValue] = React.useState<string>("")
  const itemsPerPage = 10

  const filteredData = React.useMemo(() => {
    return data.filter((item) =>
      item.jewelryId.toLowerCase().includes(searchValue.toLowerCase())
    )
  }, [data, searchValue])

  const sortedData = React.useMemo(() => {
    if (sorting.length === 0) return filteredData

    return [...filteredData].sort((a, b) => {
      for (let sort of sorting) {
        const columnId = sort.id
        const direction = sort.desc ? -1 : 1

        if (a[columnId] < b[columnId]) return -1 * direction
        if (a[columnId] > b[columnId]) return 1 * direction
      }
      return 0
    })
  }, [filteredData, sorting])

  const paginatedData = React.useMemo(() => {
    const startIndex = (currentPage - 1) * itemsPerPage
    const endIndex = startIndex + itemsPerPage
    return sortedData.slice(startIndex, endIndex)
  }, [sortedData, currentPage])

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
      columnFilters
    }
  })

  const totalPages = Math.ceil(filteredData.length / itemsPerPage)

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
              value={searchValue}
              onChange={(event) => setSearchValue(event.target.value)}
              className="w-[400px] max-w-sm border border-secondary bg-white pl-10"
            />
          </div>
        </div>

        <div className="flex gap-4">
          <AddJewelryDialog />
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
                        cell.getContext()
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
  )
}
