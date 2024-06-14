import { IDiamondWeight } from "@/types/diamond.interface"

import DiamondFilter from "./DiamondFilter"

function DiamondWeightFilter({
  onWeightSelected,
  isResetting
}: {
  onWeightSelected: (weight: string) => void
  isResetting: boolean
}) {
  return (
    <DiamondFilter
      options={IDiamondWeight}
      onSelection={onWeightSelected}
      title="Weight"
      isResetting={isResetting}
    />
  )
}

export default DiamondWeightFilter
