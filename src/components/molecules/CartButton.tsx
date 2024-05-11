import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuLabel,
  DropdownMenuTrigger,
} from "@/components/atoms/dropdown-menu";
import { ShoppingCart } from "lucide-react";
import { Link } from "react-router-dom";

function CartButton() {
  const cartItems = [
    {
      id: 1,
      name: "Diamond Ring",
      price: 1000,
      image: "https://source.unsplash.com/300x300/?diamond",
      productUrl: "/product/1",
    },
    {
      id: 2,
      name: "Gold Ring",
      price: 500,
      image: "https://source.unsplash.com/300x300/?gold",
      productUrl: "/product/2",
    },
  ];

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild>
        <div className="relative flex cursor-pointer select-none items-center gap-4 text-primary transition-all duration-200 hover:text-[#888]">
          <ShoppingCart strokeWidth={2.5} />
          <span className="mt-1 text-sm font-medium">
            Cart ({cartItems.length})
          </span>
        </div>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="absolute -right-12 mt-4 flex min-h-20 w-96 flex-col items-center justify-center gap-2">
        {cartItems.length > 0 ? (
          cartItems.map((cartItem) => (
            <DropdownMenuGroup
              key={cartItem.id}
              className="flex w-full items-center gap-4"
            >
              <div className="flex h-14 w-14 items-center">
                <Link to={cartItem.productUrl}>
                  <img
                    src={cartItem.image}
                    alt={cartItem.name}
                    className="rounded-md object-cover"
                  />
                </Link>
              </div>

              <div className="flex w-full flex-col gap-2">
                <Link
                  to={cartItem.productUrl}
                  className="text-base font-semibold transition-all duration-200 hover:text-[#888]"
                >
                  {cartItem.name}
                </Link>
                <span className="text-sm font-medium">${cartItem.price}</span>
              </div>
            </DropdownMenuGroup>
          ))
        ) : (
          <DropdownMenuLabel>Your shopping cart is empty!</DropdownMenuLabel>
        )}
      </DropdownMenuContent>
    </DropdownMenu>
  );
}

export default CartButton;
