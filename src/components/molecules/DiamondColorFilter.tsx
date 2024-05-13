import { IDiamondColor } from "@/types/diamond.interface";
import DiamondFilter from "./DiamondFilter";

function DiamondColorFilter() {
  const colors = IDiamondColor;

  return <DiamondFilter title="Color" options={colors} />;
}

export default DiamondColorFilter;
