import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"
import { DollarSign, Eye, Gem, Users } from "lucide-react"

import { useGetAllDiamonds } from "@/apis/diamondApi"
import { useGetAllJewelries } from "@/apis/jewelryApi"
import { useGetAllUsers } from "@/apis/userApi"

import { Loader } from "@/components/global/atoms/Loader"

function KPICards() {
  const {
    data: diamondData,
    error: diamondError,
    isLoading: diamondLoading
  } = useGetAllDiamonds()

  const {
    data: jewelryData,
    error: jewelryError,
    isLoading: jewelryLoading
  } = useGetAllJewelries()

  const {
    data: userData,
    error: userError,
    isLoading: userLoading
  } = useGetAllUsers()

  if (
    !diamondData ||
    !jewelryData ||
    !userData ||
    diamondLoading ||
    jewelryLoading ||
    userLoading
  ) {
    return <Loader />
  }

  if (diamondError || jewelryError || userError) {
    return <NotFoundPage />
  }

  const kpiCards = [
    {
      title: "Total Views",
      value: "3.456K",
      icon: <Eye />,
      percentage: "0.43%",
      trend: "up"
    },
    {
      title: "Total Profit",
      value: "$45.2K",
      icon: <DollarSign />,
      percentage: "4.35%",
      trend: "up"
    },
    {
      title: "Total Products",
      value:
        diamondData?.length.toString() ??
        "0" + jewelryData?.length.toString() ??
        "0",
      icon: <Gem />,
      percentage: "2.59%",
      trend: "up"
    },
    {
      title: "Total Users",
      value: userData?.length.toString() ?? "0",
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
