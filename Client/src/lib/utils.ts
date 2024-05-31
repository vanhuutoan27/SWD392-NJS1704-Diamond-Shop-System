import { type ClassValue, clsx } from "clsx";
import { twMerge } from "tailwind-merge";
import { ICart, ICartType } from "@/types/cart.interface";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";
import { IUserRole } from "@/types/user.interface";
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

// Get product data
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

// Check if the current route is an admin route
export const useIsAdminRoute = (): boolean => {
  const location = useLocation();
  return location.pathname.startsWith("/admin");
};

// Add item to cart
export const addToCart = (cartItems: ICart[], newItem: ICart) => {
  const existingItem = cartItems.find(
    (item) => item.productId === newItem.productId,
  );
  if (existingItem) {
    return cartItems.map((item) =>
      item.productId === newItem.productId
        ? { ...item, quantity: item.quantity + newItem.quantity }
        : item,
    );
  }
  return [...cartItems, newItem];
};

// Get username from email
export function getUsername(email: string) {
  if (typeof email === "string" && email.includes("@")) {
    const parts = email.split("@");
    return parts[0];
  } else {
    return null;
  }
}

// Calc subtotal of invoice
export const calculateSubtotal = (
  items: { price: number; quantity: number }[],
) => {
  return items.reduce((total, item) => total + item.price * item.quantity, 0);
};

// Calculate VAT of invoice
export const calculateVat = (subtotal: number, vatPercentage: number) => {
  return subtotal * vatPercentage;
};

// Calculate total of invoice
export const calculateTotal = (
  subtotal: number,
  vatAmount: number,
  discount: number,
) => {
  return subtotal + vatAmount - discount;
};

// Format invoice data
export const formatInvoiceData = (invoiceData: any, vatPercentage: number) => {
  const subtotal = calculateSubtotal(invoiceData.items);
  const discount = subtotal * 0.1;
  const vatAmount = calculateVat(subtotal, vatPercentage);
  const total = calculateTotal(subtotal, vatAmount, discount);

  return {
    ...invoiceData,
    subtotal: formatCurrency(subtotal),
    discount: formatCurrency(discount),
    vatAmount: formatCurrency(vatAmount),
    total: formatCurrency(total),
  };
};

//
