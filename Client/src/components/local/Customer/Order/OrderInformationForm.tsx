import { useEffect, useState } from "react"

import axios from "axios"

import { InformationFormProps } from "@/types/order.interface"

import { Checkbox } from "@/components/global/atoms/checkbox"
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"

const API_PROVINCES = "https://esgoo.net/api-tinhthanh/1/0.htm"
const API_DISTRICTS = (provinceId: string) =>
  `https://esgoo.net/api-tinhthanh/2/${provinceId}.htm`
const API_WARDS = (districtId: string) =>
  `https://esgoo.net/api-tinhthanh/3/${districtId}.htm`

function InformationForm({
  formData,
  setFormData,
  provinces,
  setProvinces,
  districts,
  setDistricts,
  wards,
  setWards,
  errors,
  setErrors
}: InformationFormProps) {
  const [isNoteEnabled, setIsNoteEnabled] = useState(false)

  useEffect(() => {
    axios
      .get(API_PROVINCES)
      .then((response) => {
        const data = response.data
        if (data.error === 0) {
          setProvinces(data.data)
        }
      })
      .catch((error) => console.error("Error fetching provinces:", error))
  }, [setProvinces])

  useEffect(() => {
    if (formData.province) {
      axios
        .get(API_DISTRICTS(formData.province))
        .then((response) => {
          const data = response.data
          if (data.error === 0) {
            setDistricts(data.data)
            setWards([])
          }
        })
        .catch((error) => console.error("Error fetching districts:", error))
    }
  }, [formData.province, setDistricts, setFormData, setWards])

  useEffect(() => {
    if (formData.district) {
      axios
        .get(API_WARDS(formData.district))
        .then((response) => {
          const data = response.data
          if (data.error === 0) {
            setWards(data.data)
          }
        })
        .catch((error) => console.error("Error fetching wards:", error))
    }
  }, [formData.district, setWards, setFormData])

  const clearError = (field: string) => {
    setErrors((prevErrors) => {
      const { [field]: removedError, ...restErrors } = prevErrors as any
      return restErrors
    })
  }

  return (
    <div className="flex flex-col gap-4">
      <div>
        <h4 className="mb-2 pl-4 font-semibold">Contact Information</h4>
        <input
          type="email"
          placeholder="Email"
          className="input-field"
          value={formData.email}
          onChange={(e) => {
            setFormData({ ...formData, email: e.target.value })
            clearError("email")
          }}
        />
        {errors?.email && (
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.email._errors[0]}
          </p>
        )}
      </div>

      <div>
        <h4 className="mb-2 pl-4 font-semibold">Order Information</h4>

        <div className="flex flex-col gap-2">
          <input
            type="text"
            placeholder="Full name"
            className="input-field"
            value={formData.customerName}
            onChange={(e) => {
              setFormData({ ...formData, customerName: e.target.value })
              clearError("customerName")
            }}
          />
          {errors?.customerName && (
            <p className="ml-2 pb-2 text-xs text-red-500">
              {errors.customerName._errors[0]}
            </p>
          )}
          <input
            type="text"
            placeholder="Phone number"
            className="input-field"
            value={formData.phone}
            onChange={(e) => {
              setFormData({ ...formData, phone: e.target.value })
              clearError("phone")
            }}
          />
          {errors?.phone && (
            <p className="ml-2 pb-2 text-xs text-red-500">
              {errors.phone._errors[0]}
            </p>
          )}
          <input
            type="text"
            placeholder="Address"
            className="input-field"
            value={formData.address}
            onChange={(e) => {
              setFormData({ ...formData, address: e.target.value })
              clearError("address")
            }}
          />
          {errors?.address && (
            <p className="ml-2 pb-2 text-xs text-red-500">
              {errors.address._errors[0]}
            </p>
          )}

          <div className="flex w-full justify-between gap-4">
            <div className="flex w-1/3 flex-col">
              <Select
                onValueChange={(value) => {
                  setFormData({ ...formData, province: value })
                  clearError("province")
                }}
              >
                <SelectTrigger className="input-field h-11">
                  <SelectValue placeholder="Province / City">
                    {provinces.find(
                      (province) => province.id === formData.province
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
              {errors?.province && (
                <p className="ml-2 pb-2 text-xs text-red-500">
                  {errors.province._errors[0]}
                </p>
              )}
            </div>

            <div className="flex w-1/3 flex-col">
              <Select
                onValueChange={(value) => {
                  setFormData({ ...formData, district: value })
                  clearError("district")
                }}
              >
                <SelectTrigger className="input-field h-11">
                  <SelectValue placeholder="District">
                    {districts.find(
                      (district) => district.id === formData.district
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
              {errors?.district && (
                <p className="ml-2 pb-2 text-xs text-red-500">
                  {errors.district._errors[0]}
                </p>
              )}
            </div>

            <div className="flex w-1/3 flex-col">
              <Select
                onValueChange={(value) => {
                  setFormData({ ...formData, ward: value })
                  clearError("ward")
                }}
              >
                <SelectTrigger className="input-field h-11">
                  <SelectValue placeholder="Ward / Commune">
                    {wards.find((ward) => ward.id === formData.ward)
                      ?.full_name || "Ward / Commune"}
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
              {errors?.ward && (
                <p className="ml-2 pb-2 text-xs text-red-500">
                  {errors.ward._errors[0]}
                </p>
              )}
            </div>
          </div>
        </div>
      </div>

      <div>
        <div className="flex justify-between px-4">
          <h4 className="mb-2 font-semibold">Note?</h4>
          <Checkbox
            checked={isNoteEnabled}
            onCheckedChange={(checked) => setIsNoteEnabled(!!checked)}
          />
        </div>

        <textarea
          rows={3}
          placeholder="Order notes (Optional)"
          className="input-field resize-none"
          disabled={!isNoteEnabled}
        />
      </div>
    </div>
  )
}

export default InformationForm
