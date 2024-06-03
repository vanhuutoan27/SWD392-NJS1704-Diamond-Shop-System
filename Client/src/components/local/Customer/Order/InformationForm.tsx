import { Checkbox } from "@/components/global/atoms/checkbox";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/global/atoms/select";
import axios from "axios";
import { useEffect } from "react";
import { InformationFormProps } from "@/types/order.interface";

const API_PROVINCES = "https://esgoo.net/api-tinhthanh/1/0.htm";
const API_DISTRICTS = (provinceId: string) =>
  `https://esgoo.net/api-tinhthanh/2/${provinceId}.htm`;
const API_WARDS = (districtId: string) =>
  `https://esgoo.net/api-tinhthanh/3/${districtId}.htm`;

function InformationForm({
  formData,
  setFormData,
  provinces,
  setProvinces,
  districts,
  setDistricts,
  wards,
  setWards,
}: InformationFormProps) {
  useEffect(() => {
    axios
      .get(API_PROVINCES)
      .then((response) => {
        const data = response.data;
        if (data.error === 0) {
          setProvinces(data.data);
        }
      })
      .catch((error) => console.error("Error fetching provinces:", error));
  }, [setProvinces]);

  useEffect(() => {
    if (formData.province) {
      axios
        .get(API_DISTRICTS(formData.province))
        .then((response) => {
          const data = response.data;
          if (data.error === 0) {
            setDistricts(data.data);
            setWards([]);
          }
        })
        .catch((error) => console.error("Error fetching districts:", error));
    }
  }, [formData.province, setDistricts, setFormData, setWards]);

  useEffect(() => {
    if (formData.district) {
      axios
        .get(API_WARDS(formData.district))
        .then((response) => {
          const data = response.data;
          if (data.error === 0) {
            setWards(data.data);
          }
        })
        .catch((error) => console.error("Error fetching wards:", error));
    }
  }, [formData.district, setWards, setFormData]);

  useEffect(() => {
    if (formData.province && formData.district && formData.ward) {
      const selectedProvince = provinces.find(
        (province) => province.id === formData.province,
      )?.full_name;
      const selectedDistrict = districts.find(
        (district) => district.id === formData.district,
      )?.full_name;
      const selectedWard = wards.find(
        (ward) => ward.id === formData.ward,
      )?.full_name;
      console.log(
        `${formData.address}, ${selectedWard}, ${selectedDistrict}, ${selectedProvince}`,
      );
    }
  }, [formData, provinces, districts, wards]);

  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4 font-semibold">Contact Information</h4>
        <input
          type="email"
          placeholder="Email"
          className="input-field"
          value={formData.email}
          onChange={(e) => setFormData({ ...formData, email: e.target.value })}
        />
      </div>

      <div>
        <h4 className="mb-2 pl-4 font-semibold">Order Information</h4>

        <div className="flex flex-col gap-4">
          <input
            type="text"
            placeholder="Full name"
            className="input-field"
            value={formData.fullName}
            onChange={(e) =>
              setFormData({ ...formData, fullName: e.target.value })
            }
          />
          <input
            type="number"
            placeholder="Phone number"
            className="input-field"
            value={formData.phoneNumber}
            onChange={(e) =>
              setFormData({ ...formData, phoneNumber: e.target.value })
            }
          />
          <input
            type="text"
            placeholder="Address"
            className="input-field"
            value={formData.address}
            onChange={(e) =>
              setFormData({ ...formData, address: e.target.value })
            }
          />

          <div className="flex justify-between gap-4">
            <Select
              onValueChange={(value) =>
                setFormData({ ...formData, province: value })
              }
            >
              <SelectTrigger className="input-field h-11">
                <SelectValue placeholder="Province / City">
                  {provinces.find(
                    (province) => province.id === formData.province,
                  )?.full_name || "Province / City"}
                </SelectValue>
              </SelectTrigger>
              <SelectContent>
                <SelectGroup>
                  {provinces.map((province) => (
                    <SelectItem key={province.id} value={province.id}>
                      {province.full_name}
                    </SelectItem>
                  ))}
                </SelectGroup>
              </SelectContent>
            </Select>

            <Select
              onValueChange={(value) =>
                setFormData({ ...formData, district: value })
              }
            >
              <SelectTrigger className="input-field h-11">
                <SelectValue placeholder="District">
                  {districts.find(
                    (district) => district.id === formData.district,
                  )?.full_name || "District"}
                </SelectValue>
              </SelectTrigger>
              <SelectContent>
                <SelectGroup>
                  {districts.map((district) => (
                    <SelectItem key={district.id} value={district.id}>
                      {district.full_name}
                    </SelectItem>
                  ))}
                </SelectGroup>
              </SelectContent>
            </Select>

            <Select
              onValueChange={(value) =>
                setFormData({ ...formData, ward: value })
              }
            >
              <SelectTrigger className="input-field h-11">
                <SelectValue placeholder="Ward / Commune">
                  {wards.find((ward) => ward.id === formData.ward)?.full_name ||
                    "Ward / Commune"}
                </SelectValue>
              </SelectTrigger>
              <SelectContent>
                <SelectGroup>
                  {wards.map((ward) => (
                    <SelectItem key={ward.id} value={ward.id}>
                      {ward.full_name}
                    </SelectItem>
                  ))}
                </SelectGroup>
              </SelectContent>
            </Select>
          </div>
        </div>
      </div>

      <div>
        <div className="flex justify-between px-4">
          <h4 className="mb-2 font-semibold">Ship to a different address?</h4>
          <Checkbox />
        </div>

        <textarea
          rows={3}
          placeholder="Order notes (Optional)"
          className="input-field resize-none"
        />
      </div>
    </div>
  );
}

export default InformationForm;
