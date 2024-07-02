import { useAuthContext } from "@/contexts/AuthContext"
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import CartCategories from "@/components/local/Customer/Cart/CartCategories"
import CartTable from "@/components/local/Customer/Cart/CartTable"
import { Tabs } from "@/components/local/Customer/Cart/CartTabs"

function CartPage() {
  const { user } = useAuthContext()

  if (!user) {
    return <NotFoundPage />
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="User"
        currentDetailPage="My Cart"
      />

      <Section pageName={"Diamond Cart"} />

      <Tabs
        defaultValue="all"
        className="mt-4 flex w-full justify-between gap-8"
      >
        <div className="w-1/4">
          <CartCategories />
        </div>

        <div className="w-3/4">
          <CartTable />
        </div>
      </Tabs>
    </div>
  )
}

export default CartPage
