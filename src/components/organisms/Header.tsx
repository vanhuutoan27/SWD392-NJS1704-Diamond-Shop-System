import { Link, useLocation } from "react-router-dom";

function Header() {
  const location = useLocation();
  const currentUrl = location.pathname;

  const Menus = [
    {
      id: 1,
      title: "Home",
      link: "/",
    },
    {
      id: 2,
      title: "About Us",
      link: "/about-us",
    },
    {
      id: 3,
      title: "Shop",
      link: "/shop",
    },
    {
      id: 4,
      title: "Blog",
      link: "/blog",
    },
    {
      id: 5,
      title: "Contact",
      link: "/contact",
    },
  ];

  return (
    <div className="bg-white shadow-md drop-shadow-sm">
      <div className="container flex items-center justify-between py-3">
        <h2 className="cursor-pointer select-none py-2 text-2xl font-bold text-gray-900">
          Diamoon
        </h2>

        <div className="flex w-fit gap-x-8">
          {Menus.map((menu, index) => (
            <Link to={menu.link} key={menu.id}>
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
        </div>

        <h2 className="cursor-pointer select-none py-2 text-2xl font-bold text-gray-900">
          Login
        </h2>
      </div>
    </div>
  );
}

export default Header;
