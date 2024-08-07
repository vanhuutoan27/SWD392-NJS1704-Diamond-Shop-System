import { useEffect, useState } from "react"

import { X } from "lucide-react"
import { toast } from "sonner"

import { ICart } from "@/types/cart.interface"

import { vatPercentage } from "@/lib/constants"
import { formatCurrency } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

interface OrderSummaryProps {
  cartItems: ICart[]
  onTotalChange: (total: number) => void
}

const COUPON_DISCOUNTS: { [key: string]: number } = {
  Diamoon: 0.1,
  ToanDepTrai: 1
}

function OrderSummary({ cartItems, onTotalChange }: OrderSummaryProps) {
  const [couponCode, setCouponCode] = useState("")
  const [discount, setDiscount] = useState(0)

  const handleApplyCoupon = () => {
    const discountRate = COUPON_DISCOUNTS[couponCode] || 0
    setDiscount(discountRate)

    if (discountRate > 0) {
      toast.success("Apply coupon successfully")
    } else {
      toast.error("Apply coupon failed. Try another code!")
    }
  }

  const handleClearCoupon = () => {
    setCouponCode("")
    setDiscount(0)
  }

  const subTotal = cartItems.reduce(
    (sum, item: ICart) => sum + item.price * item.quantity,
    0
  )
  const vatAmount = subTotal * vatPercentage
  const discountAmount = subTotal * discount
  const total = subTotal + vatAmount - discountAmount

  useEffect(() => {
    onTotalChange(total)
  }, [total, onTotalChange])

  return (
    <>
      <h3 className="mb-4 text-lg font-semibold">Order Summary</h3>

      <div className="flex flex-col gap-2">
        {cartItems.map((item: ICart) => (
          <div
            key={item.productId}
            className="flex w-full items-center justify-between"
          >
            <div className="w-1/4">
              <img
                src={item.image}
                alt={item.productId}
                className="h-14 w-14"
              />
            </div>
            <span className="w-1/4">x{item.quantity}</span>
            <span className="w-2/4 text-right font-semibold">
              {formatCurrency(item.price * item.quantity)}
            </span>
          </div>
        ))}
      </div>

      <div className="mt-8 flex">
        <div className="relative w-full">
          <input
            type="text"
            placeholder="Coupon Code"
            value={couponCode}
            onChange={(e) => setCouponCode(e.target.value)}
            className="input-field w-full"
          />
          <X
            size={16}
            className="absolute right-4 top-1/2 -translate-y-1/2 transform cursor-pointer text-secondary"
            onClick={handleClearCoupon}
          />
        </div>
        <Button type="button" className="ml-4 h-11" onClick={handleApplyCoupon}>
          Apply
        </Button>
      </div>

      <div className="text-md mt-8 flex w-full flex-col gap-2 font-medium">
        <div className="flex justify-between">
          <span>Sub-Total:</span>
          <span className="font-semibold">{formatCurrency(subTotal)}</span>
        </div>
        <div className="flex justify-between">
          <span>Coupon Discount ({discount ? discount * 100 : 0}%):</span>
          <span className="font-semibold">
            {formatCurrency(discountAmount)}
          </span>
        </div>
        <div className="flex justify-between">
          <span>VAT ({vatPercentage * 100}%):</span>
          <span className="font-semibold">{formatCurrency(vatAmount)}</span>
        </div>
        <div className="flex justify-between">
          <span>Total:</span>
          <span className="font-semibold">{formatCurrency(total)}</span>
        </div>
      </div>
    </>
  )
}

export default OrderSummary
