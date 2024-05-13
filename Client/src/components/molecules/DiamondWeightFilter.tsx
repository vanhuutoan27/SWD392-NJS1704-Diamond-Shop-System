import DiamondFilter from "./DiamondFilter";
import { IDiamondWeight } from "@/types/diamond.interface";

function DiamondWeightFilter({
  onWeightSelected,
}: {
  onWeightSelected: (weight: string) => void;
}) {
  return (
    <DiamondFilter
      options={IDiamondWeight}
      onSelection={onWeightSelected}
      title="Weight"
    />
  );
}

export default DiamondWeightFilter;
