import DiamondFilter from "./DiamondFilter";
import { IDiamondClarity } from "@/types/diamond.interface";

function DiamondClarityFilter({
  onClaritySelected,
  isResetting,
}: {
  onClaritySelected: (clarity: string) => void;
  isResetting: boolean;
}) {
  return (
    <DiamondFilter
      options={IDiamondClarity}
      onSelection={onClaritySelected}
      title="Clarity"
      isResetting={isResetting}
    />
  );
}

export default DiamondClarityFilter;
