import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import { jewelryData } from "@/constants/jewelry";
import { IJewelryStatus } from "@/types/jewelry.interface";

function JewelryRing() {
  const jewelries = jewelryData.filter(
    (jewelry) =>
      jewelry.jewelryCategory === "Ring" &&
      jewelry.status === IJewelryStatus.Available,
  );
  return (
    <div className="container">
      <RelatedJewelry pageName={"Ring"} relatedJewelries={jewelries} />
    </div>
  );
}

export default JewelryRing;
