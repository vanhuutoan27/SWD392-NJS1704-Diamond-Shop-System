import { formatCurrency } from "@/lib/utils";
import { useState } from "react";
import { Link } from "react-router-dom";
import { Button } from "../atoms/button";

interface ProductCardProps {
  diamondId: string;
  image: string;
  image2?: string;
  size: string;
  price: number;
}

function ProductCard({
  diamondId,
  image,
  image2,
  size,
  price,
}: ProductCardProps) {
  const [isHover, setIsHover] = useState(false);

  return (
    <div className="ml-4 rounded-md border-2 border-input p-4 shadow-md">
      <Link
        to={`/diamond/${diamondId}`}
        target="_blank"
        rel="noopener noreferrer"
        className="group relative"
        onMouseEnter={() => setIsHover(true)}
        onMouseLeave={() => setIsHover(false)}
      >
        {image2 && isHover ? (
          <img src={image2} className="h-48 w-full rounded object-cover" />
        ) : (
          <img src={image} className="h-48 w-full rounded object-cover" />
        )}
        <Link
          to={`/diamond/${diamondId}`}
          target="_blank"
          rel="noopener noreferrer"
          className={`${isHover ? "opacity-1 -bottom-4" : "-bottom-6 opacity-0"} absolute left-1/2 -translate-x-1/2 transition-all duration-300`}
        >
          <Button variant={"secondary"} className="bg-white/80">
            View Details
          </Button>
        </Link>
      </Link>
      <div className="mt-8 text-center">
        <p className="mb-1 text-xs text-gray-500">{diamondId}</p>
        <p className="h-12">
          <Link
            to={`/diamond/${diamondId}`}
            target="_blank"
            rel="noopener noreferrer"
            className="mt-2 text-[14px] font-medium uppercase transition-all duration-300 hover:text-[#c69967]"
          >
            Natural Diamond - {size}mm
          </Link>
        </p>
        <div className="mt-2 flex items-center justify-center gap-2">
          <span className="text-xs font-semibold text-[#c69967]">
            {formatCurrency(price)}
          </span>
        </div>
      </div>
    </div>
  );
}

export default ProductCard;
