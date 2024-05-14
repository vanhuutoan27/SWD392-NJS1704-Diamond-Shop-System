import React from "react";
import { IDiamond } from "@/types/diamond.interface";

interface DiamondDetailProps {
  diamond: IDiamond;
}

const DiamondDetail: React.FC<DiamondDetailProps> = ({ diamond }) => {
  return (
    <div className="flex flex-wrap">
      {/* Photo and Price */}
      <div className="flex w-full">
        {/* Photo */}
        <div className="w-1/2">
          <img
            src="https://jemmia.vn/wp-content/uploads/2023/09/image-3-1.png"
            alt="Diamond"
            className="h-auto w-full"
          />
        </div>
        {/* Price */}
        <div className="w-1/2">
          <div className="mb-4 text-lg font-semibold">
            <h2>Diamond - size {diamond.size}</h2>
            Price: {diamond.price}
          </div>
        </div>
      </div>
      {/* Detailed Information */}
      <div className="my-4 w-full border-b-4 border-gray-300 pb-2 text-center">
        <h3 className="text-xl font-bold">PRODUCT DETAILS</h3>
      </div>
      <div className="w-full">
        {/* Information Table */}
        <table className="w-full border-collapse">
          <tbody>
            <tr>
              <td className="border px-4 py-2">Diamond ID</td>
              <td className="border px-4 py-2">{diamond.diamondId}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Shape</td>
              <td className="border px-4 py-2">{diamond.shape}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Weight</td>
              <td className="border px-4 py-2">{diamond.weight}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Color</td>
              <td className="border px-4 py-2">{diamond.color}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Clarity</td>
              <td className="border px-4 py-2">{diamond.clarity}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Certification</td>
              <td className="border px-4 py-2">{diamond.certification}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Size</td>
              <td className="border px-4 py-2">{diamond.size}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Fluorescence</td>
              <td className="border px-4 py-2">{diamond.fluorescence}</td>
            </tr>
            <tr>
              <td className="border px-4 py-2">Quality of Cut</td>
              <td className="border px-4 py-2">{diamond.qualityOfCut}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default DiamondDetail;
