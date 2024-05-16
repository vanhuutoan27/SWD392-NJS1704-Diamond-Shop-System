// import ProductCard from "@/components/molecules/ProductCard";
// import { jewelryData } from "@/constants/jewelry";
import { projectName } from "@/lib/constants";

function JewelryPage() {
  // const jewelries = jewelryData;

  return (
    <div className="container">
      <img
        src="https://cdn.shopify.com/s/files/1/1115/6326/files/B1004_Diamonds_banner_2_thumb_61466c50-3bfb-4d54-a2b3-205219e956f5.jpg?v=1511876014"
        alt={projectName}
        className="h-[500px] w-full object-cover"
      />

    </div>
  );
}

export default JewelryPage;
