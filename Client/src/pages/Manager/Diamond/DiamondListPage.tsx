import { columns } from "@/components/local/Manager/Diamond/DiamondListColumns";
import { DataTable } from "@/components/local/Manager/Diamond/DiamondListDataTable";
import { diamondData } from "@/constants/diamond";

function UserListPage() {
  const diamonds = diamondData;

  return (
    <div className="p-5">
      <DataTable columns={columns} data={diamonds} />
    </div>
  );
}

export default UserListPage;
