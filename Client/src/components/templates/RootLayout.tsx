import { useEffect, useState } from "react";
import { Outlet } from "react-router-dom";
import Header from "../organisms/Header";
import Footer from "../organisms/Footer";
import FloatingButton from "../organisms/FloatingButton";

function RootLayout() {
  const [isSticky, setSticky] = useState(false);

  useEffect(() => {
    const handleScroll = () => {
      const stickyOffset = 100;
      setSticky(window.scrollY > stickyOffset);
    };

    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  return (
    <div className="relative min-h-screen">
      <Header />
      <div className={`${isSticky ? "mt-24" : "mt-0"} flex min-h-[600px]`}>
        <Outlet />
        <FloatingButton />
      </div>
      <Footer />
    </div>
  );
}

export default RootLayout;
