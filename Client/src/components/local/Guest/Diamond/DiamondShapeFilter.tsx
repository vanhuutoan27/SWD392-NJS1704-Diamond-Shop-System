import { useEffect, useState } from "react"

import { IDiamondShape } from "@/types/diamond.interface"

interface DiamondShapeFilterProps {
  onShapeSelected: (shape: string[]) => void
  isResetting: boolean
}

function DiamondShapeFilter({
  onShapeSelected,
  isResetting
}: DiamondShapeFilterProps) {
  const [selectedShapes, setSelectedShapes] = useState<string[]>([])
  const shapes = Object.values(IDiamondShape)

  const handleShapeSelection = (shapeName: string) => {
    let updatedShapes
    if (selectedShapes.includes(shapeName)) {
      updatedShapes = selectedShapes.filter((shape) => shape !== shapeName)
    } else {
      updatedShapes = [...selectedShapes, shapeName]
    }
    setSelectedShapes(updatedShapes)
    onShapeSelected(updatedShapes)
  }

  useEffect(() => {
    if (isResetting) {
      setSelectedShapes([])
    }
  }, [isResetting])

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">Shape</h4>
      <div className="flex gap-3">
        {shapes.map((shape, index) => (
          <div
            key={index}
            className={`cursor-pointer overflow-hidden rounded-full border-2 p-1 slow ${
              selectedShapes.includes(shape.shapeName)
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
  )
}

export default DiamondShapeFilter
