import { useAuthContext } from "@/contexts/AuthContext"
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetOrderByUserId } from "@/apis/orderApi"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import { columns } from "@/components/local/Customer/Order/MyOrderColumns"
import { DataTable } from "@/components/local/Customer/Order/MyOrderDataTable"

function MyOrderPage() {
  const { user } = useAuthContext()

  const {
    data: allUserOrders,
    isLoading,
    isError
  } = useGetOrderByUserId(user?.id ?? "")

  if (!allUserOrders || isLoading) {
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

      <Section pageName={"Diamoon Orders"} />

      <DataTable columns={columns} data={allUserOrders} />
    </div>
  )
}

export default MyOrderPage
