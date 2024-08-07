import {
  Pagination,
  PaginationContent,
  PaginationItem,
  PaginationLink,
  PaginationNext,
  PaginationPrevious
} from "@/components/global/atoms/pagination"

interface JewelryListPaginationProps {
  currentPage: number
  totalPages: number
  setCurrentPage: (page: number) => void
}

function JewelryListPagination({
  currentPage,
  totalPages,
  setCurrentPage
}: JewelryListPaginationProps) {
  const handlePrevious = () => {
    if (currentPage > 1) {
      window.scrollTo({ top: 500, behavior: "smooth" })
      setCurrentPage(currentPage - 1)
    }
  }

  const handleNext = () => {
    if (currentPage < totalPages) {
      window.scrollTo({ top: 500, behavior: "smooth" })
      setCurrentPage(currentPage + 1)
    }
  }

  const handlePageClick = (page: number) => {
    window.scrollTo({ top: 500, behavior: "smooth" })

    setCurrentPage(page)
  }

  return (
    <div className="mt-10">
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

export default JewelryListPagination
