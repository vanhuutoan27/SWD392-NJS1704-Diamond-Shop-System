import { Outlet } from "react-router-dom"
import Header from "../organisms/Header"
import Footer from "../organisms/Footer"

function RootLayout() {
  return (
    <div className="h-screen">
      <Header />
      <div className="flex min-h-full">
        <Outlet />
      </div>
      <Footer />
    </div>
  )
}

export default RootLayout