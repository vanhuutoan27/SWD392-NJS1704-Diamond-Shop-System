import { useEffect, useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import { Navigate, Outlet } from "react-router-dom"

import { Loader } from "../atoms/Loader"
import Sidebar from "../organisms/Sidebar"
import Sidebar2 from "../organisms/Sidebar2"

function AuthLayout() {
  const { user } = useAuthContext()
  const [isLoading, setIsLoading] = useState(true)

  useEffect(() => {
    if (user) {
      setIsLoading(false)
      // console.log(user.roles);
    }
  }, [user])

  if (isLoading) {
    return <Loader />
  }

  if (!user || !user.roles || user.roles.includes("Customer")) {
    return <Navigate to="/forbidden" />
  }

  if (user.roles.includes("Admin") || user.roles.includes("Manager")) {
    return (
      <div className="h-screen">
        <Sidebar />
        <div className="ml-72 min-h-full bg-slate-100">
          <Outlet />
        </div>
      </div>
    )
  }

  if (
    user.roles.includes("DeliveryStaff") ||
    user.roles.includes("SaleStaff")
  ) {
    return (
      <div className="h-screen">
        <Sidebar2 />
        <div className="ml-72 min-h-full bg-slate-100">
          <Outlet />
        </div>
      </div>
    )
  }

  return <Navigate to="/forbidden" />
}

export default AuthLayout
