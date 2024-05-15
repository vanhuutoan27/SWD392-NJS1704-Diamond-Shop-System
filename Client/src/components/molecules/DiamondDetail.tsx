import React, { useState } from "react";
import { IDiamond } from "@/types/diamond.interface";

interface DiamondDetailProps {
  diamond: IDiamond;
}

const DiamondDetail: React.FC<DiamondDetailProps> = ({ diamond }) => {
  const [isOpen, setIsOpen] = useState(false);

  const openModal = () => {
    setIsOpen(true);
  };

  const closeModal = () => {
    setIsOpen(false);
  };

  return (
    <div className="flex flex-wrap">
      {/* Photo and Price */}
      <div className="flex w-full">
        {/* Photo */}
        <div className="w-1/2">
          <img
            src="https://scontent.fsgn2-8.fna.fbcdn.net/v/t1.15752-9/438293785_868801961659331_1845213149564609199_n.png?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeF0SiCoQiDfyzGI2d96XDqkWoDCDAS76W9agMIMBLvpb7xPBtTjeBh0CBF76xnsTBuGjoZCT45Bianbj1Lyii06&_nc_ohc=rkriioWZrbQQ7kNvgGRIOcW&_nc_oc=AdgbLaJkkjGxG8kKNKngZf0phLAkMB8WZ9GnYeEtUMLq6-Otnk1LjBTB3jikkWhAJ0s&_nc_ht=scontent.fsgn2-8.fna&oh=03_Q7cD1QFj-A_l1mb6zSSaZwasOns1SraqpGM0C9xu2mPy87lbgA&oe=666C0340"
            alt="Diamond"
            className="h-auto w-full cursor-pointer"
            onClick={openModal}
          />
        </div>
        {/* Price */}
        <div className="w-1/2">
          <div className="mb-4 mt-10">
            <h2 className="text-3xl">Diamond - size {diamond.size}</h2>
            <h2 className="text-xl font-semibold">Price: {diamond.price}</h2>
            <p className="text-sm">
              Price may vary depending on actual product size and weight.
            </p>
            <p className="text-sm">
              Please call (84) 012 345 6789 for support.
            </p>
          </div>
        </div>
      </div>
      {/* Detailed Information */}
      <div className="my-4 w-full border-b-2 border-gray-300 pb-2 text-center">
        <h3 className="text-xl font-bold">PRODUCT DETAILS</h3>
      </div>
      <div className="w-full">
        {/* Information Table */}
        <table className="w-full border-collapse">
          <tbody>
            <tr>
              <td className="border-2 border-gray-300 px-4 py-2">Shape</td>
              <td className="border-2 border-gray-300 px-4 py-2">
                {diamond.shape}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                Weight
              </td>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                {diamond.weight}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 px-4 py-2">Color</td>
              <td className="border-2 border-gray-300 px-4 py-2">
                {diamond.color}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                Clarity
              </td>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                {diamond.clarity}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 px-4 py-2">
                Certification
              </td>
              <td className="border-2 border-gray-300 px-4 py-2">
                {diamond.certification}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                Size
              </td>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                {diamond.size}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 px-4 py-2">
                Fluorescence
              </td>
              <td className="border-2 border-gray-300 px-4 py-2">
                {diamond.fluorescence}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                Quality of Cut
              </td>
              <td className="border-2 border-gray-300 bg-gray-200 px-4 py-2">
                {diamond.qualityOfCut}
              </td>
            </tr>
          </tbody>
        </table>
      </div>

      {/* Modal */}
      {isOpen && (
        <div
          className="fixed inset-0 z-50 flex items-center justify-center bg-black bg-opacity-75"
          onClick={closeModal}
        >
          <div className="relative">
            <button
              className="absolute right-0 top-0 mr-2 mt-2 text-4xl font-bold text-white"
              onClick={closeModal}
            >
              &times;
            </button>
            <img
              className="max-h-full max-w-full"
              src="https://jemmia.vn/wp-content/uploads/2023/09/image-3-1.png"
              alt="Diamond"
            />
          </div>
        </div>
      )}
    </div>
  );
};

export default DiamondDetail;
