import { Suspense, lazy } from "react";
import { Route, Routes } from "react-router-dom";
import { Loader } from "./components/atoms/Loader";
import RootLayout from "./components/templates/RootLayout";
import AuthLayout from "./components/templates/AuthLayout";
import NotFound from "./pages/NotFound/NotFoundPage";

function App() {
  // Public Routes
  const Home = lazy(() => import("./pages/Home/HomePage"));
  const Login = lazy(() => import("./pages/Login/LoginPage"));
  const Register = lazy(() => import("./pages/Register/RegisterPage"));
  const About = lazy(() => import("./pages/About/AboutPage"));
  const Jewelry = lazy(() => import("./pages/Jewelry/JewelryPage"));
  const JewelryDetail = lazy(() => import("./pages/Jewelry/JewelryDetailPage"));
  const Diamond = lazy(() => import("./pages/Diamond/DiamondPage"));
  const DiamondDetail = lazy(() => import("./pages/Diamond/DiamondDetailPage"));
  const Cart = lazy(() => import("./pages/Cart/CartPage"));
  const Blog = lazy(() => import("./pages/Blog/BlogPage"));
  const BlogDetail = lazy(() => import("./pages/Blog/BlogDetailPage"));
  const Contact = lazy(() => import("./pages/Contact/ContactPage"));
  const CheckOut = lazy(() => import("./pages/CheckOut/CheckOutPage"));
  const Profile = lazy(() => import("./pages/Profile/ProfilePage"));
  const Setting = lazy(() => import("./pages/Setting/SettingPage"));

  // Authenticated Routes
  const Dashboard = lazy(() => import("./pages/Dashboard/DashboardPage"));

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
          path="/cart"
          element={
            <Suspense fallback={<Loader />}>
              <Cart />
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
          path="/contact"
          element={
            <Suspense fallback={<Loader />}>
              <Contact />
            </Suspense>
          }
        />

        <Route
          path="/checkout"
          element={
            <Suspense fallback={<Loader />}>
              <CheckOut />
            </Suspense>
          }
        />

        <Route
          path="/profile/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <Profile />
            </Suspense>
          }
        />

        <Route
          path="/setting/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <Setting />
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
              <Profile />
            </Suspense>
          }
        />

        <Route
          path="/admin/setting/:userId"
          element={
            <Suspense fallback={<Loader />}>
              <Setting />
            </Suspense>
          }
        />

        <Route path="/admin/*" element={<NotFound />} />
      </Route>

      <Route path="/*" element={<NotFound />} />
      <Route path="/not-found" element={<NotFound />} />
    </Routes>
  );
}

export default App;
