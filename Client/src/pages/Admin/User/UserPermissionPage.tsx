import { useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import ForbiddenPage from "@/pages/Guest/HTTP/ForbiddenPage"
import { Settings2 } from "lucide-react"

import { Button } from "@/components/global/atoms/button"
import { columns } from "@/components/local/Admin/User/UserPermissionColumns"
import { DataTable } from "@/components/local/Admin/User/UserPermissionDataTable"

function UserPermissionPage() {
  const { user } = useAuthContext()

  if (!user || !user.roles || !user.roles.includes("Admin")) {
    return <ForbiddenPage />
  }

  const [isEditing, setIsEditing] = useState(false)

  const handleEdit = () => {
    setIsEditing(!isEditing)
  }

  const data = [
    {
      userId: "1",
      permissionId: "1",
      permissionName: "Admin",
      diamond: 4,
      jewelry: 4,
      user: 4,
      order: 4,
      invoice: 1
    },
    {
      userId: "2",
      permissionId: "2",
      permissionName: "Manager",
      diamond: 3,
      jewelry: 3,
      user: 0,
      order: 3,
      invoice: 1
    },
    {
      userId: "3",
      permissionId: "3",
      permissionName: "DeliveryStaff",
      diamond: 1,
      jewelry: 1,
      user: 0,
      order: 2,
      invoice: 1
    },
    {
      userId: "4",
      permissionId: "4",
      permissionName: "SalesStaff",
      diamond: 1,
      jewelry: 1,
      user: 0,
      order: 1,
      invoice: 1
    }
  ]

  return (
    <div className="p-5">
      <div className="mb-4 flex items-center justify-between py-4">
        <div></div>

        {isEditing ? (
          <div className="flex gap-4">
            <Button
              type="button"
              variant={"secondary"}
              className="flex items-center gap-2"
              onClick={handleEdit}
            >
              Cancel
            </Button>

            <Button
              type="button"
              className="flex items-center gap-2 bg-gray-800 pl-5 hover:bg-gray-900"
              onClick={handleEdit}
            >
              Save Changes
            </Button>
          </div>
        ) : (
          <Button
            type="button"
            className="flex items-center gap-2 bg-gray-800 pl-5 hover:bg-gray-900"
            onClick={() => setIsEditing(!isEditing)}
          >
            <Settings2 size={20} /> Update Permission
          </Button>
        )}
      </div>

      <DataTable columns={columns(isEditing)} data={data} />
    </div>
  )
}

export default UserPermissionPage
