// import ProductCard from "@/components/molecules/ProductCard";
// import { jewelryData } from "@/constants/jewelry";
import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import { jewelryData } from "@/constants/jewelry";
import { IJewelryStatus } from "@/types/jewelry.interface";

function JewelryEarrnings() {
  const jewelries = jewelryData.filter(
    (jewelry) =>
      jewelry.jewelryCategory === "Earrings" &&
      jewelry.status === IJewelryStatus.Available,
  );
  return (
    <div className="container">
      <RelatedJewelry pageName={"Earrings"} relatedJewelries={jewelries} />
    </div>
  );
}

export default JewelryEarrnings;
