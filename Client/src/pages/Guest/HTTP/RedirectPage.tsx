import { Navigate } from "react-router-dom";
import { Loader } from "@/components/global/atoms/Loader";
import { useAuthContext } from "@/contexts/AuthContext";

function RedirectPage() {
  const { user } = useAuthContext();

  if (!user) {
    return <Loader />;
  }

  const role = user?.roles;

  if (role === "Admin") {
    return <Navigate to="/admin/dashboard" />;
  } else if (role === "Manager") {
    return <Navigate to="/admin/jewelry-list" />;
  } else if (role === "SalesStaff") {
    return <Navigate to="/sales-staff/dashboard" />;
  } else if (role === "DeliveryStaff") {
    return <Navigate to="/delivery-staff/dashboard" />;
  } else if (role === "Customer") {
    return <Navigate to="/" />;
  }

  return <Loader />;
}

export default RedirectPage;
