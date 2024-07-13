import { useEffect, useState } from "react"

import { useNavigate } from "react-router-dom"

import { useConfirmEmail } from "@/apis/userApi"

import { scrollToTop } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

function ConfirmEmailPage() {
  const navigate = useNavigate()
  const [token, setToken] = useState("")
  const [email, setEmail] = useState("")
  const [success, setSuccess] = useState<boolean | null>(null)

  // Extract token and email from URL parameters
  useEffect(() => {
    const urlParams = new URLSearchParams(window.location.search)
    const token = urlParams.get("token") ?? ""
    const email = urlParams.get("email") ?? ""
    setToken(token)
    setEmail(email)

    // Automatically confirm email if success is set in the URL
    const successParam = urlParams.get("success")
    if (successParam === "true") {
      setSuccess(true)
    } else if (successParam === "false") {
      setSuccess(false)
    }
  }, [])

  // Use custom hook to handle email confirmation
  const confirmEmailMutation = useConfirmEmail()

  const confirmEmail = () => {
    confirmEmailMutation.mutate(
      { token, email },
      {
        onSuccess: () => setSuccess(true),
        onError: () => setSuccess(false)
      }
    )
  }

  const goToHome = () => {
    navigate("/")
    setTimeout(scrollToTop, 100)
  }

  return (
    <div className="flex h-screen w-full select-none items-center justify-center bg-white">
      <div className="flex w-[700px] flex-col px-4 text-center font-medium">
        {success === true && (
          <>
            <h1 className="mb-2 text-9xl font-bold text-gray-200">200</h1>
            <p className="text-2xl font-bold tracking-tight text-gray-800 sm:text-4xl">
              Confirm Your Email
            </p>
            <p className="mt-4 text-gray-500">
              Please confirm your email address by clicking the button below.
            </p>
            <div className="mt-6 flex items-center justify-center gap-4">
              <Button type="button" onClick={confirmEmail}>
                Confirm Email
              </Button>
            </div>
          </>
        )}
        {success === false && (
          <>
            <h1 className="mb-2 text-9xl font-bold text-gray-200">400</h1>
            <p className="text-2xl font-bold tracking-tight text-gray-800 sm:text-4xl">
              Confirmation Failed
            </p>
            <p className="mt-4 text-gray-500">
              Something went wrong. Please try again later.
            </p>
            <div className="mt-6 flex items-center justify-center gap-4">
              <Button type="button" onClick={goToHome}>
                Go to Home Page
              </Button>
            </div>
          </>
        )}
      </div>
    </div>
  )
}

export default ConfirmEmailPage
