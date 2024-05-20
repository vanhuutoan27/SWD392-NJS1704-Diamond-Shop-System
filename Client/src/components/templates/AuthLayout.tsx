import { Outlet } from "react-router-dom";
import Sidebar from "../organisms/Sidebar";
import Toolbar from "../organisms/Toolbar";

function AuthLayout() {
  return (
    <div className="h-screen">
      <Sidebar />
      <div className="ml-72 flex min-h-full flex-col bg-slate-200">
        <Toolbar />
        <div className="p-5">
          <Outlet />
        </div>
      </div>
    </div>
  );
}

export default AuthLayout;
