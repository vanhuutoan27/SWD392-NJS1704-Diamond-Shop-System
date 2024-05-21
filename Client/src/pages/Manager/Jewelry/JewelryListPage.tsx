import { columns } from "@/components/local/Manager/Jewelry/JewelryListColumns";
import { DataTable } from "@/components/local/Manager/Jewelry/JewelryListDataTable";
import { jewelryData } from "@/constants/jewelry";

function JewelryListPage() {
  const jewelries = jewelryData;

  return (
    <div className="p-5">
      <DataTable columns={columns} data={jewelries} />
    </div>
  );
}

export default JewelryListPage;
