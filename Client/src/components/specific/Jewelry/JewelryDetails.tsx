import { useState } from "react";
import { IJewelry } from "@/types/jewelry.interface";
import { formatCurrency } from "@/lib/utils";
import Section from "../../organisms/Section";
import { Button } from "../../atoms/button";

function JewelryDetails({ jewelryDetails }: { jewelryDetails: IJewelry }) {
  const salePrice = 100000000;

  const handleMouseMove = (event: React.MouseEvent<HTMLDivElement>) => {
    const container = event.currentTarget;
    const rect = container.getBoundingClientRect();
    const x = ((event.clientX - rect.left) / rect.width) * 100;
    const y = ((event.clientY - rect.top) / rect.height) * 100;
    container.style.setProperty("--x", `${x}%`);
    container.style.setProperty("--y", `${y}%`);
  };

  const [currentImageIndex, setCurrentImageIndex] = useState(0);
  const images = [jewelryDetails.image, jewelryDetails.image2];

  const selectImage = (index: number) => {
    setCurrentImageIndex(index);
  };

  return (
    <>
      <div className="flex w-full gap-10">
        <div className="w-1/2">
          <div
            className="image-container rounded-md"
            onMouseMove={handleMouseMove}
          >
            <img
              src={images[currentImageIndex]}
              alt="Jewelry"
              className="h-auto w-full cursor-pointer"
            />
          </div>

          <div className="flex w-full">
            {images.map((image, index) => (
              <img
                key={index}
                src={image}
                alt={`Thumbnail ${index}`}
                className={`h-auto w-28 cursor-pointer border-2 border-transparent transition-all duration-300 hover:border-primary ${currentImageIndex === index ? "opacity-100" : "opacity-50"}`}
                onClick={() => selectImage(index)}
              />
            ))}
          </div>
        </div>

        <div className="flex w-1/2 flex-col gap-3">
          <h2 className="text-xl uppercase">{jewelryDetails.jewelryName}</h2>

          {salePrice ? (
            <span className="flex">
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(salePrice)}
              </span>
              <span className=" font-medium text-[#bababa] line-through">
                {formatCurrency(jewelryDetails.price)}
              </span>
            </span>
          ) : (
            <>
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(jewelryDetails.price)}
              </span>
            </>
          )}

          <p className="text-sm text-[#555]">
            Price may vary depending on actual product size and weight. <br />
            Please call{" "}
            <span className="font-semibold text-primary">
              (84) 098 765 321
            </span>{" "}
            for support.
          </p>

          <div className="mt-8 flex w-full gap-4">
            <Button type="button" variant={"secondary"}>
              Message
            </Button>
            <Button type="button">Add To Cart</Button>
          </div>
        </div>
      </div>

      <Section pageName={"Jewelry Details"} />

      <div className="w-full">
        <table className="w-full border-collapse">
          <tbody>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-[#888]">
                Jewelry Category
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.jewelryCategory}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2  border-input bg-slate-50 px-4 py-2 text-[#888]">
                Main Store Size
              </td>
              <td className="border-2 border-input  bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.mainStoneSize}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-[#888]">
                Side Stone Type
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.sideStoneType}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2  border-input bg-slate-50 px-4 py-2 text-[#888]">
                Side Stone Quantity
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.sideStoneQuantity}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-[#888]">
                Side Stone Weight
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.sideStoneWeight}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2  border-input bg-slate-50 px-4 py-2 text-[#888]">
                Gold Type
              </td>
              <td className="border-2 border-input  bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.goldType}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-[#888]">
                Gold Karat
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.goldKarat}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2  border-input bg-slate-50 px-4 py-2 text-[#888]">
                Gold Weight
              </td>
              <td className="border-2 border-input  bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.goldWeight}
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </>
  );
}

export default JewelryDetails;
