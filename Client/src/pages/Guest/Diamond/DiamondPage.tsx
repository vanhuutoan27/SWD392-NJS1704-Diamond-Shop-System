import { useState, useEffect } from "react";
import { Button } from "@/components/global/atoms/button";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import DiamondClarityFilter from "@/components/local/Guest/Diamond/DiamondClarityFilter";
import DiamondColorFilter from "@/components/local/Guest/Diamond/DiamondColorFilter";
import DiamondPriceFilter from "@/components/local/Guest/Diamond/DiamondPriceFilter";
import DiamondShapeFilter from "@/components/local/Guest/Diamond/DiamondShapeFilter";
import DiamondSizeFilter from "@/components/local/Guest/Diamond/DiamondSizeFilter";
import DiamondWeightFilter from "@/components/local/Guest/Diamond/DiamondWeightFilter";
import { DataTable } from "@/components/local/Guest/Diamond/DiamondDataTable";
import { columns } from "@/components/local/Guest/Diamond/DiamondColumns";
import Section from "@/components/global/organisms/Section";
import { toast } from "sonner";
import { Loader } from "@/components/global/atoms/Loader";
import { IDiamond } from "@/types/diamond.interface";
import { useGetAllDiamonds } from "@/api/diamondApi";

function DiamondPage() {
  const { data: diamondData, error, isLoading } = useGetAllDiamonds();
  const [isReset, setIsReset] = useState(false);

  // States for each filter
  const [selectedShapes, setSelectedShapes] = useState<string[]>([]);
  const [selectedPrice, setSelectedPrice] = useState("");
  const [selectedWeight, setSelectedWeight] = useState("");
  const [selectedSize, setSelectedSize] = useState("");
  const [selectedColor, setSelectedColor] = useState("");
  const [selectedClarity, setSelectedClarity] = useState("");

  const [filteredDiamonds, setFilteredDiamonds] = useState<IDiamond[]>([]);
  const [rowsToShow, setRowsToShow] = useState(10);

  useEffect(() => {
    if (diamondData) {
      setFilteredDiamonds(diamondData);
    }
  }, [diamondData]);

  if (error) {
    toast.error("Failed to fetch diamonds");
  }

  const handlePriceSelection = (price: string) => setSelectedPrice(price);
  const handleShapeSelection = (shapes: string[]) => setSelectedShapes(shapes);
  const handleWeightSelection = (weight: string) => setSelectedWeight(weight);
  const handleSizeSelection = (size: string) => setSelectedSize(size);
  const handleColorSelection = (color: string) => setSelectedColor(color);
  const handleClaritySelection = (clarity: string) =>
    setSelectedClarity(clarity);

  const handleShowMore = () => {
    setRowsToShow((prev) => prev + 10);
  };

  // Function to parse price range
  const parsePriceRange = (range: string) => {
    if (range === "Under 100") {
      return { min: 0, max: 100 * 1_000_000 };
    }
    if (range === "Over 500") {
      return { min: 500 * 1_000_000, max: Infinity };
    }
    const [min, max] = range
      .split("-")
      .map((value) => parseFloat(value.trim()) * 1_000_000);
    return { min, max };
  };

  // Function to parse weight range
  const parseWeightRange = (range: string) => {
    if (range === "Over 3.0") {
      return { min: 3.0, max: Infinity };
    }
    const [min, max] = range.split(" - ").map(parseFloat);
    return { min, max: max || Infinity };
  };

  // Function to parse size range
  const parseSizeRange = (range: string) => {
    if (range === "Over 9.0") {
      return { min: 9.0, max: Infinity };
    }
    const [min, max] = range.split(" - ").map(parseFloat);
    return { min, max: max || Infinity };
  };

  // Function to apply all filters
  const handleFilter = () => {
    const filteredData = diamondData?.filter((diamond: IDiamond) => {
      const { min: minPrice, max: maxPrice } = selectedPrice
        ? parsePriceRange(selectedPrice)
        : { min: -Infinity, max: Infinity };
      const { min: minWeight, max: maxWeight } = selectedWeight
        ? parseWeightRange(selectedWeight)
        : { min: -Infinity, max: Infinity };
      const { min: minSize, max: maxSize } = selectedSize
        ? parseSizeRange(selectedSize)
        : { min: -Infinity, max: Infinity };

      return (
        (selectedShapes.length
          ? selectedShapes.includes(diamond.shape)
          : true) &&
        (selectedPrice
          ? diamond.price >= minPrice && diamond.price <= maxPrice
          : true) &&
        (selectedWeight
          ? diamond.weight >= minWeight && diamond.weight <= maxWeight
          : true) &&
        (selectedSize
          ? diamond.size >= minSize && diamond.size <= maxSize
          : true) &&
        (selectedColor ? diamond.colorLevel === selectedColor : true) &&
        (selectedClarity ? diamond.clarity === selectedClarity : true)
      );
    });

    setFilteredDiamonds(filteredData || []);
    setRowsToShow(10);
  };

  // Function to reset all filters
  const handleReset = () => {
    setIsReset(true);
    setSelectedShapes([]);
    setSelectedPrice("");
    setSelectedWeight("");
    setSelectedSize("");
    setSelectedColor("");
    setSelectedClarity("");

    setFilteredDiamonds(diamondData || []);
    setRowsToShow(10);

    setTimeout(() => {
      setIsReset(false);
    }, 300);
  };

  const suggestedProducts = [
    "D-IF-6.3",
    "D-VS1-5.4",
    "D-VVS1-5.0",
    "D-VS2-4.4",
  ];

  if (isLoading) {
    return <Loader />;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />

      <div>
        <Section pageName={"Diamonds"} />

        <div className="flex flex-col gap-8">
          <div className="flex w-full justify-between gap-10">
            <div className="flex w-1/4 flex-col gap-4">
              <DiamondShapeFilter
                onShapeSelected={handleShapeSelection}
                isResetting={isReset}
              />
              <DiamondPriceFilter
                onPriceSelected={handlePriceSelection}
                isResetting={isReset}
              />
            </div>
            <div className="flex w-3/4 flex-col gap-2">
              <DiamondWeightFilter
                onWeightSelected={handleWeightSelection}
                isResetting={isReset}
              />
              <DiamondSizeFilter
                onSizeSelected={handleSizeSelection}
                isResetting={isReset}
              />
              <DiamondColorFilter
                onColorSelected={handleColorSelection}
                isResetting={isReset}
              />
              <DiamondClarityFilter
                onClaritySelected={handleClaritySelection}
                isResetting={isReset}
              />
            </div>
          </div>
          <div className="flex justify-end gap-4">
            <Button type="button" onClick={handleReset} variant="secondary">
              Reset
            </Button>
            <Button type="button" onClick={handleFilter}>
              Filter
            </Button>
          </div>
        </div>

        <div>
          <Section pageName={"All diamonds are available"} />

          <div className="mb-4 flex gap-2">
            {suggestedProducts.map((product, index) => (
              <div
                key={index}
                className="slow cursor-pointer rounded-md border-[1px] border-slate-700 px-4 py-1 text-sm font-medium hover:bg-primary hover:text-white"
              >
                {product}
              </div>
            ))}
          </div>

          <DataTable
            columns={columns}
            data={filteredDiamonds.slice(0, rowsToShow)}
          />

          {filteredDiamonds.length > rowsToShow && (
            <div className="mt-8 flex items-center justify-center gap-4">
              <p className="text-sm text-secondary">
                Showing {Math.min(rowsToShow, filteredDiamonds.length)} of{" "}
                {filteredDiamonds.length}
              </p>
              <Button onClick={handleShowMore}>Show More</Button>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}

export default DiamondPage;
