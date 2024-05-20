import Section from "@/components/organisms/Section";
import { CircleCheckBig } from "lucide-react";

function BuyingGuide() {
  return (
    <div className="mt-10">
      <Section pageName={"Buying Guide"} />

      <ul className="space-y-4">
        <li className="flex items-start text-secondary">
          <CircleCheckBig className="text-red-500" />
          <span className="ml-5">
            <span className="font-semibold">Method 1:</span> Please click the
            "send message" button or contact Hotline{" "}
            <span className="font-semibold">0987.654.321</span>, meet directly
            with a customer care specialist for advice and to order products.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <CircleCheckBig className="text-red-500" />
          <span className="ml-5">
            <span className="font-semibold">Method 2:</span> Please click the
            "add to cart" button, select checkout to complete providing
            information, pay for products and place your order.
          </span>
        </li>
      </ul>
    </div>
  );
}

export default BuyingGuide;
