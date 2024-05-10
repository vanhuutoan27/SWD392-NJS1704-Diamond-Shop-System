import { Suspense, lazy } from "react";
import { Route, Routes } from "react-router-dom";
import { Loader } from "./components/global/atoms/Loader";
import RootLayout from "./components/global/templates/RootLayout";
import AuthLayout from "./components/global/templates/AuthLayout";
import NotFound from "./pages/NotFound/NotFoundPage";

function App() {
  const Home = lazy(() => import("./pages/Home/HomePage"));
  const Login = lazy(() => import("./pages/Login/LoginPage"));
  const Register = lazy(() => import("./pages/Register/RegisterPage"));

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
      </Route>

      <Route element={<AuthLayout />}></Route>

      <Route path="/not-found" element={<NotFound />} />
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
}

export default App;
