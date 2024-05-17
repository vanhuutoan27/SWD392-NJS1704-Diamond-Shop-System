import { Button } from "@/components/atoms/button";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuLabel,
  DropdownMenuTrigger,
} from "@/components/atoms/dropdown-menu";
import { Separator } from "@/components/atoms/separator";
import { cartData } from "@/constants/cart";
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils";
import { ShoppingCart, X } from "lucide-react";
import { Link } from "react-router-dom";

function CartButton() {
  const cartItems = cartData.filter((item) => item.quantity > 0);
  const vatPercentage = 0.1;

  const subTotal = calculateCartTotal(cartItems);
  const vatAmount = subTotal * vatPercentage;
  const total = subTotal + vatAmount;

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild>
        <div className="relative flex cursor-pointer select-none items-center gap-4 text-primary transition-all duration-300 hover:text-[#888]">
          <ShoppingCart strokeWidth={2.5} />
          <span className="mt-1 text-sm font-medium">
            Cart ({cartItems.length})
          </span>
        </div>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="absolute -right-12 mt-4 flex min-h-20 w-[450px] flex-col items-center justify-center gap-4 shadow-md">
        {cartItems.length > 0 ? (
          <>
            {cartItems.map((cartItem) => (
              <DropdownMenuGroup
                key={cartItem.cartId}
                className="flex w-full items-center gap-4"
              >
                <div className="flex h-14 w-14 items-center">
                  <Link
                    to={
                      cartItem.productType === "Diamond"
                        ? `/diamond/${cartItem.productId}`
                        : `/jewelry/${cartItem.productId}`
                    }
                  >
                    <img
                      src={cartItem.image}
                      alt={
                        cartItem.productType === "Diamond"
                          ? `Natural Diamond x ${cartItem.size}mm`
                          : cartItem.jewelryName
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
                          cartItem.productType === "Diamond"
                            ? `/diamond/${cartItem.productId}`
                            : `/jewelry/${cartItem.productId}`
                        }
                        className="mr-2 text-sm font-semibold uppercase transition-all duration-300 hover:text-[#888]"
                      >
                        {cartItem.productType === "Diamond"
                          ? `Natural Diamond x ${cartItem.size}mm`
                          : cartItem.jewelryName}
                      </Link>
                      <span className="text-sm">x {cartItem.quantity}</span>
                    </div>
                    <span className="text-[12px] font-medium">
                      {formatCurrency(cartItem.price)}
                    </span>
                  </div>
                  <div className="mt-2">
                    <X
                      size={20}
                      className="cursor-pointer text-red-800 transition-all duration-300 hover:text-red-800/80"
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
              <Link to="/cart" onClick={scrollToTop}>
                <Button type="button" variant={"secondary"}>
                  View Cart
                </Button>
              </Link>
              <Link to="/checkout" onClick={scrollToTop}>
                <Button type="button">Checkout</Button>
              </Link>
            </div>
          </>
        ) : (
          <DropdownMenuLabel>Your shopping cart is empty!</DropdownMenuLabel>
        )}
      </DropdownMenuContent>
    </DropdownMenu>
  );
}

export default CartButton;
