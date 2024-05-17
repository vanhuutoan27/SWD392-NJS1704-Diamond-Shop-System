import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import { jewelryData } from "@/constants/jewelry";
import { IJewelryStatus } from "@/types/jewelry.interface";

function JewelryPendant() {
  const jewelries = jewelryData.filter(
    (jewelry) =>
      jewelry.jewelryCategory === "Pendant" &&
      jewelry.status === IJewelryStatus.Available,
  );
  return (
    <div className="container">
      <RelatedJewelry pageName={"Pendant"} relatedJewelries={jewelries} />
    </div>
  );
}

export default JewelryPendant;
