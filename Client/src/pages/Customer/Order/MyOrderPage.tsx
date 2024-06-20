import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetAllOrders } from "@/apis/orderApi"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import { columns } from "@/components/local/Customer/Order/MyOrderColumns"
import { DataTable } from "@/components/local/Customer/Order/MyOrderDataTable"

function MyOrderPage() {
  const { data: allOrders, isLoading, isError } = useGetAllOrders()

  if (!allOrders || isLoading) {
    return <Loader />
  }

  if (isError) {
    return <NotFoundPage />
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="User"
        currentDetailPage="My Orders"
      />

      <Section pageName={"Diamond Order"} />

      <DataTable columns={columns} data={allOrders} />
    </div>
  )
}

export default MyOrderPage
