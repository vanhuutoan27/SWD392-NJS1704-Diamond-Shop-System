import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetAllUsers } from "@/apis/userApi"

import { Loader } from "@/components/global/atoms/Loader"
import { columns } from "@/components/local/Admin/User/UserListColumns"
import { DataTable } from "@/components/local/Admin/User/UserListDataTable"

function UserListPage() {
  const { user } = useAuthContext()

  if (!user || !user.roles || !user.roles.includes("Admin")) {
    return <ForbiddenPage />
  }

  const { data: userData, error, isLoading } = useGetAllUsers()

  // console.log(userData);

  if (!userData || isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <div className="p-5">
      <DataTable columns={columns} data={userData ?? []} />
    </div>
  )
}

export default UserListPage
