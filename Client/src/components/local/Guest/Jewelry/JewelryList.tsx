import { IJewelry } from "@/types/jewelry.interface";
import ProductCard from "@/components/global/molecules/ProductCard";
import JewelryListPagination from "./JewelryListPagination";

interface JewelryListProps {
  jewelryItems: IJewelry[];
  currentPage: number;
  totalPages: number;
  setCurrentPage: (page: number) => void;
}

function JewelryList({
  jewelryItems,
  currentPage,
  totalPages,
  setCurrentPage,
}: JewelryListProps) {
  return (
    <div className="mt-10">
      <div className="grid grid-cols-1 gap-2 gap-y-8 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
        {jewelryItems.map((jewelry) => (
          <ProductCard
            key={jewelry.jewelryId}
            productId={jewelry.jewelryId}
            images={jewelry.images}
            jewelryName={jewelry.jewelryName}
            price={jewelry.price}
          />
        ))}
      </div>

      {jewelryItems.length > 0 && (
        <JewelryListPagination
          currentPage={currentPage}
          totalPages={totalPages}
          setCurrentPage={setCurrentPage}
        />
      )}
    </div>
  );
}

export default JewelryList;
