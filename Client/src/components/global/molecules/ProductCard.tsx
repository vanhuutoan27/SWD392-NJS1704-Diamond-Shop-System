import { useState } from "react";
import { Link } from "react-router-dom";
import { formatCurrency } from "@/lib/utils";
import { Button } from "../atoms/button";
import { diamondImage } from "@/lib/constants";

interface ProductCardProps {
  productId: string;
  image?: string;
  images?: string[];
  size?: number;
  price: number;
  jewelryName?: string;
}

function ProductCard({
  productId,
  image,
  images,
  size,
  price,
  jewelryName,
}: ProductCardProps) {
  const [isHover, setIsHover] = useState(false);

  const shortProductId = productId.split("-")[0];

  const renderImage = () => {
    if (image) {
      // Render single image for diamond
      return (
        <img src={diamondImage} className="h-48 w-full rounded object-cover" />
      );
    } else if (images && images.length > 0) {
      // Render hover effect for jewelry images
      return (
        <>
          {isHover ? (
            <img src={images[1]} className="h-48 w-full rounded object-cover" />
          ) : (
            <img src={images[0]} className="h-48 w-full rounded object-cover" />
          )}
        </>
      );
    }
  };

  const renderLink = () => {
    const href = size ? `/diamond/${productId}` : `/jewelry/${productId}`;
    const linkText = size
      ? `Natural Diamond - ${size}mm`
      : jewelryName || "View Details";

    return (
      <Link
        to={href}
        target="_blank"
        rel="noopener noreferrer"
        className="slow mt-2 text-[14px] font-medium uppercase hover:text-[#c69967]"
      >
        {linkText}
      </Link>
    );
  };

  return (
    <div className="ml-4 rounded-lg border-2 border-input p-4 shadow-md">
      <div
        className="group relative cursor-pointer"
        onMouseEnter={() => setIsHover(true)}
        onMouseLeave={() => setIsHover(false)}
      >
        {renderImage()}
        <Link
          to={size ? `/diamond/${productId}` : `/jewelry/${productId}`}
          target="_blank"
          rel="noopener noreferrer"
          className={`${
            isHover ? "opacity-1" : "opacity-0"
          } slow absolute -bottom-6 left-1/2 -translate-x-1/2`}
        >
          <Button variant={"secondary"} className="bg-white/80">
            View Details
          </Button>
        </Link>
      </div>
      <div className="mt-8 text-center">
        <p className="mb-1 text-xs text-gray-500">{shortProductId}</p>
        <p className="h-7">{renderLink()}</p>
        <div className="mt-2 flex items-center justify-center gap-2">
          <span className="text-[13px] font-semibold text-[#c69967]">
            {formatCurrency(price)}
          </span>
        </div>
      </div>
    </div>
  );
}

export default ProductCard;
