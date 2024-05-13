import DiamondFilter from "./DiamondFilter";
import { IDiamondClarify } from "@/types/diamond.interface";

function DiamondClarifyFilter({
  onClarifySelected,
}: {
  onClarifySelected: (clarify: string) => void;
}) {
  return (
    <DiamondFilter
      options={IDiamondClarify}
      onSelection={onClarifySelected}
      title="Clarify"
    />
  );
}

export default DiamondClarifyFilter;
