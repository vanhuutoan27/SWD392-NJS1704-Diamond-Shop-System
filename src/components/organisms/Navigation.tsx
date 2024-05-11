import { useEffect, useState } from "react";
import { Link, useLocation } from "react-router-dom";
import { Menu, X } from "lucide-react";
import CartButton from "../molecules/CartButton";
import { Button } from "../atoms/button";

function Navigation() {
  const location = useLocation();
  const currentUrl = location.pathname;
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

  const Menus = [
    { title: "Home", link: "/" },
    { title: "About Us", link: "/about-us" },
    { title: "Shop", link: "/shop" },
    { title: "Blog", link: "/blog" },
    { title: "Contact", link: "/contact" },
  ];

  return (
    <div
      className={`flex items-center justify-between bg-white ${isSticky ? "sticky-nav px-8 py-1" : "py-3"}`}
    >
      <div
        className={`${isMenuOpen ? "top-[24%]" : "-top-[100%]"} absolute left-0 z-10 flex min-h-[40vh] w-full items-center shadow-md duration-500 ease-in-out md:static md:min-h-fit md:w-auto md:shadow-none`}
      >
        <ul className="flex flex-col gap-y-4 px-6 py-4 md:flex-row md:items-center md:gap-8 md:px-0">
          {Menus.map((menu, index) => (
            <Link to={menu.link} key={index}>
              <li
                key={index}
                className={`text-md mt-1 flex cursor-pointer items-center px-2 text-[14px] font-bold uppercase text-primary transition-all duration-200 hover:text-[#888] ${
                  menu.link === currentUrl ? "text-primary " : "text-gray-900"
                }`}
              >
                <span className="float-left block">{menu.title}</span>
              </li>
            </Link>
          ))}

          <div className="flex flex-col gap-y-4 md:hidden">
            <li>
              <Link to="/register">
                <Button variant="secondary">Register</Button>
              </Link>
            </li>
            <li>
              <Link to="/login">
                <Button>Login</Button>
              </Link>
            </li>
          </div>
        </ul>
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
    </div>
  );
}

export default Navigation;
