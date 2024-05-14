import { useState } from "react";
import { Button } from "@/components/atoms/button";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondClarifyFilter from "@/components/molecules/DiamondClarifyFilter";
import DiamondColorFilter from "@/components/molecules/DiamondColorFilter";
import DiamondPriceFilter from "@/components/molecules/DiamondPriceFilter";
import DiamondShapeFilter from "@/components/molecules/DiamondShapeFilter";
import DiamondSizeFilter from "@/components/molecules/DiamondSizeFilter";
import DiamondWeightFilter from "@/components/molecules/DiamondWeightFilter";
import { DataTable } from "@/components/molecules/DiamondDataTable";
import { diamondData } from "@/constants/diamond";
import { columns } from "@/components/molecules/DiamondColumns";
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
  const [selectedClarify, setSelectedClarify] = useState("");

  const [filteredDiamonds, setFilteredDiamonds] = useState(diamondData);

  // Handlers for each filter
  const handlePriceSelection = (price: string) => setSelectedPrice(price);
  const handleShapeSelection = (shapes: string[]) => setSelectedShapes(shapes);
  const handleWeightSelection = (weight: string) => setSelectedWeight(weight);
  const handleSizeSelection = (size: string) => setSelectedSize(size);
  const handleColorSelection = (color: string) => setSelectedColor(color);
  const handleClarifySelection = (clarify: string) =>
    setSelectedClarify(clarify);

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

  // Function to parse and remove commas from price strings
  const parsePrice = (price: string) => {
    return parseFloat(price.replace(/\./g, ""));
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
          ? parsePrice(diamond.price) >= minPrice &&
            parsePrice(diamond.price) <= maxPrice
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
        (selectedClarify ? diamond.clarify === selectedClarify : true)
      );
    });

    setFilteredDiamonds(filteredData);
  };

  // Function to reset all filters
  const handleReset = () => {
    setIsReset(true);
    setSelectedShapes([]);
    setSelectedPrice("");
    setSelectedWeight("");
    setSelectedSize("");
    setSelectedColor("");
    setSelectedClarify("");

    setFilteredDiamonds(diamondData);

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
              <DiamondClarifyFilter
                onClarifySelected={handleClarifySelection}
                isResetting={isReset}
              />
            </div>
          </div>
          <div className="flex justify-end gap-4">
            <Button onClick={handleReset} variant="secondary">
              Reset
            </Button>
            <Button onClick={handleFilter}>Filter</Button>
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

          <DataTable columns={columns} data={filteredDiamonds} />
        </div>
      </div>
    </div>
  );
}

export default DiamondPage;
