import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetInvoice } from "@/apis/invoiceApi"

import { Loader } from "@/components/global/atoms/Loader"

function InvoiceListPage() {
  const { data: invoiceData, error, isLoading } = useGetInvoice()

  if (isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <div className="p-5">
      thu
    </div>
  )
}

export default InvoiceListPage
