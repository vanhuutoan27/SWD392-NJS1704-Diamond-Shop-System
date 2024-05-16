import { useState } from "react";
import { Button } from "@/components/atoms/button";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondClarityFilter from "@/components/specific/Diamond/DiamondClarityFilter";
import DiamondColorFilter from "@/components/specific/Diamond/DiamondColorFilter";
import DiamondPriceFilter from "@/components/specific/Diamond/DiamondPriceFilter";
import DiamondShapeFilter from "@/components/specific/Diamond/DiamondShapeFilter";
import DiamondSizeFilter from "@/components/specific/Diamond/DiamondSizeFilter";
import DiamondWeightFilter from "@/components/specific/Diamond/DiamondWeightFilter";
import { DataTable } from "@/components/specific/Diamond/DiamondDataTable";
import { diamondData } from "@/constants/diamond";
import { columns } from "@/components/specific/Diamond/DiamondColumns";
import Section from "@/components/organisms/Section";
import Chip from "@/components/atoms/Chip";

function DiamondPage() {
  const [isReset, setIsReset] = useState(false);

  // States for each filter
  const [selectedShapes, setSelectedShapes] = useState<string[]>([]);
  const [selectedPrice, setSelectedPrice] = useState("");
  const [selectedWeight, setSelectedWeight] = useState("");
  const [selectedSize, setSelectedSize] = useState("");
  const [selectedColor, setSelectedColor] = useState("");
  const [selectedClarity, setSelectedClarity] = useState("");

  const [filteredDiamonds, setFilteredDiamonds] = useState(diamondData);
  const [rowsToShow, setRowsToShow] = useState(5);

  // Handlers for each filter
  const handlePriceSelection = (price: string) =>
    setSelectedPrice(price.toString());
  const handleShapeSelection = (shapes: string[]) => setSelectedShapes(shapes);
  const handleWeightSelection = (weight: string) => setSelectedWeight(weight);
  const handleSizeSelection = (size: string) => setSelectedSize(size);
  const handleColorSelection = (color: string) => setSelectedColor(color);
  const handleClaritySelection = (clarity: string) =>
    setSelectedClarity(clarity);

  const handleShowMore = () => {
    setRowsToShow((prev) => prev + 5);
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
    const filteredData = diamondData.filter((diamond) => {
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
          ? parseFloat(diamond.weight) >= minWeight &&
            parseFloat(diamond.weight) <= maxWeight
          : true) &&
        (selectedSize
          ? parseFloat(diamond.size) >= minSize &&
            parseFloat(diamond.size) <= maxSize
          : true) &&
        (selectedColor ? diamond.color === selectedColor : true) &&
        (selectedClarity ? diamond.clarity === selectedClarity : true)
      );
    });

    setFilteredDiamonds(filteredData);
    setRowsToShow(5);
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

    setFilteredDiamonds(diamondData);
    setRowsToShow(5);

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

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />
      <div>
        <Section pageName={"Diamond"} />

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
        <div />

        <div>
          <Section pageName={"All diamonds are available"} />

          <div className="mb-4 flex gap-2">
            {suggestedProducts.map((product, index) => (
              <Chip key={index} content={product} />
            ))}
          </div>

          <DataTable
            columns={columns}
            data={filteredDiamonds.slice(0, rowsToShow)}
          />

          {filteredDiamonds.length > rowsToShow && (
            <div className="mt-8 flex items-center justify-center gap-4">
              <p className="text-sm text-[#888]">
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
