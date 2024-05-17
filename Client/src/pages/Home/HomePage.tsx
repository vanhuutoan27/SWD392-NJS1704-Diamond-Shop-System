import RelatedDiamonds from "@/components/specific/Diamond/RelatedDiamonds";
import CarouselSlider from "@/components/specific/Home/CarouselSlider";
import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";

function HomePage() {
  const allDiamonds = diamondData;
  const allJewelries = jewelryData;

  return (
    <div className="container flex w-full flex-col">
      <CarouselSlider />

      <RelatedJewelry
        pageName={"Natural Diamond Jewelry"}
        relatedJewelries={allJewelries}
      />

      <RelatedDiamonds
        pageName={"Natural Diamond"}
        relatedDiamonds={allDiamonds}
      />
    </div>
  );
}

export default HomePage;
