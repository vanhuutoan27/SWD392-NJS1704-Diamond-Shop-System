import { useState } from "react";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectLabel,
  SelectTrigger,
  SelectValue,
} from "@/components/atoms/select";

function DiamondPriceFilter() {
  const [selectedPrice, setSelectedPrice] = useState("");

  const handlePriceSelection = (price) => {
    setSelectedPrice(price);
  };

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">Price Range</h4>
      <Select>
        <SelectTrigger className="w-full">
          <SelectValue placeholder="Price Range" value={selectedPrice} />
        </SelectTrigger>
        <SelectContent>
          <SelectGroup>
            <SelectLabel>Price Range</SelectLabel>
            <SelectItem
              value="Under 100"
              onClick={() => handlePriceSelection("Under 100 Millions Dong")}
            >
              Under 100 Millions Dong
            </SelectItem>
            <SelectItem
              value="100-250"
              onClick={() =>
                handlePriceSelection("From 100 - 250 Millions Dong")
              }
            >
              From 100 - 250 Millions Dong
            </SelectItem>
            <SelectItem
              value="250-500"
              onClick={() =>
                handlePriceSelection("From 250 - 500 Millions Dong")
              }
            >
              From 250 - 500 Millions Dong
            </SelectItem>
            <SelectItem
              value="Over 500"
              onClick={() => handlePriceSelection("Over 500 Millions Dong")}
            >
              Over 500 Millions Dong
            </SelectItem>
          </SelectGroup>
        </SelectContent>
      </Select>
    </div>
  );
}

export default DiamondPriceFilter;
