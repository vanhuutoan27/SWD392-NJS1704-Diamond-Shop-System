import { IDiamondClarity } from "@/types/diamond.interface"

import DiamondFilter from "./DiamondFilter"

function DiamondClarityFilter({
  onClaritySelected,
  isResetting
}: {
  onClaritySelected: (clarity: string) => void
  isResetting: boolean
}) {
  return (
    <DiamondFilter
      options={IDiamondClarity}
      onSelection={onClaritySelected}
      title="Clarity"
      isResetting={isResetting}
    />
  )
}

export default DiamondClarityFilter
