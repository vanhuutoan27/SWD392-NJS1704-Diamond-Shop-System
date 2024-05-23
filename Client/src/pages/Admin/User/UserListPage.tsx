import { columns } from "@/components/local/Admin/User/UserListColumns";
import { DataTable } from "@/components/local/Admin/User/UserListDataTable";
import { userData } from "@/constants/user";

function UserListPage() {
  const users = userData;

  return (
    <div className="p-5">
      <DataTable columns={columns} data={users} />
    </div>
  );
}

export default UserListPage;
