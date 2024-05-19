import { Eye, DollarSign, ShoppingBag, Users } from "lucide-react";

function KPICards() {
  const kpiCards = [
    {
      title: "Total Views",
      value: "3.456K",
      icon: <Eye />,
      percentage: "0.43%",
      trend: "up",
    },
    {
      title: "Total Profit",
      value: "$45.2K",
      icon: <DollarSign />,
      percentage: "4.35%",
      trend: "up",
    },
    {
      title: "Total Products",
      value: "2.450",
      icon: <ShoppingBag />,
      percentage: "2.59%",
      trend: "up",
    },
    {
      title: "Total Users",
      value: "3.456",
      icon: <Users />,
      percentage: "0.95%",
      trend: "down",
    },
  ];

  return (
    <div className="grid grid-cols-1 gap-4 md:grid-cols-2 lg:grid-cols-4">
      {kpiCards.map((card, index) => (
        <div
          key={index}
          className={`flex flex-col gap-4 rounded-md bg-white p-4 shadow-md`}
        >
          <div className="w-fit rounded-full bg-slate-200 p-3 text-blue-600">
            {card.icon}
          </div>
          <div>
            <div className="text-2xl font-semibold text-primary">
              {card.value}
            </div>

            <div className="flex justify-between">
              <div className="text-sm text-[#908e9b]">{card.title}</div>

              <div
                className={`font-semibold ${card.trend === "up" ? "text-green-500" : "text-red-500"}`}
              >
                {card.percentage} {card.trend === "up" ? "↑" : "↓"}
              </div>
            </div>
          </div>
        </div>
      ))}
    </div>
  );
}

export default KPICards;
