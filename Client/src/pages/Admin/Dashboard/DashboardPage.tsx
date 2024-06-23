import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"

import KPICards from "@/components/local/Admin/Dashboard/KPICards"

function DashboardPage() {
  const { user } = useAuthContext()

  if (!user || !user.roles || !user.roles.includes("Admin")) {
    return <ForbiddenPage />
  }

  return (
    <div className="flex h-[1000px] w-full flex-col gap-8 p-5">
      <KPICards />

      <div>asd</div>
    </div>
  )
}

export default DashboardPage
