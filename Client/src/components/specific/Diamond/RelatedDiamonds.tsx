import ProductCard from "@/components/molecules/ProductCard";
import Section from "@/components/organisms/Section";
import { IDiamond } from "@/types/diamond.interface";

import {
  Carousel,
  CarouselContent,
  CarouselItem,
} from "@/components/atoms/carousel";

interface RelatedDiamondsProps {
  pageName?: string;
  relatedDiamonds: IDiamond[];
}

function RelatedDiamonds({ pageName, relatedDiamonds }: RelatedDiamondsProps) {
  return (
    <div className="mt-10">
      <Section pageName={pageName || "Related Diamonds"} />

      <Carousel
        opts={{
          align: "start",
        }}
        className="w-full"
      >
        <CarouselContent>
          {relatedDiamonds.map((diamond) => (
            <CarouselItem
              key={diamond.diamondId}
              className="p-2 md:basis-1/2 lg:basis-1/4"
            >
              <ProductCard
                productId={diamond.diamondId}
                image={diamond.image}
                size={diamond.size}
                price={diamond.price}
              />
            </CarouselItem>
          ))}
        </CarouselContent>
      </Carousel>
    </div>
  );
}

export default RelatedDiamonds;
