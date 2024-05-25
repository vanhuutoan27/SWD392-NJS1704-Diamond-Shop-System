import { Navigate } from "react-router-dom";
import { Loader } from "@/components/global/atoms/Loader";
import { useAuthContext } from "@/contexts/AuthContext";
import { IUserRole } from "@/types/user.interface";

function RedirectPage() {
  const { user } = useAuthContext();

  if (!user) {
    return <Loader />;
  }

  const role =
    typeof user?.roles === "string"
      ? IUserRole[user.roles as keyof typeof IUserRole]
      : user?.roles;

  if (role === IUserRole.Admin) {
    return <Navigate to="/admin/dashboard" />;
  } else if (role === IUserRole.Manager) {
    return <Navigate to="/admin/jewelry-list" />;
  } else if (role === IUserRole.SalesStaff) {
    return <Navigate to="/sales-staff/dashboard" />;
  } else if (role === IUserRole.DeliveryStaff) {
    return <Navigate to="/delivery-staff/dashboard" />;
  } else if (role === IUserRole.Customer) {
    return <Navigate to="/" />;
  }

  return <Loader />;
}

export default RedirectPage;
