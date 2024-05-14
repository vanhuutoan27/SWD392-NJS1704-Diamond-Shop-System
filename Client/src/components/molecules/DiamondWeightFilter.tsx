import DiamondFilter from "./DiamondFilter";
import { IDiamondWeight } from "@/types/diamond.interface";

function DiamondWeightFilter({
  onWeightSelected,
  isResetting,
}: {
  onWeightSelected: (weight: string) => void;
  isResetting: boolean;
}) {
  return (
    <DiamondFilter
      options={IDiamondWeight}
      onSelection={onWeightSelected}
      title="Weight"
      isResetting={isResetting}
    />
  );
}

export default DiamondWeightFilter;
