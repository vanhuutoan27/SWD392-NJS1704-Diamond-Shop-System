import ProductCard from "@/components/molecules/ProductCard";
import Section from "@/components/organisms/Section";
import { IDiamond } from "@/types/diamond.interface";

import {
  Carousel,
  CarouselContent,
  CarouselItem,
} from "@/components/atoms/carousel";

interface RelatedProductsProps {
  relatedProducts: IDiamond[];
}

function RelatedProducts({ relatedProducts }: RelatedProductsProps) {
  return (
    <div className="mt-10">
      <Section pageName={"Related Products"} />

      <Carousel
        opts={{
          align: "start",
        }}
        className="w-full"
      >
        <CarouselContent>
          {relatedProducts.map((diamond) => (
            <CarouselItem
              key={diamond.diamondId}
              className="p-2 md:basis-1/2 lg:basis-1/4"
            >
              <ProductCard
                diamondId={diamond.diamondId}
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

export default RelatedProducts;
