import { Button } from "@/components/global/atoms/button";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuLabel,
  DropdownMenuTrigger,
} from "@/components/global/atoms/dropdown-menu";
import { Separator } from "@/components/global/atoms/separator";
import { diamondImage, vatPercentage } from "@/lib/constants";
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils";
import { ICart, IDiamondCart } from "@/types/cart.interface";
import { ShoppingCart, X } from "lucide-react";
import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { toast } from "sonner";

function isDiamondCart(item: ICart): item is IDiamondCart {
  return item.productType === "Diamond";
}

function CartButton() {
  const [isOpen, setIsOpen] = useState(false);
  const [cartItems, setCartItems] = useState<ICart[]>([]);

  const loadCartItems = () => {
    const storedCartItems = localStorage.getItem("cartItems");
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems));
    }
  };

  useEffect(() => {
    loadCartItems();

    const handleStorageChange = () => {
      loadCartItems();
    };

    window.addEventListener("storage", handleStorageChange);
    window.addEventListener("cartChanged", handleStorageChange);

    return () => {
      window.removeEventListener("storage", handleStorageChange);
      window.removeEventListener("cartChanged", handleStorageChange);
    };
  }, []);

  const handleRemoveItem = (cartId: string) => {
    const updatedCartItems = cartItems.filter((item) => item.cartId !== cartId);
    setCartItems(updatedCartItems);
    localStorage.setItem("cartItems", JSON.stringify(updatedCartItems));
    window.dispatchEvent(new CustomEvent("cartChanged"));

    toast.success("Item removed from cart!");
  };

  const subTotal = calculateCartTotal(cartItems);
  const vatAmount = subTotal * vatPercentage;
  const total = subTotal + vatAmount;

  const handleClose = () => setIsOpen(false);

  return (
    <DropdownMenu open={isOpen} onOpenChange={setIsOpen}>
      <DropdownMenuTrigger asChild>
        <div className="slow relative flex cursor-pointer select-none items-center gap-4 text-primary hover:text-secondary">
          <ShoppingCart strokeWidth={2.5} />
          <span className="mt-1 text-sm font-medium">
            Cart ({cartItems.length})
          </span>
        </div>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="absolute -right-12 mt-4 flex min-h-32 w-[450px] flex-col items-center justify-center gap-4 shadow-md">
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
                      isDiamondCart(cartItem)
                        ? `/diamond/${cartItem.productId}`
                        : `/jewelry/${cartItem.productId}`
                    }
                  >
                    <img
                      src={
                        isDiamondCart(cartItem) ? diamondImage : cartItem.image
                      }
                      alt={
                        isDiamondCart(cartItem)
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
                          isDiamondCart(cartItem)
                            ? `/diamond/${cartItem.productId}`
                            : `/jewelry/${cartItem.productId}`
                        }
                        className="slow mr-2 text-sm font-semibold uppercase hover:text-secondary"
                      >
                        {isDiamondCart(cartItem)
                          ? `Natural Diamond x ${cartItem.size}mm`
                          : cartItem.jewelryName}
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
                  scrollToTop();
                  handleClose();
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
  );
}

export default CartButton;
