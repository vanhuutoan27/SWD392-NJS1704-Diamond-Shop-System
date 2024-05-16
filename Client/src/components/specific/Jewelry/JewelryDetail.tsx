import { useState } from "react";
import { IJewelry } from "@/types/jewelry.interface";
import { formatCurrency } from "@/lib/utils";
import Section from "../../organisms/Section";
import { Button } from "../../atoms/button";
import { X } from "lucide-react";

function JewelryDetail({ jewelryDetails }: { jewelryDetails: IJewelry }) {
  const [isOpen, setIsOpen] = useState(false);
  const salePrice = 100000000;
  const [currentImageIndex, setCurrentImageIndex] = useState(0);
  const images = [jewelryDetails.image, jewelryDetails.image2];
  const [isHovered, setIsHovered] = useState(false);
  const openModal = () => {
    setIsOpen(true);
  };

  const closeModal = () => {
    setIsOpen(false);
  };

  const nextImage = () => {
    setCurrentImageIndex((prevIndex) => (prevIndex + 1) % images.length);
  };

  const prevImage = () => {
    setCurrentImageIndex((prevIndex) =>
      prevIndex === 0 ? images.length - 1 : prevIndex - 1,
    );
  };

  return (
    <div>
      <div className="flex w-full">
        <div
          className="relative w-1/2"
          onMouseEnter={() => setIsHovered(true)}
          onMouseLeave={() => setIsHovered(false)}
        >
          <img
            src={images[currentImageIndex]}
            alt="Jewelry"
            className="h-auto w-full cursor-pointer"
            onClick={openModal}
          />
          {images.length > 1 && isHovered && (
            <>
              <button
                onClick={prevImage}
                className="absolute left-5 top-1/2 h-full w-10 -translate-y-1/2 text-black"
              >
                <p className="text-3xl font-medium">{"<"}</p>
              </button>
              <button
                onClick={nextImage}
                className="absolute right-5 top-1/2 h-full w-10 -translate-y-1/2 text-black"
              >
                <p className="text-3xl font-medium">{">"}</p>
              </button>
            </>
          )}
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

      {isOpen && (
        <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/75">
          <div className="relative">
            <X
              onClick={closeModal}
              className="absolute right-0 top-0 mr-2 mt-2 cursor-pointer text-black transition-all duration-300 hover:text-[#888]"
            />

            <img
              className="max-h-[596px]"
              src={images[currentImageIndex]}
              alt="Diamond"
            />
            {images.length > 1 && (
              <>
                <button
                  onClick={prevImage}
                  className="absolute -left-20 top-1/2 h-10 w-10 -translate-y-1/2 rounded-full bg-slate-950 text-white"
                >
                  <p className=" text-center text-xl">{"<"}</p>
                </button>

                <button
                  onClick={nextImage}
                  className="absolute -right-20 top-1/2 h-10 w-10 -translate-y-1/2 rounded-full bg-slate-950 text-white"
                >
                  <p className=" text-center text-xl">{">"}</p>
                </button>
              </>
            )}
          </div>
        </div>
      )}
    </div>
  );
}

export default JewelryDetail;
