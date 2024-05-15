import { formatCurrency } from "@/lib/utils";
import { Link } from "react-router-dom";

interface ProductCardProps {
  diamondId: string;
  image: string;
  size: string;
  price: number;
}

function ProductCard({ diamondId, image, size, price }: ProductCardProps) {
  return (
    <div className="rounded-md border-2 border-input p-4 shadow-md">
      <Link
        to={`/diamond/${diamondId}`}
        target="_blank"
        rel="noopener noreferrer"
      >
        <img src={image} className="h-48 w-full rounded object-cover" />
      </Link>
      <div className="mt-4 text-center">
        <p className="text-xs text-gray-500">{diamondId}</p>
        <p className="h-12">
          <Link
            to={`/diamond/${diamondId}`}
            target="_blank"
            rel="noopener noreferrer"
            className="mt-2 text-[14px] font-medium transition-all duration-300 hover:text-[#c69967]"
          >
            KIM CƯƠNG TỰ NHIÊN - {size}MM
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
