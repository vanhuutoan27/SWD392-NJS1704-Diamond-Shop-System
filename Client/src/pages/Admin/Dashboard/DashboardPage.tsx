import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"
import {
  ArcElement,
  BarElement,
  CategoryScale,
  Chart,
  Legend,
  LineElement,
  LinearScale,
  PointElement,
  Title,
  Tooltip
} from "chart.js"
import { Bar, Line } from "react-chartjs-2"

import { IOrder } from "@/types/order.interface"

import { useGetAllDiamonds } from "@/apis/diamondApi"
import { useGetAllJewelries } from "@/apis/jewelryApi"
import { useGetAllOrders } from "@/apis/orderApi"
import { useGetAllUsers } from "@/apis/userApi"

import { Loader } from "@/components/global/atoms/Loader"
import KPICards from "@/components/local/Admin/Dashboard/KPICards"
import { columns } from "@/components/local/Admin/Dashboard/RecentOrderColumns"
import { DataTable } from "@/components/local/Admin/Dashboard/RecentOrderDataTable"
import RecentUser from "@/components/local/Admin/Dashboard/RecentUser"

Chart.register(
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend,
  LineElement,
  PointElement,
  ArcElement
)

// Helper function to generate month labels from January to the current month
const generateMonthLabels = () => {
  const monthNames = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
  ]
  const currentMonth = new Date().getMonth()
  return monthNames.slice(0, currentMonth + 1)
}

// Helper function to count orders per month
const countOrdersPerMonth = (orders: IOrder[]) => {
  const orderCounts = Array(12).fill(0)
  orders.forEach((order) => {
    const orderDate = new Date(order.dateCreated)
    const month = orderDate.getMonth()
    orderCounts[month]++
  })
  return orderCounts.slice(0, new Date().getMonth() + 1)
}

// Helper function to calculate total revenue per month
const calculateRevenuePerMonth = (orders: IOrder[]) => {
  const revenueCounts = Array(12).fill(0)
  orders.forEach((order) => {
    const orderDate = new Date(order.dateCreated)
    const month = orderDate.getMonth()
    revenueCounts[month] += order.total
  })
  return revenueCounts.slice(0, new Date().getMonth() + 1)
}

// Helper function to format currency without VND in a shortened format
const formatCurrencyM = (value: number) => {
  if (value >= 1000000000) {
    return (value / 1000000000).toFixed(0) + "b"
  }
  if (value >= 1000000) {
    return (value / 1000000).toFixed(0) + "m"
  }
  if (value >= 1000) {
    return (value / 1000).toFixed(0) + "k"
  }
  return value.toString()
}

const DashboardPage = () => {
  const { user } = useAuthContext()

  const roleName = user && user.role && user.role.Name ? user.role.Name : ""

  if (!user || !user.role || roleName !== "Admin") {
    return <ForbiddenPage />
  }

  const { data: diamondData } = useGetAllDiamonds()
  const { data: jewelryData } = useGetAllJewelries()
  const { data: userData } = useGetAllUsers()
  const { data: orderData } = useGetAllOrders()

  if (!diamondData || !jewelryData || !userData || !orderData) {
    return <Loader />
  }

  // Filter the data to only include items with status = 1
  const allDiamonds = diamondData.filter((item) => item.status === 1)
  const allJewelries = jewelryData.filter((item) => item.status === 1)
  const allUsers = userData.filter((item) => item.isActive)

  const monthLabels = generateMonthLabels()
  const orderCounts = countOrdersPerMonth(orderData)
  const revenueCounts = calculateRevenuePerMonth(orderData)

  const barData = {
    labels: monthLabels,
    datasets: [
      {
        label: "Orders",
        data: orderCounts,
        backgroundColor: "rgb(37 99 235)",
        borderColor: "rgb(191 219 254)",
        borderWidth: 1
      }
    ]
  }

  const lineData = {
    labels: monthLabels,
    datasets: [
      {
        label: "Revenue",
        data: revenueCounts,
        fill: false,
        borderColor: "rgb(37 99 235)",
        tension: 0.1
      }
    ]
  }

  const lineOptions = {
    scales: {
      y: {
        beginAtZero: true,
        ticks: {
          callback: (value: number) => formatCurrencyM(value),
          stepSize: 100000000
        }
      }
    }
  }

  const barOptions = {
    scales: {
      y: {
        beginAtZero: true,
        ticks: {
          callback: (value: number) => value,
          stepSize: 1
        }
      }
    }
  }

  const recentOrders = orderData?.slice(0, 5) || []
  const recentUsers = allUsers?.slice(0, 5) || []

  return (
    <div className="flex h-full w-full flex-col gap-8 p-5">
      <KPICards
        diamondData={allDiamonds}
        jewelryData={allJewelries}
        userData={allUsers}
        orderData={orderData}
      />

      <div className="grid grid-cols-1 gap-4 md:grid-cols-2">
        <div className="rounded-md border-2 border-input bg-white p-6 shadow-md">
          <h2 className="mb-4 text-xl font-semibold">Orders Overview</h2>
          <Bar data={barData} options={barOptions} />
        </div>
        <div className="rounded-md border-2 border-input bg-white p-6 shadow-md">
          <h2 className="mb-4 text-xl font-semibold">Revenue Trends</h2>
          <Line data={lineData} options={lineOptions} />
        </div>
      </div>

      <div className="grid grid-cols-8 gap-4">
        <div className="col-span-5 rounded-md border-2 border-input bg-white p-6 shadow-md">
          <h2 className="mb-4 text-xl font-semibold">Recent Orders</h2>
          <ul>
            <DataTable columns={columns} data={recentOrders} />
          </ul>
        </div>
        <div className="col-span-3 rounded-md border-2 border-input bg-white p-6 shadow-md">
          <h2 className="mb-4 text-xl font-semibold">New Users</h2>
          {recentUsers.length > 0 ? (
            <ul>
              {recentUsers.map((user) => (
                <li key={user._id} className="mb-2">
                  <RecentUser userData={user} time="Just now" isOnline={true} />
                </li>
              ))}
            </ul>
          ) : (
            <p className="h-24 text-center text-sm">No results.</p>
          )}
        </div>
      </div>
    </div>
  )
}

export default DashboardPage
