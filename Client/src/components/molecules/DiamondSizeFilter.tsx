import DiamondFilter from "./DiamondFilter";
import { IDiamondSize } from "@/types/diamond.interface";

function DiamondSizeFilter({
  onSizeSelected,
}: {
  onSizeSelected: (size: string) => void;
}) {
  return (
    <DiamondFilter
      options={IDiamondSize}
      onSelection={onSizeSelected}
      title="Size"
    />
  );
}

export default DiamondSizeFilter;
