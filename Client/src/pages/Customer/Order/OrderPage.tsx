import { useEffect, useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import { informationSchema } from "@/schemas/OrderForm"
import { useLocation } from "react-router-dom"

import {
  District,
  IOrderPost,
  IOrderPaymentMethod,
  Province,
  Ward
} from "@/types/order.interface"

import { usePostOrder } from "@/apis/orderApi"

import { getPaymentMethodNumber, scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import ProgressBar from "@/components/global/molecules/ProgressBar"
import Section from "@/components/global/organisms/Section"
import ConfirmOrder from "@/components/local/Customer/Order/OrderConfirmation"
import InformationForm from "@/components/local/Customer/Order/OrderInformationForm"
import PaymentForm from "@/components/local/Customer/Order/OrderPaymentForm"
import OrderSummary from "@/components/local/Customer/Order/OrderSummary"

function OrderPage() {
  const { user } = useAuthContext()
  const postOrder = usePostOrder()

  const location = useLocation()
  const { state } = location
  const { cartItems } = state || { cartItems: [] }

  const [tab, setTab] = useState(0)
  const [isSticky, setIsSticky] = useState(false)
  const [total, setTotal] = useState(0)
  const [formData, setFormData] = useState<IOrderPost>({
    products: cartItems.map((item: any) => ({
      productId: item.productId,
      quantity: item.quantity,
      unitPrice: item.price
    })),
    total: 0,
    note: "",
    receiptDay: "",
    customerId: user?.id || "",
    customerName: "",
    phone: "",
    email: "",
    address: "",
    province: "",
    district: "",
    ward: "",
    paymentMethod: IOrderPaymentMethod.BankTransfer
  })

  const [provinces, setProvinces] = useState<Province[]>([])
  const [districts, setDistricts] = useState<District[]>([])
  const [wards, setWards] = useState<Ward[]>([])
  const [errors, setErrors] = useState<any>({})
  const [selectedPaymentMethod, setSelectedPaymentMethod] =
    useState<IOrderPaymentMethod>(IOrderPaymentMethod.BankTransfer)
  const [paymentError, setPaymentError] = useState("")

  const headerHeight = 200

  useEffect(() => {
    const handleScroll = () => {
      if (window.scrollY > headerHeight) {
        setIsSticky(true)
      } else {
        setIsSticky(false)
      }
    }

    window.addEventListener("scroll", handleScroll)
    return () => {
      window.removeEventListener("scroll", handleScroll)
    }
  }, [headerHeight])

  const nextStep = async () => {
    let output = true

    if (tab === 0) {
      const validation = informationSchema.safeParse(formData)
      if (!validation.success) {
        setErrors(validation.error.format())
        output = false
      } else {
        setErrors({})
      }
    }

    if (tab === 1 && !selectedPaymentMethod) {
      setPaymentError("Please select a payment method.")
      output = false
    } else {
      setPaymentError("")
    }

    if (!output) return
    if (tab < tabs.length - 1) {
      setTab(tab + 1)
      scrollToTop()
    } else {
      const selectedProvince = provinces.find(
        (province) => province.id === formData.province
      )?.full_name
      const selectedDistrict = districts.find(
        (district) => district.id === formData.district
      )?.full_name
      const selectedWard = wards.find(
        (ward) => ward.id === formData.ward
      )?.full_name

      const fullAddress = `${formData.address}, ${selectedWard}, ${selectedDistrict}, ${selectedProvince}`

      const finalFormData: IOrderPost = {
        ...formData,
        address: fullAddress,
        total: total,
        paymentMethod: getPaymentMethodNumber(selectedPaymentMethod)
      }

      // console.log("Final form data being sent:", finalFormData)

      await postOrder.mutateAsync(finalFormData)
    }
  }

  const prevStep = () => {
    if (tab > 0) {
      setTab(tab - 1)
      scrollToTop()
    }
  }

  const getButtonText = (tab: number) => {
    switch (tab) {
      case 0:
        return "Payment Method"
      case 1:
        return "Confirm Order"
      case 2:
        return "Done"
      default:
        return "Next"
    }
  }

  const tabs = [
    { component: InformationForm, label: "Information" },
    { component: PaymentForm, label: "Payment" },
    { component: ConfirmOrder, label: "Done" }
  ]

  const CurrentForm = tabs[tab].component

  return (
    <div className="container">
      <Section pageName={"Check Out"} />

      <div className="w-3/5 pr-8">
        <ProgressBar currentStep={tab + 1} />
      </div>

      <div className="mt-16 flex w-full gap-8">
        <div className="w-3/5 rounded-md border-2 border-input bg-white p-5 shadow-md">
          <CurrentForm
            formData={formData}
            setFormData={setFormData}
            provinces={provinces}
            setProvinces={setProvinces}
            districts={districts}
            setDistricts={setDistricts}
            wards={wards}
            setWards={setWards}
            errors={errors}
            setErrors={setErrors}
            selectedPaymentMethod={selectedPaymentMethod}
            setSelectedPaymentMethod={setSelectedPaymentMethod}
            paymentError={paymentError}
            setTab={setTab}
          />
        </div>
        <div
          className={`${
            isSticky ? "top-28" : "top-0"
          } sticky h-fit w-2/5 rounded-md border-2 border-input bg-white p-5 shadow-md`}
        >
          <OrderSummary cartItems={cartItems} onTotalChange={setTotal} />
        </div>
      </div>

      <div className="mt-10 flex justify-between">
        <Button disabled={tab === 0} onClick={prevStep}>
          Back
        </Button>
        <Button onClick={nextStep}>{getButtonText(tab)}</Button>
      </div>
    </div>
  )
}

export default OrderPage
