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

function DiamondPage() {
  const [isReset, setIsReset] = useState(false);

  // States for each filter
  const [selectedShape, setSelectedShape] = useState("");
  const [selectedPrice, setSelectedPrice] = useState("");
  const [selectedWeight, setSelectedWeight] = useState("");
  const [selectedSize, setSelectedSize] = useState("");
  const [selectedColor, setSelectedColor] = useState("");
  const [selectedClarify, setSelectedClarify] = useState("");

  // Handlers for each filter
  const handlePriceSelection = (price: string) => setSelectedPrice(price);
  const handleShapeSelection = (shape: string) => setSelectedShape(shape);
  const handleWeightSelection = (weight: string) => setSelectedWeight(weight);
  const handleSizeSelection = (size: string) => setSelectedSize(size);
  const handleColorSelection = (color: string) => setSelectedColor(color);
  const handleClarifySelection = (clarify: string) =>
    setSelectedClarify(clarify);

  // Function to apply all filters
  const handleFilter = () => {
    console.log("Filtered with shape:", selectedShape);
    console.log("Filtered with price:", selectedPrice);
    console.log("Filtered with weight:", selectedWeight);
    console.log("Filtered with size:", selectedSize);
    console.log("Filtered with color:", selectedColor);
    console.log("Filtered with clarify:", selectedClarify);
  };

  // Function to reset all filters
  const handleReset = () => {
    setIsReset(true);
    setSelectedShape("");
    setSelectedPrice("");
    setSelectedWeight("");
    setSelectedSize("");
    setSelectedColor("");
    setSelectedClarify("");

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

  const data = diamondData;

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />
      <>
        <div className="relative">
          <h3 className="mb-3 w-fit border-b-4 border-primary text-xl font-semibold uppercase leading-[60px]">
            Diamond
          </h3>
          <div className="absolute inset-x-0 bottom-0 h-[2px] bg-primary" />
        </div>
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
      </>

      <div>
        <div className="relative">
          <h3 className="mb-3 w-fit border-b-4 border-primary text-xl font-semibold uppercase leading-[60px]">
            Suggested Products
          </h3>
          <div className="absolute inset-x-0 bottom-0 h-[2px] bg-primary" />
        </div>
        <div className="mb-4 flex gap-2">
          {suggestedProducts.map((product, index) => (
            <span
              key={index}
              className="cursor-pointer rounded-md border-[1px] border-slate-700 px-4 py-1 text-sm transition-all duration-300 hover:bg-primary hover:text-white"
            >
              {product}
            </span>
          ))}
        </div>
        <DataTable columns={columns} data={data} />
      </div>
    </div>
  );
}

export default DiamondPage;
