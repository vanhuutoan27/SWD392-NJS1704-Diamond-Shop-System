import { columns } from "@/components/local/Admin/User/UserListColumns";
import { DataTable } from "@/components/local/Admin/User/UserListDataTable";
import { userData } from "@/constants/user";
import { useAuthContext } from "@/contexts/AuthContext";
import { Navigate } from "react-router-dom";

function UserListPage() {
  const { user } = useAuthContext();

  if (!user || !user.roles.includes("Admin")) {
    return <Navigate to="/forbidden" />;
  }

  const users = userData;

  return (
    <div className="p-5">
      <DataTable columns={columns} data={users} />
    </div>
  );
}

export default UserListPage;
