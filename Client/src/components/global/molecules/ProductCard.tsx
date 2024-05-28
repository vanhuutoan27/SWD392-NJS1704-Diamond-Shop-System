import { formatCurrency } from "@/lib/utils";
import { useState } from "react";
import { Link } from "react-router-dom";
import { Button } from "../atoms/button";

interface ProductCardProps {
  productId: string;
  image: string;
  image2?: string;
  size?: number;
  price: number;
  jewelryName?: string;
}

function ProductCard({
  productId,
  image,
  image2,
  size,
  price,
  jewelryName,
}: ProductCardProps) {
  const [isHover, setIsHover] = useState(false);

  const shortProductId = productId.split("-")[0];

  return (
    <div className="ml-4 rounded-lg border-2 border-input p-4 shadow-md">
      {size ? (
        <Link
          to={`/diamond/${productId}`}
          target="_blank"
          rel="noopener noreferrer"
          className="group relative"
          onMouseEnter={() => setIsHover(true)}
          onMouseLeave={() => setIsHover(false)}
        >
          <img
            src={
              image ||
              "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6"
            }
            className="h-48 w-full rounded object-cover"
          />
          <Link
            to={`/diamond/${productId}`}
            target="_blank"
            rel="noopener noreferrer"
            className={`${isHover ? "opacity-1" : "opacity-0"} slow absolute -bottom-6 left-1/2 -translate-x-1/2`}
          >
            <Button variant={"secondary"} className="bg-white/80">
              View Details
            </Button>
          </Link>
        </Link>
      ) : (
        <div
          className="group relative cursor-pointer"
          onMouseEnter={() => setIsHover(true)}
          onMouseLeave={() => setIsHover(false)}
        >
          {isHover ? (
            <img src={image2} className="h-48 w-full rounded object-cover" />
          ) : (
            <img src={image} className="h-48 w-full rounded object-cover" />
          )}
          <Link
            to={`/jewelry/${productId}`}
            target="_blank"
            rel="noopener noreferrer"
            className={`${isHover ? "opacity-1" : "opacity-0"} slow absolute -bottom-6 left-1/2 -translate-x-1/2`}
          >
            <Button variant={"secondary"} className="bg-white/80">
              View Details
            </Button>
          </Link>
        </div>
      )}
      <div className="mt-8 text-center">
        <p className="mb-1 text-xs text-gray-500">{shortProductId}</p>
        <p className="h-12">
          {size ? (
            <Link
              to={`/diamond/${productId}`}
              target="_blank"
              rel="noopener noreferrer"
              className="slow mt-2 text-[14px] font-medium uppercase hover:text-[#c69967]"
            >
              Natural Diamond - {size}mm
            </Link>
          ) : (
            <Link
              to={`/jewelry/${productId}`}
              target="_blank"
              rel="noopener noreferrer"
              className="slow mt-2 text-[14px] font-medium uppercase hover:text-[#c69967]"
            >
              {jewelryName}
            </Link>
          )}
        </p>
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
