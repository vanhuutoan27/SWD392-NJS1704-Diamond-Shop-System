import CarouselSlider from "@/components/local/Home/CarouselSlider";
import FeatureArea from "@/components/local/Home/FeatureArea";
import VariousProducts from "@/components/local/Home/VariousProducts";
import FeaturedCollections from "@/components/local/Home/FeaturedCollections";

function HomePage() {
  return (
    <div className="flex w-full flex-col gap-5">
      <CarouselSlider />
      <FeatureArea />
      <VariousProducts />
      <FeaturedCollections />
    </div>
  );
}

export default HomePage;
