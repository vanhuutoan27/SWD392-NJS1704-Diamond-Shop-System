import { useEffect, useState } from "react"

import { ShoppingCart, X } from "lucide-react"
import { Link } from "react-router-dom"
import { toast } from "sonner"

import { ICart, IDiamondCart, IJewelryCart } from "@/types/cart.interface"

import { vatPercentage } from "@/lib/constants"
import diamoonAPI from "@/lib/diamoonAPI"
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuLabel,
  DropdownMenuTrigger
} from "@/components/global/atoms/dropdown-menu"
import { Separator } from "@/components/global/atoms/separator"

const fetchDiamondById = async (id: string) => {
  const { data } = await diamoonAPI.get(`/Diamond/${id}`)
  return data.data
}

const fetchJewelryById = async (id: string) => {
  const { data } = await diamoonAPI.get(`/Jewelry/${id}`)
  return data.data
}

function CartButton() {
  const [isOpen, setIsOpen] = useState(false)
  const [cartItems, setCartItems] = useState<ICart[]>([])
  const [enrichedItems, setEnrichedItems] = useState<ICart[]>([])

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

  const isDiamondCart = (item: ICart): item is IDiamondCart => {
    return item.productType === "Diamond"
  }

  const handleRemoveItem = (cartId: string) => {
    const updatedCartItems = cartItems.filter((item) => item.cartId !== cartId)
    const updatedEnrichedItems = enrichedItems.filter(
      (item) => item.cartId !== cartId
    )

    setCartItems(updatedCartItems)
    setEnrichedItems(updatedEnrichedItems)

    localStorage.setItem("cartItems", JSON.stringify(updatedCartItems))
    window.dispatchEvent(new CustomEvent("cartChanged"))
    window.dispatchEvent(new CustomEvent("cartItemRemoved", { detail: cartId }))

    toast.success("Item removed from cart!")
  }

  const subTotal = calculateCartTotal(enrichedItems)
  const vatAmount = subTotal * vatPercentage
  const total = subTotal + vatAmount

  const handleClose = () => setIsOpen(false)

  return (
    <DropdownMenu open={isOpen} onOpenChange={setIsOpen}>
      <DropdownMenuTrigger asChild>
        <div className="slow relative flex cursor-pointer select-none items-center gap-4 text-primary hover:text-secondary">
          <ShoppingCart strokeWidth={2.5} />
          <span className="mt-1 text-sm font-medium">
            Cart ({enrichedItems.length})
          </span>
        </div>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="absolute -right-12 mt-4 flex min-h-32 w-[450px] flex-col items-center justify-center gap-4 shadow-md">
        {enrichedItems.length > 0 ? (
          <>
            {enrichedItems.map((cartItem) => (
              <DropdownMenuGroup
                key={cartItem.cartId}
                className="flex w-full items-center gap-4"
              >
                <div className="flex h-14 w-14 items-center">
                  <Link
                    to={
                      isDiamondCart(cartItem)
                        ? `/diamond/${cartItem.productId}`
                        : `/jewelry/${cartItem.productId}`
                    }
                    target="_blank"
                    rel="noopener noreferrer"
                  >
                    <img
                      src={cartItem.images}
                      alt={
                        isDiamondCart(cartItem)
                          ? `Natural Diamond ${cartItem.size}mm`
                          : (cartItem as IJewelryCart).jewelryName
                      }
                      className="rounded-md object-cover uppercase"
                    />
                  </Link>
                </div>

                <div className="flex w-full justify-between gap-2">
                  <div>
                    <div>
                      <Link
                        to={
                          isDiamondCart(cartItem)
                            ? `/diamond/${cartItem.productId}`
                            : `/jewelry/${cartItem.productId}`
                        }
                        target="_blank"
                        rel="noopener noreferrer"
                        className="slow mr-2 text-sm font-semibold uppercase hover:text-secondary"
                      >
                        {isDiamondCart(cartItem)
                          ? `Natural Diamond ${cartItem.size}mm`
                          : (cartItem as IJewelryCart).jewelryName}
                      </Link>
                      <span className="text-sm">x {cartItem.quantity}</span>
                    </div>
                    <span className="text-sm font-medium">
                      {formatCurrency(cartItem.price)}
                    </span>
                  </div>
                  <div className="mt-2">
                    <X
                      size={20}
                      className="slow cursor-pointer text-red-800 hover:text-red-800/80"
                      onClick={() => handleRemoveItem(cartItem.cartId)}
                    />
                  </div>
                </div>
              </DropdownMenuGroup>
            ))}

            <Separator className="bg-gray-900/20" />

            <div className="my-2 flex w-full flex-col gap-3 pl-2 text-sm font-medium">
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

            <div className="flex w-full justify-end gap-4">
              <Link
                to="/cart"
                onClick={() => {
                  scrollToTop()
                  handleClose()
                }}
              >
                <Button type="button">View Cart</Button>
              </Link>
            </div>
          </>
        ) : (
          <DropdownMenuLabel>Your shopping cart is empty!</DropdownMenuLabel>
        )}
      </DropdownMenuContent>
    </DropdownMenu>
  )
}

export default CartButton
