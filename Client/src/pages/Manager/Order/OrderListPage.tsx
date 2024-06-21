import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"
import { Loader } from "lucide-react"

import { useGetAllOrders } from "@/apis/orderApi"

import { columns } from "@/components/local/Manager/Order/OrderListColumns"
import { DataTable } from "@/components/local/Manager/Order/OrderListDataTable"

function OrderListPage() {
  const { data: orderData, error, isLoading } = useGetAllOrders()

  if (!orderData || isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }
  return (
    <div className="p-5">
      <DataTable columns={columns} data={orderData ?? []} />
    </div>
  )
}

export default OrderListPage
