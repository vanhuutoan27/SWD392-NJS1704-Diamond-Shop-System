import { DollarSign, Gem, Users } from "lucide-react"

import { IDiamond } from "@/types/diamond.interface"
import { IJewelry } from "@/types/jewelry.interface"
import { IOrder } from "@/types/order.interface"
import { IUser } from "@/types/user.interface"

import { formatCurrency } from "@/lib/utils"

interface KPICardsProps {
  diamondData: IDiamond[]
  jewelryData: IJewelry[]
  userData: IUser[]
  orderData: IOrder[]
}

function KPICards({
  diamondData,
  jewelryData,
  userData,
  orderData
}: KPICardsProps) {
  const totalProfit = orderData.reduce((sum, order) => sum + order.total, 0)
  const totalDiamonds = diamondData?.length
  const totalJewelries = jewelryData?.length
  const totalUsers = userData?.length

  const kpiCards = [
    {
      title: "Total Revenue",
      value: formatCurrency(totalProfit),
      icon: <DollarSign />,
      percentage: "4.35%",
      trend: "up"
    },
    {
      title: "Total Diamonds",
      value: totalDiamonds,
      icon: <Gem />,
      percentage: "2.59%",
      trend: "up"
    },
    {
      title: "Total Jewelries",
      value: totalJewelries,
      icon: <Gem />,
      percentage: "2.59%",
      trend: "up"
    },
    {
      title: "Total Users",
      value: totalUsers,
      icon: <Users />,
      percentage: "0.95%",
      trend: "down"
    }
  ]

  return (
    <div className="grid grid-cols-1 gap-4 md:grid-cols-2 lg:grid-cols-4">
      {kpiCards.map((card, index) => (
        <div
          key={index}
          className={`flex flex-col gap-4 rounded-md border-2 border-input bg-white p-4 shadow-md`}
        >
          <div className="w-fit rounded-full bg-slate-200 p-3 text-blue-600">
            {card.icon}
          </div>
          <div>
            <div className="text-2xl font-semibold text-primary">
              {card.value}
            </div>

            <div className="flex justify-between">
              <div className="text-sm text-secondary">{card.title}</div>

              {/* <div
                className={`font-semibold ${card.trend === "up" ? "text-green-500" : "text-red-500"}`}
              >
                {card.percentage} {card.trend === "up" ? "↑" : "↓"}
              </div> */}
            </div>
          </div>
        </div>
      ))}
    </div>
  )
}

export default KPICards
