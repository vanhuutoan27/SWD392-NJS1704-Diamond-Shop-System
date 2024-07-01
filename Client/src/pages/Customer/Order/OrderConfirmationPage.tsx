import { useEffect, useState } from "react"

import { Link, useNavigate } from "react-router-dom"

import { scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

function OrderConfirmation() {
  const navigate = useNavigate()
  const [loading, setLoading] = useState(true)
  const [message, setMessage] = useState("")

  useEffect(() => {
    const handleOrder = () => {
      const orderResult = localStorage.getItem("orderResult")
      const orderFormData = localStorage.getItem("orderFormData")

      console.log("Order result:", orderResult)
      console.log("Order form data:", orderFormData)

      if (orderResult === "success" && orderFormData) {
        setMessage("Order placed successfully!")
      } else {
        setMessage("Payment failed or canceled.")
      }

      localStorage.removeItem("orderFormData")
      localStorage.removeItem("orderResult")
      setLoading(false)
    }

    handleOrder()
  }, [])

  const goToHome = () => {
    navigate("/")
    setTimeout(scrollToTop, 100)
  }

  return (
    <div className="flex w-full select-none items-center justify-center bg-white">
      <div className="text-center">
        {loading ? (
          <h1 className="mt-4 text-3xl font-bold tracking-tight text-gray-900 sm:text-5xl">
            Processing your payment...
          </h1>
        ) : (
          <>
            <p className="text-base font-semibold text-primary">VNPay</p>
            <h1 className="mt-4 text-3xl font-bold tracking-tight text-gray-900 sm:text-5xl">
              {message}
            </h1>
            <div className="mt-10 flex items-center justify-center gap-4">
              <Button type="button" variant="secondary" onClick={goToHome}>
                Home Page
              </Button>
              <Link to="/contact">
                <Button type="button">Contact Support</Button>
              </Link>
            </div>
          </>
        )}
      </div>
    </div>
  )
}

export default OrderConfirmation
