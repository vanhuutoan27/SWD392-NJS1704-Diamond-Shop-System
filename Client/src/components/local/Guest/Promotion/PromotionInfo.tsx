import { useState } from "react"

import { formatCurrency, formatDate } from "@/lib/utils"

import {
  Tooltip,
  TooltipProvider,
  TooltipTrigger
} from "@/components/global/atoms/tooltip"
import { TooltipContent } from "@/components/global/atoms/tooltip"

import { promotionData } from "../../../../constants/promotion"

function PromotionInfo() {
  const [, setHoveredIndex] = useState<number | null>(null)

  return (
    <div className="space-y-8">
      {promotionData.map((promotion, index) => (
        <div key={index} className="relative flex border p-4 rounded shadow-sm">
          <img
            src="https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Images%2FDiamondSale.png?alt=media&token=e73fa245-ef96-4692-8278-50677328eb9f"
            alt="Promotion"
            className="w-1/4 h-auto rounded mr-4"
          />
          <div className="flex-1 px-5">
            <p className="text-xl font-medium mb-2">
              {promotion.description}. {promotion.value}% discount when
              purchasing orders from {formatCurrency(promotion.payAtLeast)}
            </p>

            <div
              onClick={() => {
                navigator.clipboard.writeText(promotion.discountCode)
              }}
              onMouseEnter={() => setHoveredIndex(index)}
              onMouseLeave={() => setHoveredIndex(null)}
              className="pb-3 pt-2"
            >
              <TooltipProvider>
                <Tooltip>
                  <TooltipTrigger>{promotion.discountCode}</TooltipTrigger>
                  <TooltipContent>
                    <p>Click to copy</p>
                  </TooltipContent>
                </Tooltip>
              </TooltipProvider>
            </div>

            <p className="mb-1 text-xs">
              Start date: {formatDate(promotion.dateToUse)} -{" "}
              {formatDate(promotion.dateExpiration)}
            </p>
          </div>
          <div className="absolute bottom-4 right-5 text-[10px] text-secondary">
            <div className="text-right">
              <p className="mb-1">Remaining quantity: {promotion.quantity}</p>
            </div>
          </div>
        </div>
      ))}
    </div>
  )
}

export default PromotionInfo
