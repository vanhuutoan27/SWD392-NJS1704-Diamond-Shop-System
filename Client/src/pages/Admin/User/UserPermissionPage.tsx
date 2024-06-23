import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"

function UserPermissionPage() {
  const { user } = useAuthContext()

  if (!user || !user.roles || !user.roles.includes("Admin")) {
    return <ForbiddenPage />
  }

  return <div className="p-5">UserPermissionPage</div>
}

export default UserPermissionPage
