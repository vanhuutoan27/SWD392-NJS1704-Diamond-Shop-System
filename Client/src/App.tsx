import { Suspense, lazy } from "react"

import { Route, Routes } from "react-router-dom"

import { Loader } from "./components/global/atoms/Loader"
import AuthLayout from "./components/global/templates/AuthLayout"
import RootLayout from "./components/global/templates/RootLayout"
import ConfirmEmailPage from "./pages/Guest/HTTP/ConfirmEmailPage"
import ForbiddenPage from "./pages/Guest/HTTP/ForbiddenPage"
import NotFoundPage from "./pages/Guest/HTTP/NotFoundPage"
import RedirectPage from "./pages/Guest/HTTP/RedirectPage"

function App() {
  // Public Routes
  const Home = lazy(() => import("./pages/Guest/Home/HomePage"))
  const Login = lazy(() => import("./pages/Guest/Login/LoginPage"))
  const Register = lazy(() => import("./pages/Guest/Register/RegisterPage"))
  const About = lazy(() => import("./pages/Guest/About/AboutPage"))
  const Jewelry = lazy(() => import("./pages/Guest/Jewelry/JewelryPage"))
  const JewelryDetail = lazy(
    () => import("./pages/Guest/Jewelry/JewelryDetailPage")
  )
  const Diamond = lazy(() => import("./pages/Guest/Diamond/DiamondPage"))
  const DiamondDetail = lazy(
    () => import("./pages/Guest/Diamond/DiamondDetailPage")
  )
  const Blog = lazy(() => import("./pages/Guest/Blog/BlogPage"))
  const BlogDetail = lazy(() => import("./pages/Guest/Blog/BlogDetailPage"))
  const Promotion = lazy(() => import("./pages/Guest/Promotion/PromotionPage"))
  const Contact = lazy(() => import("./pages/Guest/Contact/ContactPage"))
  const Cart = lazy(() => import("./pages/Customer/Cart/MyCartPage"))
  const Order = lazy(() => import("./pages/Customer/Order/OrderPage"))
  const OrderConfirmation = lazy(
    () => import("./pages/Customer/Order/OrderConfirmationPage")
  )
  const MyProfile = lazy(() => import("./pages/Customer/Profile/MyProfilePage"))
  const MySetting = lazy(() => import("./pages/Customer/Setting/MySettingPage"))
  const MyOrder = lazy(() => import("./pages/Customer/Order/MyOrderPage"))
  const MyInvoice = lazy(() => import("./pages/Customer/Invoice/MyInvoicePage"))

  // Authenticated Routes
  const Dashboard = lazy(() => import("./pages/Admin/Dashboard/DashboardPage"))
  const JewelryList = lazy(
    () => import("./pages/Manager/Jewelry/JewelryListPage")
  )
  const DiamondList = lazy(
    () => import("./pages/Manager/Diamond/DiamondListPage")
  )
  const UserList = lazy(() => import("./pages/Admin/User/UserListPage"))
  const UserPermission = lazy(
    () => import("./pages/Admin/User/UserPermissionPage")
  )
  const OrderList = lazy(() => import("./pages/Manager/Order/OrderListPage"))
  const InvoiceList = lazy(
    () => import("./pages/Manager/Invoice/InvoiceListPage")
  )

  // Staff Routes
  const StaffDashboard = lazy(
    () => import("./pages/Staff/Dashboard/DashboardPage")
  )

  return (
    <Routes>
      <Route element={<RootLayout />}>
        <Route
          path="/"
          element={
            <Suspense fallback={<Loader />}>
              <Home />
            </Suspense>
          }
        />

        <Route
          path="/login"
          element={
            <Suspense fallback={<Loader />}>
              <Login />
            </Suspense>
          }
        />

        <Route
          path="/register"
          element={
            <Suspense fallback={<Loader />}>
              <Register />
            </Suspense>
          }
        />

        <Route
          path="/about"
          element={
            <Suspense fallback={<Loader />}>
              <About />
            </Suspense>
          }
        />

        <Route
          path="/jewelry"
          element={
            <Suspense fallback={<Loader />}>
              <Jewelry />
            </Suspense>
          }
        />

        <Route
          path="/jewelry/:jewelryId"
          element={
            <Suspense fallback={<Loader />}>
              <JewelryDetail />
            </Suspense>
          }
        />

        <Route
          path="/diamond"
          element={
            <Suspense fallback={<Loader />}>
              <Diamond />
            </Suspense>
          }
        />

        <Route
          path="/diamond/:diamondId"
          element={
            <Suspense fallback={<Loader />}>
              <DiamondDetail />
            </Suspense>
          }
        />

        <Route
          path="/blog"
          element={
            <Suspense fallback={<Loader />}>
              <Blog />
            </Suspense>
          }
        />

        <Route
          path="/blog/:blogId"
          element={
            <Suspense fallback={<Loader />}>
              <BlogDetail />
            </Suspense>
          }
        />

        <Route
          path="/promotion"
          element={
            <Suspense fallback={<Loader />}>
              <Promotion />
            </Suspense>
          }
        />

        <Route
          path="/contact"
          element={
            <Suspense fallback={<Loader />}>
              <Contact />
            </Suspense>
          }
        />

        <Route
          path="/cart"
          element={
            <Suspense fallback={<Loader />}>
              <Cart />
            </Suspense>
          }
        />

        <Route
          path="/order"
          element={
            <Suspense fallback={<Loader />}>
              <Order />
            </Suspense>
          }
        />

        <Route
          path="/order-confirmation"
          element={
            <Suspense fallback={<Loader />}>
              <OrderConfirmation />
            </Suspense>
          }
        />

        <Route
          path="/my-profile/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MyProfile />
            </Suspense>
          }
        />

        <Route
          path="/my-settings/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MySetting />
            </Suspense>
          }
        />

        <Route
          path="/my-orders/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MyOrder />
            </Suspense>
          }
        />

        <Route
          path="/my-invoices/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MyInvoice />
            </Suspense>
          }
        />
      </Route>

      <Route element={<AuthLayout />}>
        <Route
          path="/admin/dashboard"
          element={
            <Suspense fallback={<Loader />}>
              <Dashboard />
            </Suspense>
          }
        />

        <Route
          path="/admin/profile/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MyProfile />
            </Suspense>
          }
        />

        <Route
          path="/admin/settings/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <MySetting />
            </Suspense>
          }
        />

        <Route
          path="/admin/jewelry-list"
          element={
            <Suspense fallback={<Loader />}>
              <JewelryList />
            </Suspense>
          }
        />

        <Route
          path="/admin/diamond-list"
          element={
            <Suspense fallback={<Loader />}>
              <DiamondList />
            </Suspense>
          }
        />

        <Route
          path="/admin/user-list"
          element={
            <Suspense fallback={<Loader />}>
              <UserList />
            </Suspense>
          }
        />

        <Route
          path="/admin/user-permission"
          element={
            <Suspense fallback={<Loader />}>
              <UserPermission />
            </Suspense>
          }
        />

        <Route
          path="/admin/order-list"
          element={
            <Suspense fallback={<Loader />}>
              <OrderList />
            </Suspense>
          }
        />

        <Route
          path="/admin/invoice-list"
          element={
            <Suspense fallback={<Loader />}>
              <InvoiceList />
            </Suspense>
          }
        />

        <Route
          path="/staff/dashboard"
          element={
            <Suspense fallback={<Loader />}>
              <StaffDashboard />
            </Suspense>
          }
        />

        <Route
          path="/staff/order-list"
          element={
            <Suspense fallback={<Loader />}>
              <OrderList />
            </Suspense>
          }
        />

        <Route path="/admin/*" element={<NotFoundPage />} />
      </Route>

      <Route path="/confirm-email" element={<ConfirmEmailPage />} />
      <Route path="/*" element={<NotFoundPage />} />
      <Route path="/redirect" element={<RedirectPage />} />
      <Route path="/not-found" element={<NotFoundPage />} />
      <Route path="/forbidden" element={<ForbiddenPage />} />
    </Routes>
  )
}

export default App
