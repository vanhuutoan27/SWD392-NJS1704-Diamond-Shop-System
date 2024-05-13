import { Card, CardContent } from "@/components/atoms/card";
import {
  Carousel,
  CarouselContent,
  CarouselItem,
} from "@/components/atoms/carousel";

function CarouselSlider() {
  const Slides = [
    { title: "Toan", description: "Description 1" },
    { title: "Dep", description: "Description 2" },
    { title: "Trai", description: "Description 3" },
  ];

  return (
    <div>
      <Carousel
        opts={{
          align: "start",
          loop: true,
        }}
        className="container h-full"
      >
        <CarouselContent>
          {Slides.map((slide, index) => (
            <CarouselItem key={index}>
              <Card>
                <CardContent className="flex h-screen flex-col items-center justify-center bg-slate-200 p-6">
                  <h2 className="text-4xl font-semibold">{slide.title}</h2>
                  <p className="text-xl">{slide.description}</p>
                </CardContent>
              </Card>
            </CarouselItem>
          ))}
        </CarouselContent>
      </Carousel>
    </div>
  );
}

export default CarouselSlider;
