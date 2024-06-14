import { useState } from "react"

import {
  IDiamondClarity,
  IDiamondColor,
  IDiamondShape,
  IDiamondSize,
  IDiamondWeight
} from "@/types/diamond.interface"

import { Button } from "@/components/global/atoms/button"
import {
  Popover,
  PopoverContent,
  PopoverTrigger
} from "@/components/global/atoms/popover"

interface FilterOptionGroupProps {
  title: string
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  options: Array<{ shapeName?: string; [key: string]: any } | string>
  selectedOption: string
  handleSelection: (value: string) => void
}

function FilterOptionGroup({
  title,
  options,
  selectedOption,
  handleSelection
}: FilterOptionGroupProps) {
  return (
    <div className="mb-4 flex flex-col">
      <h4 className="mb-1 text-sm font-semibold">{title}</h4>
      <div className="flex flex-wrap gap-3">
        <span
          className={`slow cursor-pointer rounded-md border-[1px] border-slate-700 px-7 py-1 text-sm ${
            selectedOption === ""
              ? "bg-gray-900 text-white"
              : "bg-white text-gray-900"
          }`}
          onClick={() => handleSelection("")}
        >
          All
        </span>
        {options.map((option, index) => (
          <span
            key={index}
            className={`slow cursor-pointer rounded-md border-[1px] border-slate-700 px-6 py-1 text-sm hover:bg-gray-900 hover:text-white ${
              selectedOption ===
              (typeof option === "string" ? option : option.shapeName)
                ? "bg-gray-900 text-white"
                : "bg-white text-gray-900"
            }`}
            onClick={() =>
              handleSelection(
                typeof option === "string" ? option : option.shapeName || ""
              )
            }
          >
            {typeof option === "string" ? option : option.shapeName}
          </span>
        ))}
      </div>
    </div>
  )
}

interface DiamondFilterButtonProps {
  setColumnFilters: (
    filters: Array<{ id: string; value: string | number[] }>
  ) => void
}

type Filters = {
  shape: string
  weight: string
  colorLevel: string
  clarity: string
  size: string
}

function DiamondFilterButton({ setColumnFilters }: DiamondFilterButtonProps) {
  const [filters, setFilters] = useState<Filters>({
    shape: "",
    weight: "",
    colorLevel: "",
    clarity: "",
    size: ""
  })

  const [isPopoverOpen, setIsPopoverOpen] = useState(false)

  const handleFilterClick = (key: keyof Filters, value: string) => {
    setFilters((prevFilters) => ({
      ...prevFilters,
      [key]: prevFilters[key] === value ? "" : value
    }))
  }

  const applyFilters = () => {
    const weightRange = filters.weight
      ? filters.weight === "Over 3.0"
        ? [3.0, Infinity]
        : filters.weight.split(" - ").map((w) => parseFloat(w))
      : null

    const sizeRange = filters.size
      ? filters.size === "Over 9.0"
        ? [9.0, Infinity]
        : filters.size.split(" - ").map((s) => parseFloat(s))
      : null

    const filterArray = Object.keys(filters)
      .filter((key) => filters[key as keyof Filters])
      .map((key) => ({
        id: key,
        value:
          key === "weight" && weightRange
            ? weightRange
            : key === "size" && sizeRange
              ? sizeRange
              : filters[key as keyof Filters]
      }))

    setColumnFilters(filterArray)
    setIsPopoverOpen(false) // Close the popover
  }

  const resetFilters = () => {
    setFilters({
      shape: "",
      weight: "",
      colorLevel: "",
      clarity: "",
      size: ""
    })
    setColumnFilters([])
    setIsPopoverOpen(false)
  }

  return (
    <Popover open={isPopoverOpen} onOpenChange={setIsPopoverOpen}>
      <PopoverTrigger asChild>
        <Button
          type="button"
          className="flex gap-2 bg-gray-800 hover:bg-gray-900"
        >
          Filter
        </Button>
      </PopoverTrigger>
      <PopoverContent className="mt-1 flex w-full flex-col border-2 border-input p-4 shadow-md">
        <FilterOptionGroup
          title="Shape"
          options={IDiamondShape}
          selectedOption={filters.shape}
          handleSelection={(value) => handleFilterClick("shape", value)}
        />
        <FilterOptionGroup
          title="Weight"
          options={IDiamondWeight}
          selectedOption={filters.weight}
          handleSelection={(value) => handleFilterClick("weight", value)}
        />
        <FilterOptionGroup
          title="Color"
          options={IDiamondColor}
          selectedOption={filters.colorLevel}
          handleSelection={(value) => handleFilterClick("colorLevel", value)}
        />
        <FilterOptionGroup
          title="Clarity"
          options={IDiamondClarity}
          selectedOption={filters.clarity}
          handleSelection={(value) => handleFilterClick("clarity", value)}
        />
        <FilterOptionGroup
          title="Size"
          options={IDiamondSize}
          selectedOption={filters.size}
          handleSelection={(value) => handleFilterClick("size", value)}
        />
        <div className="mt-4 flex justify-end gap-4">
          <Button type="button" variant={"secondary"} onClick={resetFilters}>
            Reset
          </Button>
          <Button
            type="button"
            className="bg-gray-800 hover:bg-gray-900"
            onClick={applyFilters}
          >
            Apply
          </Button>
        </div>
      </PopoverContent>
    </Popover>
  )
}

export default DiamondFilterButton
