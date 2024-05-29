import { useGetAllUsers } from "@/api/userApi";
import { Loader } from "@/components/global/atoms/Loader";
import { columns } from "@/components/local/Admin/User/UserListColumns";
import { DataTable } from "@/components/local/Admin/User/UserListDataTable";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";

function UserListPage() {
  const { data: userData, error, isLoading } = useGetAllUsers();

  // console.log(userData);

  if (isLoading) {
    return <Loader />;
  }

  if (error) {
    return <NotFoundPage />;
  }

  return (
    <div className="p-5">
      <DataTable columns={columns} data={userData ?? []} />
    </div>
  );
}

export default UserListPage;
