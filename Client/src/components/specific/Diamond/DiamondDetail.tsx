import { useState } from "react";
import { IDiamond } from "@/types/diamond.interface";
import { formatCurrency } from "@/lib/utils";
import Section from "../../organisms/Section";
import { Button } from "../../atoms/button";
import { X } from "lucide-react";

function DiamondDetail({ diamondDetails }: { diamondDetails: IDiamond }) {
  const [isOpen, setIsOpen] = useState(false);
  const salePrice = 100000000;

  const openModal = () => {
    setIsOpen(true);
  };

  const closeModal = () => {
    setIsOpen(false);
  };

  return (
    <div>
      <div className="flex w-full">
        <div className="w-1/2">
          <img
            src="https://jemmia.vn/wp-content/uploads/2023/09/image-3-1.png"
            alt="Diamond"
            className="h-auto w-full cursor-pointer"
            onClick={openModal}
          />
        </div>

        <div className="flex w-1/2 flex-col gap-3">
          <h2 className="text-xl uppercase">
            Natural Diamond {diamondDetails.size}mm
          </h2>

          {salePrice ? (
            <span className="flex">
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(salePrice)}
              </span>
              <span className=" font-medium text-[#bababa] line-through">
                {formatCurrency(diamondDetails.price)}
              </span>
            </span>
          ) : (
            <>
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(diamondDetails.price)}
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

      <Section pageName={"Diamond Details"} />

      <div className="w-full">
        <table className="w-full border-collapse">
          <tbody>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-[#888]">
                Shape
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.shape}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-[#888]">
                Weight
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.weight}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-[#888]">
                Color
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.color}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-[#888]">
                Clarity
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.clarity}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-[#888]">
                Certification
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.certification}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-[#888]">
                Size
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.size}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input px-4 py-2 text-[#888]">
                Fluorescence
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {diamondDetails.fluorescence}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 text-[#888]">
                Quality of Cut
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {diamondDetails.qualityOfCut}
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
              className="max-h-full max-w-full"
              src={diamondDetails.image}
              alt="Diamond"
            />
          </div>
        </div>
      )}
    </div>
  );
}

export default DiamondDetail;
