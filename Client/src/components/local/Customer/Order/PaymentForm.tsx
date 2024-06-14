import { useEffect } from "react"

import { PaymentFormProps } from "@/types/order.interface"

import { formatCurrency } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import {
  RadioGroup,
  RadioGroupItem
} from "@/components/global/atoms/radio-group"

function PaymentForm({
  formData,
  provinces,
  districts,
  wards,
  selectedPaymentMethod,
  setSelectedPaymentMethod,
  paymentError,
  setTab
}: PaymentFormProps) {
  const handleSelectItem = (value: string) => {
    setSelectedPaymentMethod(value)
  }

  const selectedProvince = provinces.find(
    (province) => province.id === formData.province
  )?.full_name
  const selectedDistrict = districts.find(
    (district) => district.id === formData.district
  )?.full_name
  const selectedWard = wards.find(
    (ward) => ward.id === formData.ward
  )?.full_name

  useEffect(() => {
    console.log("Selected payment method:", selectedPaymentMethod)
  }, [selectedPaymentMethod])

  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4 font-semibold">Shipping Information</h4>
        <div className="flex flex-col gap-4 rounded-md border-2 border-input px-5 py-4">
          <div className="text-sm">
            <p>{formData.fullName}</p>
            <p>{formData.email}</p>
            <p>{formData.phoneNumber}</p>
            <p>
              {formData.address}
              {selectedWard && `, ${selectedWard}`}
              {selectedDistrict && `, ${selectedDistrict}`}
              {selectedProvince && `, ${selectedProvince}`}
            </p>
          </div>

          <Button type="button" variant={"secondary"} onClick={() => setTab(0)}>
            Change Information
          </Button>
        </div>
      </div>

      <div>
        <h4 className="mb-2 pl-4 font-semibold">Payment Method</h4>

        <RadioGroup className="rounded-md border-2 border-input">
          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("deposit-500")}
          >
            <RadioGroupItem
              value="deposit-500"
              checked={selectedPaymentMethod === "deposit-500"}
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(500000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("deposit-1000")}
          >
            <RadioGroupItem
              value="deposit-1000"
              checked={selectedPaymentMethod === "deposit-1000"}
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(1000000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("deposit-1500")}
          >
            <RadioGroupItem
              value="deposit-1500"
              checked={selectedPaymentMethod === "deposit-1500"}
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(1500000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("deposit-2000")}
          >
            <RadioGroupItem
              value="deposit-2000"
              checked={selectedPaymentMethod === "deposit-2000"}
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(2000000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("bank-transfer")}
          >
            <RadioGroupItem
              value="bank-transfer"
              checked={selectedPaymentMethod === "bank-transfer"}
            />
            <span className="ml-4 text-sm">Bank Transfer (VNPay)</span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem("credit-card")}
          >
            <RadioGroupItem
              value="credit-card"
              checked={selectedPaymentMethod === "credit-card"}
            />
            <span className="ml-4 text-sm">Credit Card</span>
          </div>
        </RadioGroup>
        {paymentError && (
          <p className="ml-2 pt-2 text-sm text-red-500">{paymentError}</p>
        )}
      </div>
    </div>
  )
}

export default PaymentForm
