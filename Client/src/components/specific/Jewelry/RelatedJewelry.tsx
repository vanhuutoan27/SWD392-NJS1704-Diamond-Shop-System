import ProductCard from "@/components/molecules/ProductCard";
import Section from "@/components/organisms/Section";
import { IJewelry } from "@/types/jewelry.interface";

import {
  Carousel,
  CarouselContent,
  CarouselItem,
} from "@/components/atoms/carousel";

interface RelatedJewelryProps {
  pageName?: string;
  relatedJewelries: IJewelry[];
}

function RelatedJewelry({ pageName, relatedJewelries }: RelatedJewelryProps) {
  return (
    <div className="mt-10">
      <Section pageName={pageName || "Related Jewelry"} />

      <Carousel
        opts={{
          align: "start",
        }}
        className="w-full"
      >
        <CarouselContent>
          {relatedJewelries.map((jewelry) => (
            <CarouselItem
              key={jewelry.jewelryId}
              className="p-2 md:basis-1/2 lg:basis-1/4"
            >
              <ProductCard
                productId={jewelry.jewelryId}
                image={jewelry.image}
                image2={jewelry.image2}
                jewelryName={jewelry.jewelryName}
                price={jewelry.price}
              />
            </CarouselItem>
          ))}
        </CarouselContent>
      </Carousel>
    </div>
  );
}

export default RelatedJewelry;
