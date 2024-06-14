import { promotionData } from "@/constants/promotion"
import { Ticket } from "lucide-react"

import { formatCurrency, formatDate } from "@/lib/utils"

import { Skeleton } from "@/components/global/atoms/skeleton"
import {
  Tooltip,
  TooltipProvider,
  TooltipTrigger
} from "@/components/global/atoms/tooltip"
import { TooltipContent } from "@/components/global/atoms/tooltip"

function PromotionInfo() {
  const promotionImage =
    "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Images%2FDiamondSale.png?alt=media&token=e73fa245-ef96-4692-8278-50677328eb9f"

  return (
    <div className="flex flex-col gap-8">
      {promotionData.map((promotion, index) => (
        <div
          key={index}
          className="relative flex gap-6 border-2 border-input p-4 rounded-md shadow-md"
        >
          {!promotionImage ? (
            <Skeleton className="w-[285px] h-[200px] rounded animate-pulse" />
          ) : (
            <img
              src={promotionImage}
              alt="Promotion"
              className="min-w-[285px] h-[200px] rounded object-cover"
            />
          )}

          <div className="flex flex-col justify-start">
            <h4 className="text-xl font-medium mb-4">
              {promotion.description}. {promotion.value}% discount when
              purchasing orders from {formatCurrency(promotion.payAtLeast)}
            </h4>

            <div
              onClick={() => {
                navigator.clipboard.writeText(promotion.discountCode)
              }}
              className="mb-2"
            >
              <TooltipProvider>
                <Tooltip>
                  <TooltipTrigger className="flex gap-2 items-center slow hover:text-secondary">
                    <Ticket size={20} /> {promotion.discountCode}
                  </TooltipTrigger>
                  <TooltipContent>
                    <p>Click to copy</p>
                  </TooltipContent>
                </Tooltip>
              </TooltipProvider>
            </div>

            <p className="text-xs">
              {formatDate(promotion.dateToUse)} -{" "}
              {formatDate(promotion.dateExpiration)}
            </p>
          </div>

          <div className="absolute bottom-4 right-5 text-[10px] text-secondary">
            <p>Remaining quantity: {promotion.quantity}</p>
          </div>
        </div>
      ))}
    </div>
  )
}

export default PromotionInfo
