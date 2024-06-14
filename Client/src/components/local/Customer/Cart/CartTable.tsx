import { useEffect, useState } from "react"

import { Link, useNavigate } from "react-router-dom"
import { toast } from "sonner"

import { ICart } from "@/types/cart.interface"

import { useGetAllDiamonds } from "@/apis/diamondApi"
import { useGetAllJewelries } from "@/apis/jewelryApi"

import { vatPercentage } from "@/lib/constants"
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils"

import { Loader } from "@/components/global/atoms/Loader"
import { Button } from "@/components/global/atoms/button"
import { ScrollArea, ScrollBar } from "@/components/global/atoms/scroll-area"
import { cartColumns } from "@/components/local/Customer/Cart/CartColumns"
import { DataTable } from "@/components/local/Customer/Cart/CartDataTable"

import { cartDiamondColumns } from "./CartDiamondColumns"
import { cartJewelryColumns } from "./CartJewelryColumns"
import { TabsContent } from "./CartTabs"

interface RenderTabContentProps {
  type: string
  title: string
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  columns: any[]
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  data: any[]
  subTotal: number
}

function CartTable() {
  const [cartItems, setCartItems] = useState<ICart[]>([])
  const navigate = useNavigate()

  const {
    data: allDiamonds,
    error: diamondsError,
    isLoading: isDiamondsLoading
  } = useGetAllDiamonds()

  const {
    data: allJewelries,
    error: jewelriesError,
    isLoading: isJewelriesLoading
  } = useGetAllJewelries()

  useEffect(() => {
    const storedCartItems = localStorage.getItem("cartItems")
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems))
    }
  }, [])

  const getProductDetails = (productId: string, type: string) => {
    if (type === "Diamond") {
      return allDiamonds?.find((diamond) => diamond.diamondId === productId)
    } else if (type === "Jewelry") {
      return allJewelries?.find((jewelry) => jewelry.jewelryId === productId)
    }
  }

  const enrichCartItems = (items: ICart[]) => {
    return items.map((item) => {
      const productDetails = getProductDetails(item.productId, item.productType)
      return { ...item, ...productDetails }
    })
  }

  const updateItemQuantity = (productId: string, newQuantity: number) => {
    if (newQuantity < 1) return
    const updatedCartItems = cartItems.map((item) =>
      item.productId === productId ? { ...item, quantity: newQuantity } : item
    )
    setCartItems(updatedCartItems)
    localStorage.setItem("cartItems", JSON.stringify(updatedCartItems))

    toast.success("Quantity updated successfully")
  }

  const incrementQuantity = (productId: string) => {
    const item = cartItems.find((item) => item.productId === productId)
    if (item) {
      updateItemQuantity(productId, item.quantity + 1)
    }
  }

  const decrementQuantity = (productId: string) => {
    const item = cartItems.find((item) => item.productId === productId)
    if (item && item.quantity > 1) {
      updateItemQuantity(productId, item.quantity - 1)
    }
  }

  const handleCheckout = () => {
    navigate("/order", { state: { cartItems } })
    scrollToTop()
  }

  if (isDiamondsLoading || isJewelriesLoading) {
    return <Loader />
  }

  if (diamondsError || jewelriesError) {
    toast.error("Failed to fetch data")
  }

  const allItemsInCart = cartItems.filter((item) => item.quantity > 0)
  const diamondsInCart = enrichCartItems(
    allItemsInCart.filter((item) => item.productType === "Diamond")
  )
  const jewelriesInCart = enrichCartItems(
    allItemsInCart.filter((item) => item.productType === "Jewelry")
  )

  const tabData = [
    {
      type: "all",
      title: `All products in the cart (${allItemsInCart.length})`,
      columns: cartColumns(
        updateItemQuantity,
        incrementQuantity,
        decrementQuantity
      ),
      data: allItemsInCart,
      subTotal: calculateCartTotal(allItemsInCart)
    },
    {
      type: "jewelry",
      title: `All Jewelries in the cart (${jewelriesInCart.length})`,
      columns: cartJewelryColumns(
        updateItemQuantity,
        incrementQuantity,
        decrementQuantity
      ),
      data: jewelriesInCart,
      subTotal: calculateCartTotal(jewelriesInCart)
    },
    {
      type: "diamond",
      title: `All Diamonds in the cart (${diamondsInCart.length})`,
      columns: cartDiamondColumns(
        updateItemQuantity,
        incrementQuantity,
        decrementQuantity
      ),
      data: diamondsInCart,
      subTotal: calculateCartTotal(diamondsInCart)
    }
  ]

  const renderTabContent = ({
    type,
    title,
    columns,
    data,
    subTotal
  }: RenderTabContentProps) => {
    const vatAmount = subTotal * vatPercentage
    const total = subTotal + vatAmount

    return (
      <TabsContent value={type} key={type}>
        <h3 className="mb-4 ml-4 text-xl font-semibold uppercase">{title}</h3>

        <ScrollArea className="rounded-md border shadow-md">
          <DataTable columns={columns} data={data} />
          <ScrollBar orientation="horizontal" />
        </ScrollArea>

        <div className="text-md mt-8 flex w-full flex-col gap-4 pl-2 font-medium">
          <div className="flex justify-between">
            <span>Sub-Total:</span>
            <span>{formatCurrency(subTotal)}</span>
          </div>
          <div className="flex justify-between">
            <span>VAT ({vatPercentage * 100}%):</span>
            <span>{formatCurrency(vatAmount)}</span>
          </div>
          <div className="flex justify-between">
            <span>Total:</span>
            <span>{formatCurrency(total)}</span>
          </div>
        </div>
      </TabsContent>
    )
  }

  return (
    <div className="flex flex-col gap-8">
      {tabData.map(renderTabContent)}

      <div className="flex w-full justify-end gap-4">
        <Link to="/diamond" onClick={scrollToTop}>
          <Button type="button" variant={"secondary"}>
            Continue Shopping
          </Button>
        </Link>
        <Button type="button" onClick={handleCheckout}>
          Checkout
        </Button>
      </div>
    </div>
  )
}

export default CartTable
