import {
  Pagination,
  PaginationContent,
  PaginationItem,
  PaginationLink,
  PaginationNext,
  PaginationPrevious
} from "@/components/global/atoms/pagination"

interface DataTablePaginationProps {
  currentPage: number
  totalPages: number
  setCurrentPage: (page: number) => void
}

function DataTablePagination({
  currentPage,
  totalPages,
  setCurrentPage
}: DataTablePaginationProps) {
  const handlePrevious = () => {
    if (currentPage > 1) {
      setCurrentPage(currentPage - 1)
    }
  }

  const handleNext = () => {
    if (currentPage < totalPages) {
      setCurrentPage(currentPage + 1)
    }
  }

  const handlePageClick = (page: number) => {
    setCurrentPage(page)
  }

  return (
    <div className="mt-8">
      <Pagination>
        <PaginationContent>
          <PaginationItem>
            <PaginationPrevious
              onClick={handlePrevious}
              className="cursor-pointer select-none"
            />
          </PaginationItem>
          {Array.from({ length: totalPages }, (_, index) => (
            <PaginationItem key={index} className="cursor-pointer select-none">
              <PaginationLink
                isActive={currentPage === index + 1}
                onClick={() => handlePageClick(index + 1)}
                className="slow"
              >
                {index + 1}
              </PaginationLink>
            </PaginationItem>
          ))}
          <PaginationItem>
            <PaginationNext
              onClick={handleNext}
              className="cursor-pointer select-none"
            />
          </PaginationItem>
        </PaginationContent>
      </Pagination>
    </div>
  )
}

export default DataTablePagination
