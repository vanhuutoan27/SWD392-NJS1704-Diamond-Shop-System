import DiamondFilter from "./DiamondFilter";
import { IDiamondClarify } from "@/types/diamond.interface";

function DiamondClarifyFilter({
  onClarifySelected,
  isResetting,
}: {
  onClarifySelected: (clarify: string) => void;
  isResetting: boolean;
}) {
  return (
    <DiamondFilter
      options={IDiamondClarify}
      onSelection={onClarifySelected}
      title="Clarify"
      isResetting={isResetting}
    />
  );
}

export default DiamondClarifyFilter;
