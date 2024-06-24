import { IOrderPaymentMethod, PaymentFormProps } from "@/types/order.interface"

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
  const handleSelectItem = (value: IOrderPaymentMethod) => {
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

  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4 font-semibold">Shipping Information</h4>
        <div className="flex flex-col gap-4 rounded-md border-2 border-input px-5 py-4">
          <div className="text-sm">
            <p>{formData.customerName}</p>
            <p>{formData.email}</p>
            <p>{formData.phone}</p>
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
            onClick={() => handleSelectItem(IOrderPaymentMethod.Deposit500)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.Deposit500.toString()}
              checked={selectedPaymentMethod === IOrderPaymentMethod.Deposit500}
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(500000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem(IOrderPaymentMethod.Deposit1000)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.Deposit1000.toString()}
              checked={
                selectedPaymentMethod === IOrderPaymentMethod.Deposit1000
              }
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(1000000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem(IOrderPaymentMethod.Deposit1500)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.Deposit1500.toString()}
              checked={
                selectedPaymentMethod === IOrderPaymentMethod.Deposit1500
              }
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(1500000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem(IOrderPaymentMethod.Deposit2000)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.Deposit2000.toString()}
              checked={
                selectedPaymentMethod === IOrderPaymentMethod.Deposit2000
              }
            />
            <span className="ml-4 text-sm">
              Deposit {formatCurrency(2000000)}
            </span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem(IOrderPaymentMethod.BankTransfer)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.BankTransfer.toString()}
              checked={
                selectedPaymentMethod === IOrderPaymentMethod.BankTransfer
              }
            />
            <span className="ml-4 text-sm">Bank Transfer (VNPay)</span>
          </div>

          <div
            className="flex cursor-pointer items-center rounded-md border-b-2 px-5 py-4"
            onClick={() => handleSelectItem(IOrderPaymentMethod.CreditCard)}
          >
            <RadioGroupItem
              value={IOrderPaymentMethod.CreditCard.toString()}
              checked={selectedPaymentMethod === IOrderPaymentMethod.CreditCard}
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
