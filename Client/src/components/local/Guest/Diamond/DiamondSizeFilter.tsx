import DiamondFilter from "./DiamondFilter";
import { IDiamondSize } from "@/types/diamond.interface";

function DiamondSizeFilter({
  onSizeSelected,
  isResetting,
}: {
  onSizeSelected: (size: string) => void;
  isResetting: boolean;
}) {
  return (
    <DiamondFilter
      options={IDiamondSize}
      onSelection={onSizeSelected}
      title="Size"
      isResetting={isResetting}
    />
  );
}

export default DiamondSizeFilter;
