import { useAuthContext } from "@/contexts/AuthContext"
import { Navigate } from "react-router-dom"

import { Loader } from "@/components/global/atoms/Loader"

function RedirectPage() {
  const { user } = useAuthContext()

  if (!user) {
    return <Loader />
  }

  const roles = user?.roles || []

  if (roles.includes("Admin")) {
    return <Navigate to="/admin/dashboard" />
  } else if (roles.includes("Manager")) {
    return <Navigate to="/admin/jewelry-list" />
  } else if (roles.includes("SalesStaff") || roles.includes("DeliveryStaff")) {
    return <Navigate to="/staff/dashboard" />
  } else if (roles.includes("Customer")) {
    return <Navigate to="/" />
  }

  return <Loader />
}

export default RedirectPage
