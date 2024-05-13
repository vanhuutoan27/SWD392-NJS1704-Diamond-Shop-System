import { IDiamondShape } from "@/types/diamond.interface";
import { useState } from "react";

function DiamondShapeFilter() {
  const shapes = Object.values(IDiamondShape);
  const [selectedShape, setSelectedShape] = useState("");

  const handleShapeSelection = (shapeName: string) => {
    setSelectedShape(shapeName);
  };

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">Shape</h4>
      <div className="flex gap-3">
        {shapes.map((shape, index) => {
          return (
            <div
              key={index}
              className={`cursor-pointer overflow-hidden rounded-full border-2 p-1 transition-all duration-200 ${
                selectedShape === shape.shapeName
                  ? "border-primary"
                  : "border-input"
              }`}
              onClick={() => handleShapeSelection(shape.shapeName)}
            >
              <img src={shape.shapeImage} alt={shape.shapeName} width={24} />
            </div>
          );
        })}
      </div>
    </div>
  );
}

export default DiamondShapeFilter;
