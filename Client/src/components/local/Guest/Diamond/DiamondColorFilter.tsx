import DiamondFilter from "./DiamondFilter";
import { IDiamondColor } from "@/types/diamond.interface";

function DiamondColorFilter({
  onColorSelected,
  isResetting,
}: {
  onColorSelected: (color: string) => void;
  isResetting: boolean;
}) {
  return (
    <DiamondFilter
      options={IDiamondColor}
      onSelection={onColorSelected}
      title="Color"
      isResetting={isResetting}
    />
  );
}

export default DiamondColorFilter;
