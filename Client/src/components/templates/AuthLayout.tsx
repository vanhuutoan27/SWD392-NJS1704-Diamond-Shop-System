import { Outlet } from "react-router-dom";
import Sidebar from "../organisms/Sidebar";

function AuthLayout() {
  return (
    <div className="h-screen">
      <Sidebar />
      <div className="flex min-h-full">
        <Outlet />
      </div>
    </div>
  );
}

export default AuthLayout;
