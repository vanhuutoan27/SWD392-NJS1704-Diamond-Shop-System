import { useEffect, useState } from "react";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/atoms/select";

interface DiamondPriceFilterProps {
  onPriceSelected: (price: string) => void;
  isResetting: boolean;
}

function DiamondPriceFilter({
  onPriceSelected,
  isResetting,
}: DiamondPriceFilterProps) {
  const [selectedPrice, setSelectedPrice] = useState("");

  const handlePriceSelection = (price: string) => {
    setSelectedPrice(price);
    onPriceSelected(price);
  };

  useEffect(() => {
    if (isResetting) {
      setSelectedPrice("");
    }
  }, [isResetting]);

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">Price Range</h4>
      <Select value={selectedPrice} onValueChange={handlePriceSelection}>
        <SelectTrigger className="w-full">
          <SelectValue placeholder={selectedPrice || "Price Range"} />
        </SelectTrigger>
        <SelectContent>
          <SelectGroup>
            <SelectItem value="Under 100">Under 100 Millions Dong</SelectItem>
            <SelectItem value="100-250">
              From 100 - 250 Millions Dong
            </SelectItem>
            <SelectItem value="250-500">
              From 250 - 500 Millions Dong
            </SelectItem>
            <SelectItem value="Over 500">Over 500 Millions Dong</SelectItem>
          </SelectGroup>
        </SelectContent>
      </Select>
    </div>
  );
}

export default DiamondPriceFilter;
