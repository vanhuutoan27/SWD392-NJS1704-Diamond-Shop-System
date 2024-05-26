import { ICart } from "@/types/cart.interface";
import { formatCurrency } from "@/lib/utils";
import { vatPercentage } from "@/lib/constants";

interface OrderSummaryProps {
  cartItems: ICart[];
}

function OrderSummary({ cartItems }: OrderSummaryProps) {
  const subTotal = cartItems.reduce(
    (sum, item) => sum + item.price * item.quantity,
    0,
  );
  const vatAmount = subTotal * vatPercentage;
  const total = subTotal + vatAmount;

  return (
    <div className="rounded-md border-2 border-input bg-white p-5 shadow-md">
      <h3 className="mb-4 text-lg font-semibold">Order Summary</h3>

      <div className="flex flex-col gap-2">
        {cartItems.map((item) => (
          <div
            key={item.productId}
            className="flex items-center justify-between"
          >
            <img src={item.image} alt={item.productId} className="h-14 w-14" />
            <span>x{item.quantity}</span>
            <span>{formatCurrency(item.price * item.quantity)}</span>
          </div>
        ))}
      </div>

      <div className="text-md mt-8 flex w-full flex-col gap-2 font-medium">
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
    </div>
  );
}

export default OrderSummary;
