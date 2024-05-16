import { type ClassValue, clsx } from "clsx";
import { twMerge } from "tailwind-merge";
import { ICart, ICartType } from "@/types/cart.interface";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";
import { IUserRole, IUserStatus } from "@/types/user.interface";

export function cn(...inputs: ClassValue[]) {
  return twMerge(clsx(inputs));
}

export const scrollToTop = () => {
  window.scrollTo({ top: 0, behavior: "smooth" });
};

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

export function getUserRole(role: IUserRole): string {
  switch (role) {
    case IUserRole.Customer:
      return "Customer";
    case IUserRole.SalesStaff:
      return "Sales Staff";
    case IUserRole.DeliveryStaff:
      return "Delivery Staff";
    case IUserRole.Manager:
      return "Manager";
    case IUserRole.Admin:
      return "Admin";
    default:
      return "Unknown";
  }
}

export function getUserStatus(status: IUserStatus): string {
  switch (status) {
    case IUserStatus.Active:
      return "Active";
    case IUserStatus.Inactive:
      return "Inactive";
    case IUserStatus.Suspended:
      return "Suspended";
    default:
      return "Unknown";
  }
}
