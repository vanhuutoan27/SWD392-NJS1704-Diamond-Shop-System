import { Menu, X } from "lucide-react";
import { useState } from "react";
import { Link, useLocation } from "react-router-dom";
import { Button } from "../atoms/button";

function Header() {
  const location = useLocation();
  const currentUrl = location.pathname;
  const [isMenuOpen, setMenuOpen] = useState(false);

  const toggleMenu = () => {
    setMenuOpen(!isMenuOpen);
  };

  const Menus = [
    { title: "Home", link: "/" },
    { title: "About Us", link: "/about-us" },
    { title: "Shop", link: "/shop" },
    { title: "Blog", link: "/blog" },
    { title: "Contact", link: "/contact" },
  ];

  return (
    <div className="container flex items-center justify-between bg-white py-3">
      <h2 className="cursor-pointer select-none py-2 text-2xl font-bold text-gray-900">
        <Link to="/">Diamoon</Link>
      </h2>

      <div
        className={`${isMenuOpen ? "top-[9%]" : "-top-[100%]"} absolute left-0 z-10 flex min-h-[40vh] w-full items-center bg-white duration-500 md:static md:min-h-fit md:w-auto`}
      >
        <ul className="flex flex-col gap-4 px-6 md:flex-row md:items-center md:gap-[4vw]">
          {Menus.map((menu, index) => (
            <Link to={menu.link} key={index}>
              <li
                key={index}
                className={`text-md mt-1 flex cursor-pointer items-center p-2 font-medium transition-all duration-200 hover:text-primary ${
                  menu.link === currentUrl
                    ? "text-primary hover:text-yellow-500"
                    : "text-gray-900"
                }`}
              >
                <span className="float-left block">{menu.title}</span>
              </li>
            </Link>
          ))}
        </ul>
      </div>

      <div className="flex items-center gap-6">
        <Link to="/login">
          <Button>Login</Button>
        </Link>

        {isMenuOpen ? (
          <X
            onClick={toggleMenu}
            className="cursor-pointer select-none text-gray-900 md:hidden"
          />
        ) : (
          <Menu
            onClick={toggleMenu}
            className="cursor-pointer select-none text-gray-900 md:hidden"
          />
        )}
      </div>
    </div>
  );
}

export default Header;
