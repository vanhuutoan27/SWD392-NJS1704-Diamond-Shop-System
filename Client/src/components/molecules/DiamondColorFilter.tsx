import DiamondFilter from "./DiamondFilter";
import { IDiamondColor } from "@/types/diamond.interface";

function DiamondColorFilter({
  onColorSelected,
}: {
  onColorSelected: (color: string) => void;
}) {
  return (
    <DiamondFilter
      options={IDiamondColor}
      onSelection={onColorSelected}
      title="Color"
    />
  );
}

export default DiamondColorFilter;
