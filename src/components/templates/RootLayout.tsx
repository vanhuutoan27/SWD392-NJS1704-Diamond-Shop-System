import { Outlet } from "react-router-dom";
import Header from "../organisms/Header";
import Footer from "../organisms/Footer";

function RootLayout() {
  return (
    <div className="h-screen">
      <Header />
      <div className="flex min-h-full px-40">
        <Outlet />
      </div>
      <Footer />
    </div>
  );
}

export default RootLayout;
