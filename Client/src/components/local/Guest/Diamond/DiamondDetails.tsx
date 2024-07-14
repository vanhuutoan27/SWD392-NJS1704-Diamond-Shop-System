import { useEffect, useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import { toast } from "sonner"

import { ICart, IDiamondCart } from "@/types/cart.interface"
import { IDiamond } from "@/types/diamond.interface"

import { diamondImage } from "@/lib/constants"
import { addToCart, formatCurrency, handleMouseMove } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import Section from "@/components/global/organisms/Section"

// Define the custom event type
interface CartChangedEvent extends CustomEvent {
  detail: ICart[]
}

function DiamondDetails({ diamondDetails }: { diamondDetails: IDiamond }) {
  const { user } = useAuthContext()

  const salePrice = null

  const [cartItems, setCartItems] = useState<ICart[]>([])

  useEffect(() => {
    const storedCartItems = localStorage.getItem("cartItems")
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems))
    }

    // Listen for the cartChanged event to update the cart items state
    const handleCartChanged = (event: Event) => {
      const customEvent = event as CartChangedEvent
      setCartItems(customEvent.detail)
    }

    window.addEventListener("cartChanged", handleCartChanged)

    return () => {
      window.removeEventListener("cartChanged", handleCartChanged)
    }
  }, [])

  const handleAddToCart = () => {
    if (!user) {
      toast.error("Please login to add to cart")
      return
    } else {
      const newItem: IDiamondCart = {
        cartId: `C${diamondDetails.diamondId}`,
        productType: "Diamond",
        productId: diamondDetails.diamondId,
        skuID: diamondDetails.skuID,
        quantity: 1,
        price: diamondDetails.price,
        image: diamondDetails.images,
        size: diamondDetails.size
      }
      const updatedCart = addToCart(cartItems, newItem)
      setCartItems(updatedCart)
      localStorage.setItem("cartItems", JSON.stringify(updatedCart))

      toast.success("Add to cart successfully")

      window.dispatchEvent(
        new CustomEvent("cartChanged", { detail: updatedCart })
      )
    }
  }

  return (
    <>
      <div className="flex w-full gap-10">
        <div
          className="image-container h-[500px] w-1/2 rounded-md border-2 border-input"
          onMouseMove={handleMouseMove}
        >
          <img
            src={diamondDetails.images || diamondImage}
            alt="Diamond"
            className="w-full cursor-pointer"
          />
        </div>

        <div className="flex w-1/2 flex-col gap-3">
          <h2 className="text-xl uppercase">
            Natural Diamond {diamondDetails.size}mm
          </h2>

          {salePrice ? (
            <span className="flex">
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(salePrice)}
              </span>
              <span className=" font-medium text-[#bababa] line-through">
                {formatCurrency(diamondDetails.price)}
              </span>
            </span>
          ) : (
            <>
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(diamondDetails.price)}
              </span>
            </>
          )}

          <p className="text-sm text-[#555]">
            Price may vary depending on actual product size and weight. <br />
            Please call{" "}
            <span className="font-semibold text-primary">
              (84) 098 765 321
            </span>{" "}
            for support.
          </p>

          <div className="mt-8 flex w-full gap-4">
            <Button type="button" variant={"secondary"}>
              Message
            </Button>
            <Button type="button" onClick={handleAddToCart}>
              Add To Cart
            </Button>
          </div>
        </div>
      </div>

      <div className="mt-4">
        <Section pageName={"Diamond Details"} />

        <table className="w-full border-collapse rounded-md">
          <tbody>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-secondary">
                Shape
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.shape}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Weight
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.weight}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-secondary">
                Color
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.colorLevel}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Clarity
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.clarity}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-secondary">
                Certification
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.certification}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Size
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.size}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-secondary">
                Fluorescence
              </td>
              <td className="border-2 border-input px-4 py-2 uppercase italic">
                {diamondDetails.fluorescence}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Quality of Cut
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.qualityOfCut}
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </>
  )
}

export default DiamondDetails
