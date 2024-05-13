import { IDiamondSize } from "@/types/diamond.interface";
import DiamondFilter from "./DiamondFilter";

function DiamondSizeFilter() {
  const sizes = IDiamondSize;

  return <DiamondFilter title="Size" options={sizes} />;
}

export default DiamondSizeFilter;
