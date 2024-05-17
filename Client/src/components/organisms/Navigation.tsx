import { useEffect, useState } from "react";
import { Menu, X } from "lucide-react";
import NavigationMenu from "../molecules/NavigationMenu";
import NavigationMobile from "./NavigationMobile";
import CartButton from "../molecules/CartButton";

function Navigation() {
  const [isMenuOpen, setMenuOpen] = useState(false);
  const [isSticky, setSticky] = useState(false);

  const toggleMenu = () => {
    setMenuOpen(!isMenuOpen);
  };

  useEffect(() => {
    const handleScroll = () => {
      const stickyOffset = 100;
      setSticky(window.scrollY > stickyOffset);
    };

    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  return (
    <div
      className={`flex items-center justify-between bg-white py-4 ${isSticky ? "sticky-nav px-8 lg:py-2 xl:px-48" : ""}`}
    >
      <div
        className={`${isSticky ? "hidden lg:flex" : ""} ${isMenuOpen ? "top-[20%]" : "-top-[100%]"} absolute left-0 z-10 flex min-h-[40vh] w-full items-center bg-white shadow-md duration-300 ease-in-out lg:static lg:min-h-fit lg:w-auto lg:shadow-none`}
      >
        <NavigationMenu />
      </div>

      <div className="flex w-full flex-row-reverse items-center justify-between lg:w-fit">
        <CartButton />

        {isMenuOpen ? (
          <div
            className="flex cursor-pointer select-none gap-4 font-semibold uppercase text-gray-800 lg:hidden"
            onClick={toggleMenu}
          >
            <X />
            <span>Menu</span>
          </div>
        ) : (
          <div
            className="flex cursor-pointer select-none gap-4 font-semibold uppercase text-gray-800 lg:hidden"
            onClick={toggleMenu}
          >
            <Menu />
            <span>Menu</span>
          </div>
        )}
      </div>

      <NavigationMobile isMenuOpen={isMenuOpen} />
    </div>
  );
}

export default Navigation;
