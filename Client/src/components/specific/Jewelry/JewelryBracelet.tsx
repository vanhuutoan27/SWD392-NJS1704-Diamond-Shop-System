import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import { jewelryData } from "@/constants/jewelry";
import { IJewelryStatus } from "@/types/jewelry.interface";

function JewelryBracelet() {
  const jewelries = jewelryData.filter(
    (jewelry) =>
      jewelry.jewelryCategory === "Bracelet" &&
      jewelry.status === IJewelryStatus.Available,
  );
  return (
    <div className="container">
      <RelatedJewelry pageName={"Bracelet"} relatedJewelries={jewelries} />
    </div>
  );
}

export default JewelryBracelet;
