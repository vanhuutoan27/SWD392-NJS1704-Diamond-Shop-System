import { Suspense, lazy } from "react";
import { Route, Routes } from "react-router-dom";
import { Loader } from "./components/atoms/Loader";
import RootLayout from "./components/templates/RootLayout";
import AuthLayout from "./components/templates/AuthLayout";
import NotFound from "./pages/NotFound/NotFoundPage";

function App() {
  const Home = lazy(() => import("./pages/Home/HomePage"));
  const Login = lazy(() => import("./pages/Login/LoginPage"));
  const Register = lazy(() => import("./pages/Register/RegisterPage"));
  const About = lazy(() => import("./pages/About/AboutPage"));
  const Blog = lazy(() => import("./pages/Blog/BlogPage"));
  const Contact = lazy(() => import("./pages/Contact/ContactPage"));
  const Product = lazy(() => import("./pages/Product/ProductPage"));
  const ProductDetail = lazy(() => import("./pages/Product/ProductDetailPage"));
  const Cart = lazy(() => import("./pages/Cart/CartPage"));

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
          path="/blog"
          element={
            <Suspense fallback={<Loader />}>
              <Blog />
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
          path="/product"
          element={
            <Suspense fallback={<Loader />}>
              <Product />
            </Suspense>
          }
        />

        <Route
          path="/product:id"
          element={
            <Suspense fallback={<Loader />}>
              <ProductDetail />
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
      </Route>

      <Route element={<AuthLayout />}></Route>

      <Route path="/not-found" element={<NotFound />} />
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
}

export default App;
