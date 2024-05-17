// import ProductCard from "@/components/molecules/ProductCard";
// import { jewelryData } from "@/constants/jewelry";
import { projectName } from "@/lib/constants";

function JewelryPage() {
  // const jewelries = jewelryData;

  return (
    <div className="container">
      <img
        src="../images/home_slider_1.jpg"
        alt={projectName}
        className="h-[500px] w-full object-cover"
      />
    </div>
  );
}

export default JewelryPage;
