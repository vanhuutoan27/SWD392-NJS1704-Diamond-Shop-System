import { useGetAllJewelries } from "@/api/jewelryApi";
import { Loader } from "@/components/global/atoms/Loader";
import { columns } from "@/components/local/Manager/Jewelry/JewelryListColumns";
import { DataTable } from "@/components/local/Manager/Jewelry/JewelryListDataTable";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";

function JewelryListPage() {
  const { data: jewelryData, error, isLoading } = useGetAllJewelries();

  if (isLoading) {
    return <Loader />;
  }

  if (error) {
    return <NotFoundPage />;
  }

  return (
    <div className="p-5">
      <DataTable columns={columns} data={jewelryData ?? []} />
    </div>
  );
}

export default JewelryListPage;
