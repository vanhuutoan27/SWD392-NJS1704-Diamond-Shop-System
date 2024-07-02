import { useEffect, useState } from "react"

import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"
import { ClipLoader } from "react-spinners"

export function Loader() {
  const [hasTimeout, setHasTimeout] = useState(false)

  useEffect(() => {
    const timer = setTimeout(() => {
      setHasTimeout(true)
    }, 5000)

    return () => clearTimeout(timer)
  }, [])

  if (hasTimeout) {
    return <NotFoundPage />
  }

  return (
    <div className="mx-auto flex min-h-screen w-full items-center justify-center">
      <ClipLoader color="#00000" size={70} />
    </div>
  )
}
