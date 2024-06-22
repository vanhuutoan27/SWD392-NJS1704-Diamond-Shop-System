import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetInvoice } from "@/apis/invoiceApi"

import { Loader } from "@/components/global/atoms/Loader"
import { columns } from "@/components/local/Manager/Invoice/InvoiceListColumns"
import { DataTable } from "@/components/local/Manager/Invoice/InvoiceListDataTable"

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
      <DataTable columns={columns} data={invoiceData ?? []} />
    </div>
  )
}

export default InvoiceListPage
