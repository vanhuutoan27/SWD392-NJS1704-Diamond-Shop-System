import React from "react"

import { OrderStatus } from "@/types/order.interface"

import { getOrderStatusString } from "@/lib/utils"

interface OrderStatusChipProps {
  content: OrderStatus
}

const OrderStatusColors: Record<OrderStatus, string> = {
  [OrderStatus.Pending]: "#eab308", // Yellow - 500
  [OrderStatus.Processing]: "#3b82f6", // Blue - 500
  [OrderStatus.Shipping]: "#f97316", // Orange - 500
  [OrderStatus.Completed]: "#22c55e", // Green - 500
  [OrderStatus.Cancelled]: "#ef4444" // Red - 500
}

const OrderStatusChip: React.FC<OrderStatusChipProps> = ({ content }) => {
  const backgroundColor = OrderStatusColors[content] || "#000000"

  return (
    <div
      className="inline-flex cursor-pointer select-none items-center rounded-[50px] px-4 py-[6px] text-xs text-white"
      style={{ backgroundColor }}
    >
      <span>{getOrderStatusString(content)}</span>
    </div>
  )
}

export default OrderStatusChip
