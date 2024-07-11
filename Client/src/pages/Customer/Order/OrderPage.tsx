import { useEffect, useState } from "react"

import { useAuthContext } from "@/contexts/AuthContext"
import { informationSchema } from "@/schemas/OrderForm"
import axios from "axios"
import { useLocation, useNavigate } from "react-router-dom"

import {
  District,
  IOrderPaymentMethod,
  IOrderPost,
  Province,
  Ward
} from "@/types/order.interface"

import { usePostOrder } from "@/apis/orderApi"

import { getPaymentMethodNumber, scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"
import ProgressBar from "@/components/global/molecules/ProgressBar"
import Section from "@/components/global/organisms/Section"
import InformationForm from "@/components/local/Customer/Order/OrderInformationForm"
import PaymentForm from "@/components/local/Customer/Order/OrderPaymentForm"
import OrderSummary from "@/components/local/Customer/Order/OrderSummary"

function OrderPage() {
  const { user } = useAuthContext()
  const location = useLocation()
  const navigate = useNavigate()
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
    paymentMethod: IOrderPaymentMethod.CreditCard
  })

  const postOrder = usePostOrder()

  const [provinces, setProvinces] = useState<Province[]>([])
  const [districts, setDistricts] = useState<District[]>([])
  const [wards, setWards] = useState<Ward[]>([])
  const [errors, setErrors] = useState<any>({})
  const [selectedPaymentMethod, setSelectedPaymentMethod] =
    useState<IOrderPaymentMethod>(IOrderPaymentMethod.CreditCard)
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

  useEffect(() => {
    setFormData((prevData) => ({ ...prevData, total: total }))
  }, [total])

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

      console.log("Final form data being sent:", finalFormData)

      setFormData(finalFormData)

      try {
        await postOrder.mutateAsync(finalFormData)
        localStorage.setItem("orderFormData", JSON.stringify(finalFormData))
        handleShowVNPay(finalFormData)
      } catch (error) {
        console.error("Error posting order data:", error)
      }
    }
  }

  const prevStep = () => {
    if (tab > 0) {
      setTab(tab - 1)
      scrollToTop()
    }
  }

  const handleShowVNPay = async (finalFormData: IOrderPost) => {
    try {
      localStorage.setItem("orderFormData", JSON.stringify(finalFormData))
      const response = await axios.post(
        "http://localhost:8888/order/create_payment_url",
        {
          amount: finalFormData.total,
          bankCode: "VNBANK",
          language: "en"
        }
      )
      if (response.data && response.data.url) {
        window.location.href = response.data.url
      } else {
        throw new Error("Payment URL not received")
      }
    } catch (error) {
      console.error("Error creating payment URL:", error)
    }
  }

  useEffect(() => {
    const checkPaymentStatus = async () => {
      const urlParams = new URLSearchParams(window.location.search)
      const vnpResponseCode = urlParams.get("vnp_ResponseCode")

      console.log("VNPay response code:", vnpResponseCode)

      if (vnpResponseCode === "00") {
        localStorage.setItem("orderResult", "success")
      } else {
        localStorage.setItem("orderResult", "failure")
      }
      navigate("/order-confirmation")
    }

    if (window.location.pathname === "/order-confirmation") {
      checkPaymentStatus()
    }
  }, [navigate])

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
    { component: PaymentForm, label: "Payment" }
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
