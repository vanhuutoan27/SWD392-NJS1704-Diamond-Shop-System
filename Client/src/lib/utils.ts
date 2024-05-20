import { type ClassValue, clsx } from "clsx";
import { twMerge } from "tailwind-merge";
import { ICart, ICartType } from "@/types/cart.interface";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";
import { IUserRole, IUserStatus } from "@/types/user.interface";
import { useLocation } from "react-router-dom";

export function cn(...inputs: ClassValue[]) {
  return twMerge(clsx(inputs));
}

// Scroll to top
export const scrollToTop = () => {
  window.scrollTo({ top: 0, behavior: "smooth" });
};

// Calculate cart total
export const calculateCartTotal = (cartItems: ICart[]) => {
  return cartItems.reduce(
    (total, item) => total + item.price * item.quantity,
    0,
  );
};

// Format currency
export const formatCurrency = (amount: number) => {
  return new Intl.NumberFormat("vi-VN").format(amount) + " VND";
};

// Format date
export const formatDate = (dateStr: string): string => {
  const date = new Date(dateStr);
  if (isNaN(date.getTime())) {
    return "Invalid Date";
  }
  const day = date.getDate().toString().padStart(2, "0");
  const month = (date.getMonth() + 1).toString().padStart(2, "0");
  const year = date.getFullYear();
  return `${month}/${day}/${year}`;
};

// Format date time
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

// Get user role
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

// Get user status
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

export const useIsAdminRoute = (): boolean => {
  const location = useLocation();
  return location.pathname.startsWith("/admin");
};
