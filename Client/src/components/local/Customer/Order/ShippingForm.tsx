import {
  RadioGroup,
  RadioGroupItem,
} from "@/components/global/atoms/radio-group";
import { useState } from "react";
import { ShippingFormProps } from "@/types/order.interface";

function ShippingForm({
  formData,
  provinces,
  districts,
  wards,
}: ShippingFormProps) {
  const [selectItem, setSelectItem] = useState("");

  const handleSelectItem = (value: string) => {
    setSelectItem(value);
  };

  const selectedProvince = provinces.find(
    (province) => province.id === formData.province,
  )?.full_name;
  const selectedDistrict = districts.find(
    (district) => district.id === formData.district,
  )?.full_name;
  const selectedWard = wards.find(
    (ward) => ward.id === formData.ward,
  )?.full_name;

  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4 font-semibold">Shipping Information</h4>
        <div className="rounded-md border-2 border-input px-5 py-4">
          <p className="mb-1">{formData.fullName}</p>
          <p className="mb-1">{formData.email}</p>
          <p className="mb-1">{formData.phoneNumber}</p>
          <p>
            {formData.address}
            {selectedWard && `, ${selectedWard}`}
            {selectedDistrict && `, ${selectedDistrict}`}
            {selectedProvince && `, ${selectedProvince}`}
          </p>
        </div>
      </div>

      <div>
        <h4 className="mb-2 pl-4 font-semibold">Shipping Method</h4>

        <RadioGroup className="rounded-md border-2 border-input">
          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("local-pickup")}
          >
            <RadioGroupItem
              value="local-pickup"
              checked={selectItem === "local-pickup"}
            />
            <span className="ml-4">Local Pickup</span>
          </div>
          <div
            className="flex cursor-pointer items-center rounded-md px-5 py-4"
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
