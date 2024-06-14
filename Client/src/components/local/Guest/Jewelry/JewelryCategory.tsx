import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"

interface JewelryCategoryProps {
  setCategory: (category: string) => void
  setPriceRange: (priceRange: string) => void
  setSortOrder: (sortOrder: string) => void
}

function JewelryCategory({
  setCategory,
  setPriceRange,
  setSortOrder
}: JewelryCategoryProps) {
  return (
    <div className="mt-10 flex justify-center gap-4">
      <Select
        onValueChange={(value) => setCategory(value === "all" ? "" : value)}
      >
        <SelectTrigger className="w-[200px]">
          <SelectValue placeholder="Product Category" />
        </SelectTrigger>
        <SelectContent>
          <SelectGroup>
            <SelectItem value="all">All Categories</SelectItem>
            <SelectItem value="Earrings">Jewelry Earrings</SelectItem>
            <SelectItem value="Pendant">Jewelry Pendant</SelectItem>
            <SelectItem value="Bracelet">Jewelry Bracelet</SelectItem>
            <SelectItem value="Ring">Jewelry Ring</SelectItem>
          </SelectGroup>
        </SelectContent>
      </Select>

      <Select
        onValueChange={(value) => setPriceRange(value === "all" ? "" : value)}
      >
        <SelectTrigger className="w-[280px]">
          <SelectValue placeholder="Price Range" />
        </SelectTrigger>
        <SelectContent>
          <SelectGroup>
            <SelectItem value="all">All Price Ranges</SelectItem>
            <SelectItem value="Under 50">Under 50 Millions Dong</SelectItem>
            <SelectItem value="50-100">From 50 - 100 Millions Dong</SelectItem>
            <SelectItem value="100-200">
              From 100 - 200 Millions Dong
            </SelectItem>
            <SelectItem value="Over 200">Over 200 Millions Dong</SelectItem>
          </SelectGroup>
        </SelectContent>
      </Select>

      <Select
        onValueChange={(value) => setSortOrder(value === "all" ? "" : value)}
      >
        <SelectTrigger className="w-[200px]">
          <SelectValue placeholder="Sort" />
        </SelectTrigger>
        <SelectContent>
          <SelectGroup>
            <SelectItem value="all">All Sort Options</SelectItem>
            <SelectItem value="high-low">Price from high to low</SelectItem>
            <SelectItem value="low-high">Price from low to high</SelectItem>
          </SelectGroup>
        </SelectContent>
      </Select>
    </div>
  )
}

export default JewelryCategory
