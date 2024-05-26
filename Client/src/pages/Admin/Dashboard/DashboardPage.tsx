import KPICards from "@/components/local/Admin/Dashboard/KPICards";
import { useAuthContext } from "@/contexts/AuthContext";
import { Navigate } from "react-router-dom";

function DashboardPage() {
  const { user } = useAuthContext();

  if (!user || !user.roles.includes("Admin")) {
    return <Navigate to="/forbidden" />;
  }

  return (
    <div className="flex h-[1000px] w-full flex-col gap-8 p-5">
      <KPICards />

      <div>asd</div>
    </div>
  );
}

export default DashboardPage;
