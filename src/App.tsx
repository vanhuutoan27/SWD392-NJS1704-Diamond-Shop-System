import { Suspense, lazy } from "react";
import { Route, Routes } from "react-router-dom";
import { Loader } from "./components/atoms/Loader";
import RootLayout from "./components/templates/RootLayout";
import AuthLayout from "./components/templates/AuthLayout";

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
    </Routes>
  );
}

export default App;
