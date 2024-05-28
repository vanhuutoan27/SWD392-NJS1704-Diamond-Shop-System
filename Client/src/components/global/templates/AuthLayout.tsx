import { useEffect, useState } from "react";
import { Navigate, Outlet } from "react-router-dom";
import Sidebar from "../organisms/Sidebar";
import { useAuthContext } from "@/contexts/AuthContext";
import { Loader } from "../atoms/Loader";

function AuthLayout() {
  const { user } = useAuthContext();
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    if (user) {
      setIsLoading(false);
      // console.log(user.roles);
    }
  }, [user]);

  if (isLoading) {
    return <Loader />;
  }

  if (!user || !user.roles.includes("Admin")) {
    return <Navigate to="/forbidden" />;
  }

  return (
    <div className="h-screen">
      <Sidebar />
      <div className="ml-72 min-h-full bg-slate-100">
        <Outlet />
      </div>
    </div>
  );
}

export default AuthLayout;
