import {
  Carousel,
  CarouselContent,
  CarouselItem,
} from "@/components/atoms/carousel";
import { projectName } from "@/lib/constants";

function CarouselSlider() {
  const slides = [
    { image: "../images/home_slider_2.jpg" },
    { image: "../images/home_slider_1.jpg" },
    { image: "../images/home_slider_3.jpg" },
  ];

  return (
    <div>
      <Carousel
        opts={{
          align: "start",
          loop: true,
        }}
      >
        <CarouselContent>
          {slides.map((slide, index) => (
            <CarouselItem key={index}>
              <div className="ml-4 flex h-full flex-col items-center justify-center overflow-hidden rounded-md bg-slate-200">
                <img
                  src={slide.image}
                  alt={projectName}
                  className="h-[600px] w-full object-cover cursor-pointer"
                />
              </div>
            </CarouselItem>
          ))}
        </CarouselContent>
      </Carousel>
    </div>
  );
}

export default CarouselSlider;
