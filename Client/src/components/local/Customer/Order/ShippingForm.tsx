import {
  RadioGroup,
  RadioGroupItem,
} from "@/components/global/atoms/radio-group";
import { useState } from "react";

function ShippingForm() {
  const [selectItem, setSelectItem] = useState("");

  const handleSelectItem = (value: string) => {
    setSelectItem(value);
  };

  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4">Shipping Method</h4>

        <RadioGroup>
          <div
            className="flex cursor-pointer items-center rounded-md border-2 border-input px-5 py-4"
            onClick={() => handleSelectItem("local-pickup")}
          >
            <RadioGroupItem
              value="local-pickup"
              checked={selectItem === "local-pickup"}
            />
            <span className="ml-4">Local Pickup</span>
          </div>
          <div
            className="flex cursor-pointer items-center rounded-md border-2 border-input px-5 py-4"
            onClick={() => handleSelectItem("delivered-to-your-location")}
          >
            <RadioGroupItem
              value="delivered-to-your-location"
              checked={selectItem === "delivered-to-your-location"}
            />
            <span className="ml-4">Delivered To Your Location</span>
          </div>
        </RadioGroup>
      </div>
    </div>
  );
}

export default ShippingForm;
