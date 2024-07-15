import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetAllInvoices } from "@/apis/invoiceApi"

import { Loader } from "@/components/global/atoms/Loader"
import { columns } from "@/components/local/Manager/Invoice/InvoiceListColumns"
import { DataTable } from "@/components/local/Manager/Invoice/InvoiceListDataTable"

function InvoiceListPage() {
  const { user } = useAuthContext()

  if (!user || !user.roles || !user.roles.includes("Admin")) {
    return <ForbiddenPage />
  }

  const { data: invoiceData, error, isLoading } = useGetAllInvoices()

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
