import React, { createContext, useContext, useState } from "react"

import { IOrderPost } from "@/types/order.interface"

interface OrderContextProps {
  formData: IOrderPost | null
  setFormData: (data: IOrderPost) => void
}

const OrderContext = createContext<OrderContextProps | undefined>(undefined)

export const OrderProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [formData, setFormData] = useState<IOrderPost | null>(null)

  return (
    <OrderContext.Provider value={{ formData, setFormData }}>
      {children}
    </OrderContext.Provider>
  )
}

export const useOrderContext = () => {
  const context = useContext(OrderContext)
  if (!context) {
    throw new Error("useOrderContext must be used within an OrderProvider")
  }
  return context
}
