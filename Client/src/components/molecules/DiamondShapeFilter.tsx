import { useEffect, useState } from "react";
import { IDiamondShape } from "@/types/diamond.interface";

interface DiamondShapeFilterProps {
  onShapeSelected: (shape: string) => void;
  isResetting: boolean;
}

function DiamondShapeFilter({
  onShapeSelected,
  isResetting,
}: DiamondShapeFilterProps) {
  const [selectedShape, setSelectedShape] = useState("");
  const shapes = Object.values(IDiamondShape);

  const handleShapeSelection = (shapeName: string) => {
    setSelectedShape(shapeName);
    onShapeSelected(shapeName);
  };

  useEffect(() => {
    if (isResetting) {
      setSelectedShape("");
    }
  }, [isResetting]);

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">Shape</h4>
      <div className="flex gap-3">
        {shapes.map((shape, index) => (
          <div
            key={index}
            className={`cursor-pointer overflow-hidden rounded-full border-2 p-1 transition-all duration-300 ${
              selectedShape === shape.shapeName
                ? "border-primary"
                : "border-input"
            }`}
            onClick={() => handleShapeSelection(shape.shapeName)}
          >
            <img src={shape.shapeImage} alt={shape.shapeName} width={24} />
          </div>
        ))}
      </div>
    </div>
  );
}

export default DiamondShapeFilter;
