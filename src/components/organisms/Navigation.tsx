import { useEffect, useState } from "react";
import { Menu, X } from "lucide-react";
import NavigationMenu from "../molecules/NavigationMenu";
import CartButton from "../molecules/CartButton";
import NavigationMobile from "../molecules/NavigationMobile";

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
      className={`flex items-center justify-between ${isSticky ? "sticky-nav px-8 md:py-1 py-6" : "py-3"}`}
    >
      <div
        className={`${isSticky ? "hidden md:flex" : ""} ${isMenuOpen ? "top-[20%]" : "-top-[100%]"} absolute left-0 z-10 flex min-h-[40vh] w-full items-center bg-white shadow-md duration-500 ease-in-out md:static md:min-h-fit md:w-auto md:shadow-none`}
      >
        <NavigationMenu />
      </div>

      <div className="flex w-full flex-row-reverse items-center justify-between md:w-fit">
        <CartButton />

        {isMenuOpen ? (
          <div
            className="flex cursor-pointer select-none gap-4 font-semibold uppercase text-gray-900 md:hidden"
            onClick={toggleMenu}
          >
            <X />
            <span>Menu</span>
          </div>
        ) : (
          <div
            className="flex cursor-pointer select-none gap-4 font-semibold uppercase text-gray-900 md:hidden"
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
