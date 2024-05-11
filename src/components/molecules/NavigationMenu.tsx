import { Link, useLocation } from "react-router-dom";
import { Button } from "../atoms/button";

function NavigationMenu() {
  const location = useLocation();
  const currentUrl = location.pathname;

  const Menus = [
    { title: "Home", link: "/" },
    { title: "About", link: "/about" },
    { title: "Diamond", link: "/product" },
    { title: "Jewelry", link: "/jewelry" },
    { title: "Promotion", link: "/promotion" },
    { title: "News", link: "/news" },
    { title: "Contact", link: "/contact" },
  ];

  return (
    <>
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
    </>
  );
}

export default NavigationMenu;
