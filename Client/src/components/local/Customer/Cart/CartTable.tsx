import { useEffect, useState } from "react"

import { Link, useNavigate } from "react-router-dom"
import { toast } from "sonner"

import { ICart } from "@/types/cart.interface"

import { vatPercentage } from "@/lib/constants"
import diamoonAPI from "@/lib/diamoonAPI"
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import { ScrollArea, ScrollBar } from "@/components/global/atoms/scroll-area"
import { cartColumns } from "@/components/local/Customer/Cart/CartColumns"
import { DataTable } from "@/components/local/Customer/Cart/CartDataTable"

import { cartDiamondColumns } from "./CartDiamondColumns"
import { cartJewelryColumns } from "./CartJewelryColumns"
import { TabsContent } from "./CartTabs"

const fetchDiamondById = async (id: string) => {
  const { data } = await diamoonAPI.get(`/Diamond/${id}`)
  return data
}

const fetchJewelryById = async (id: string) => {
  const { data } = await diamoonAPI.get(`/Jewelry/${id}`)
  return data.data
}

interface RenderTabContentProps {
  type: string
  title: string
  columns: any[]
  data: any[]
  subTotal: number
}

function CartTable() {
  const [cartItems, setCartItems] = useState<ICart[]>([])
  const [enrichedItems, setEnrichedItems] = useState<ICart[]>([])
  const navigate = useNavigate()

  const loadCartItems = () => {
    const storedCartItems = localStorage.getItem("cartItems")
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems))
    }
  }

  useEffect(() => {
    loadCartItems()

    const handleStorageChange = () => {
      loadCartItems()
    }

    window.addEventListener("storage", handleStorageChange)
    window.addEventListener("cartChanged", handleStorageChange)

    return () => {
      window.removeEventListener("storage", handleStorageChange)
      window.removeEventListener("cartChanged", handleStorageChange)
    }
  }, [])

  useEffect(() => {
    const enrichCartItemsWithApiData = async () => {
      const enrichedItems = await Promise.all(
        cartItems.map(async (item) => {
          if (item.productType === "Diamond") {
            const productDetails = await fetchDiamondById(item.productId)
            return { ...item, ...productDetails }
          } else if (item.productType === "Jewelry") {
            const productDetails = await fetchJewelryById(item.productId)
            return { ...item, ...productDetails }
          }
          return item
        })
      )
      setEnrichedItems(enrichedItems)
    }

    if (cartItems.length > 0) {
      enrichCartItemsWithApiData()
    }
  }, [cartItems])

  useEffect(() => {
    const handleDiamondStatusChange = () => {
      const storedCartItems = localStorage.getItem("cartItems")
      if (storedCartItems) {
        const cartItems = JSON.parse(storedCartItems)
        const updatedCartItems = cartItems.filter(
          (item: ICart) => item.status !== 0
        )
        setCartItems(updatedCartItems)
        localStorage.setItem("cartItems", JSON.stringify(updatedCartItems))
      }
    }

    window.addEventListener("storage", handleDiamondStatusChange)

    return () => {
      window.removeEventListener("storage", handleDiamondStatusChange)
    }
  }, [cartItems])

  const updateItemQuantity = (productId: string, newQuantity: number) => {
    if (newQuantity < 1) {
      handleRemoveItem(productId)
      return
    }

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
    if (item) {
      updateItemQuantity(productId, item.quantity - 1)
    }
  }

  const handleRemoveItem = (productId: string) => {
    const updatedCartItems = cartItems.filter(
      (item) => item.productId !== productId
    )
    setCartItems(updatedCartItems)
    localStorage.setItem("cartItems", JSON.stringify(updatedCartItems))
    window.dispatchEvent(new CustomEvent("cartChanged"))
    window.dispatchEvent(
      new CustomEvent("cartItemRemoved", { detail: productId })
    )

    toast.success("Item removed from cart!")
  }

  const handleCheckout = () => {
    navigate("/order", { state: { cartItems } })
    scrollToTop()
  }

  const allItemsInCart = enrichedItems.filter((item) => item.quantity > 0)

  const diamondsInCart = allItemsInCart.filter(
    (item) => item.productType === "Diamond"
  )
  const jewelriesInCart = allItemsInCart.filter(
    (item) => item.productType === "Jewelry"
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
