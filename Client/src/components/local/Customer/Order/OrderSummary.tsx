import { ICart } from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { vatPercentage } from "@/lib/constants";
import { Button } from "@/components/global/atoms/button";
import { useState } from "react";
import { toast } from "sonner";

interface OrderSummaryProps {
  cartItems: ICart[];
}

const COUPON_DISCOUNTS: { [key: string]: number } = {
  Diamoon: 0.1,
  ToanDepTrai: 1,
};

function OrderSummary({ cartItems }: OrderSummaryProps) {
  const [couponCode, setCouponCode] = useState("");
  const [discount, setDiscount] = useState(0);
  const [discountMessage, setDiscountMessage] = useState("");

  const handleApplyCoupon = () => {
    const discountRate = COUPON_DISCOUNTS[couponCode] || 0;
    setDiscount(discountRate);

    if (discountRate > 0) {
      setDiscountMessage("Apply coupon successfully");
      toast.success("Apply coupon successfully");
    } else {
      setDiscountMessage("Apply coupon failed. Try another code!");
      toast.error("Apply coupon failed. Try another code!");
    }
  };

  const subTotal = cartItems.reduce(
    (sum, item) => sum + item.price * item.quantity,
    0,
  );
  const vatAmount = subTotal * vatPercentage;
  const discountAmount = subTotal * discount;
  const total = subTotal + vatAmount - discountAmount;

  return (
    <>
      <h3 className="mb-4 text-lg font-semibold">Order Summary</h3>

      <div className="flex flex-col gap-2">
        {cartItems.map((item) => (
          <div
            key={item.productId}
            className="flex items-center justify-between"
          >
            <img src={item.image} alt={item.productId} className="h-14 w-14" />
            <span>x{item.quantity}</span>
            <span className="font-semibold">
              {formatCurrency(item.price * item.quantity)}
            </span>
          </div>
        ))}
      </div>

      <div className="relative mt-8 w-full">
        <input
          type="text"
          placeholder="Coupon Code"
          value={couponCode}
          onChange={(e) => setCouponCode(e.target.value)}
          className="input-field"
        />
        <Button
          type="button"
          className="absolute right-0 h-11"
          onClick={handleApplyCoupon}
        >
          Apply
        </Button>
      </div>
      {discountMessage && (
        <div className="ml-2 text-sm text-red-600">{discountMessage}</div>
      )}

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
  );
}

export default OrderSummary;
