import React from "react";
import { CircleArrowRight } from "lucide-react";

const QualityCommitments: React.FC = () => {
  return (
    <div className="mt-20">
      <div className="my-4 w-full border-b-2 border-gray-300 pb-2 text-center">
        <h3 className="text-xl font-bold">QUANLITY COMMITMENTS</h3>
      </div>

      <ul className="space-y-4">
        <li className="flex items-start">
          <CircleArrowRight />
          <span className="ml-5">
            Diamond at DIAMOON is selected with strict standards.
          </span>
        </li>
        <li className="flex items-start">
          <CircleArrowRight />
          <span className="ml-5">
            Diamonds are imported officially, ensuring customer assets are safe.
          </span>
        </li>
        <li className="flex items-start">
          <CircleArrowRight />
          <span className="ml-5">
            All diamond products at DIAMOON have full invoices and documents
            proving their origin.
          </span>
        </li>
        <li className="flex items-start">
          <CircleArrowRight />
          <span className="ml-5">
            Free cleaning and maintenance for lifetime.
          </span>
        </li>
        <li className="flex items-start">
          <CircleArrowRight />
          <span className="ml-5">
            Reasonable purchasing and exchange policy, lifetime warranty policy
            for all diamond products at DIAMOON.
          </span>
        </li>
      </ul>
    </div>
  );
};

export default QualityCommitments;
