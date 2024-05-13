import { IDiamondClarify } from "@/types/diamond.interface";
import DiamondFilter from "./DiamondFilter";

function DiamondClarifyFilter() {
  const clarifies = IDiamondClarify;

  return <DiamondFilter title="Clarify" options={clarifies} />;
}

export default DiamondClarifyFilter;
