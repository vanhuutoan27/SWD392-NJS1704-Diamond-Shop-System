import { type ClassValue, clsx } from "clsx";
import { twMerge } from "tailwind-merge";
import { ICart, ICartType } from "@/types/cart.interface";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";

export function cn(...inputs: ClassValue[]) {
  return twMerge(clsx(inputs));
}

export const calculateCartTotal = (cartItems: ICart[]) => {
  return cartItems.reduce(
    (total, item) => total + item.price * item.quantity,
    0,
  );
};

export const formatCurrency = (amount: number) => {
  return new Intl.NumberFormat("vi-VN").format(amount) + " VND";
};

export function getProductData(cartItem: ICart) {
  switch (cartItem.productType) {
    case ICartType.Diamond:
      return diamondData.find((item) => item.diamondId === cartItem.productId);
    case ICartType.Jewelry:
      return jewelryData.find((item) => item.jewelryId === cartItem.productId);
    default:
      return null;
  }
}
