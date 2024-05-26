import { Loader } from "@/components/global/atoms/Loader";
import { columns } from "@/components/local/Manager/Diamond/DiamondListColumns";
import { DataTable } from "@/components/local/Manager/Diamond/DiamondListDataTable";
import diamoonAPI from "@/lib/diamoonAPI";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";
import { useEffect, useState } from "react";
import { toast } from "sonner";

function UserListPage() {
  const [diamondData, setDiamondData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const getAllDiamonds = async () => {
      try {
        const response = await diamoonAPI.get("/Diamond/All");
        setDiamondData(response.data);
        setIsLoading(false);
      } catch (error: any) {
        setError(error?.message || "An unknown error occurred");
        setIsLoading(false);
        toast.error("Failed to fetch diamonds");
      }
    };

    getAllDiamonds();
  }, []);

  if (isLoading) {
    return <Loader />;
  }

  if (error) {
    return <NotFoundPage />;
  }

  return (
    <div className="p-5">
      <DataTable columns={columns} data={diamondData} />
    </div>
  );
}

export default UserListPage;
