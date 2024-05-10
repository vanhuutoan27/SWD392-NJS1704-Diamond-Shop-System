import { Outlet } from "react-router-dom";
import Header from "../organisms/Header";
import Footer from "../organisms/Footer";

function RootLayout() {
  return (
    <div className="h-screen">
      <Header />
      <div className="container flex min-h-full py-10">
        <Outlet />
      </div>
      <Footer />
    </div>
  );
}

export default RootLayout;
