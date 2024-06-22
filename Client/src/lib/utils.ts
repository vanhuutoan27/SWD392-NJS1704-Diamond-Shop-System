import { type ClassValue, clsx } from "clsx"
import { useLocation } from "react-router-dom"
import { twMerge } from "tailwind-merge"

import { ICart } from "@/types/cart.interface"
import { IOrderPaymentMethod, OrderStatus } from "@/types/order.interface"

export function cn(...inputs: ClassValue[]) {
  return twMerge(clsx(inputs))
}

// Scroll to top
export const scrollToTop = () => {
  window.scrollTo({ top: 0, behavior: "smooth" })
}

// Calculate cart total
export const calculateCartTotal = (cartItems: ICart[]) => {
  return cartItems.reduce(
    (total, item) => total + item.price * item.quantity,
    0
  )
}

// Format currency without VND
export const formatCurrencyWithoutVND = (amount: number) => {
  return new Intl.NumberFormat("vi-VN").format(amount)
}

// Format currency
export const formatCurrency = (amount: number) => {
  return new Intl.NumberFormat("vi-VN").format(amount) + " VND"
}

// Format date
export const formatDate = (dateStr: string): string => {
  const date = new Date(dateStr)
  if (isNaN(date.getTime())) {
    return "Invalid Date"
  }
  const day = date.getDate().toString().padStart(2, "0")
  const month = (date.getMonth() + 1).toString().padStart(2, "0")
  const year = date.getFullYear()
  return `${day}/${month}/${year}`
}

// Check if the current route is an admin route
export const useIsAdminRoute = (): boolean => {
  const location = useLocation()
  return location.pathname.startsWith("/admin")
}

// Zoom in image on hover
export const handleMouseMove = (event: React.MouseEvent<HTMLDivElement>) => {
  const container = event.currentTarget
  const rect = container.getBoundingClientRect()
  const x = ((event.clientX - rect.left) / rect.width) * 100
  const y = ((event.clientY - rect.top) / rect.height) * 100
  container.style.setProperty("--x", `${x}%`)
  container.style.setProperty("--y", `${y}%`)
}

// Add item to cart
export const addToCart = (cartItems: ICart[], newItem: ICart) => {
  const existingItem = cartItems.find(
    (item) => item.productId === newItem.productId
  )
  if (existingItem) {
    return cartItems.map((item) =>
      item.productId === newItem.productId
        ? { ...item, quantity: item.quantity + newItem.quantity }
        : item
    )
  }
  return [...cartItems, newItem]
}

// Get username from email
export function getUsername(email: string) {
  if (typeof email === "string" && email.includes("@")) {
    const parts = email.split("@")
    return parts[0]
  } else {
    return null
  }
}

// Calc subtotal of invoice
export const calculateSubtotal = (
  items: { price: number; quantity: number }[]
) => {
  return items.reduce((total, item) => total + item.price * item.quantity, 0)
}

// Calculate VAT of invoice
export const calculateVat = (subtotal: number, vatPercentage: number) => {
  return subtotal * vatPercentage
}

// Calculate total of invoice
export const calculateTotal = (
  subtotal: number,
  vatAmount: number,
  discount: number
) => {
  return subtotal + vatAmount - discount
}

// Format invoice data
export const formatInvoiceData = (invoiceData: any, vatPercentage: number) => {
  const subtotal = calculateSubtotal(invoiceData.items)
  const discount = subtotal * 0.1
  const vatAmount = calculateVat(subtotal, vatPercentage)
  const total = calculateTotal(subtotal, vatAmount, discount)

  return {
    ...invoiceData,
    subtotal: formatCurrency(subtotal),
    discount: formatCurrency(discount),
    vatAmount: formatCurrency(vatAmount),
    total: formatCurrency(total)
  }
}

// Get payment method number
export const getPaymentMethodNumber = (method: IOrderPaymentMethod) => {
  switch (method) {
    case IOrderPaymentMethod.Deposit500:
      return 0
    case IOrderPaymentMethod.Deposit1000:
      return 1
    case IOrderPaymentMethod.Deposit1500:
      return 2
    case IOrderPaymentMethod.Deposit2000:
      return 3
    case IOrderPaymentMethod.BankTransfer:
      return 4
    case IOrderPaymentMethod.CreditCard:
      return 5
    default:
      return 4
  }
}

// Get payment method string
export const getPaymentMethodString = (number: number): string => {
  switch (number) {
    case 0:
      return "Deposit500"
    case 1:
      return "Deposit1000"
    case 2:
      return "Deposit1500"
    case 3:
      return "Deposit2000"
    case 4:
      return "BankTransfer"
    case 5:
      return "CreditCard"
    default:
      return "BankTransfer"
  }
}

// Get order status string
export const getOrderStatusString = (status: number): string => {
  switch (status) {
    case OrderStatus.Pending:
      return "Pending"
    case OrderStatus.Processing:
      return "Processing"
    case OrderStatus.Shipping:
      return "Shipping"
    case OrderStatus.Completed:
      return "Completed"
    case OrderStatus.Cancelled:
      return "Cancelled"
    default:
      return "Unknown Status"
  }
}
