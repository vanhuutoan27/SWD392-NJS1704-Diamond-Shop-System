import { IDiamondWeight } from "@/types/diamond.interface";
import DiamondFilter from "./DiamondFilter";

function DiamondWeightFilter() {
  const weights = IDiamondWeight;

  return <DiamondFilter title="Weight" options={weights} />;
}

export default DiamondWeightFilter;
