import { Link, useLocation } from "react-router-dom"

import { scrollToTop } from "@/lib/utils"

import { Button } from "../atoms/button"

function NavigationMenu() {
  const location = useLocation()
  const currentUrl = location.pathname

  const Menus = [
    { title: "Home", link: "/" },
    { title: "About", link: "/about" },
    { title: "Diamond", link: "/diamond" },
    { title: "Jewelry", link: "/jewelry" },
    { title: "Promotion", link: "/promotion" },
    { title: "Blog", link: "/blog" },
    { title: "Contact", link: "/contact" }
  ]

  return (
    <>
      <ul className="flex flex-col gap-y-4 px-6 py-4 md:flex-row md:items-center md:gap-8 md:px-0">
        {Menus.map((menu, index) => (
          <Link to={menu.link} key={index} onClick={scrollToTop}>
            <li
              className={`text-md slow mt-1 flex cursor-pointer items-center text-[14px] font-semibold uppercase hover:text-secondary ${
                menu.link === currentUrl ? "text-secondary" : "text-primary"
              }`}
            >
              <span className="float-left block">{menu.title}</span>
            </li>
          </Link>
        ))}

        <div className="flex flex-col gap-y-4 md:hidden">
          <li>
            <Link to="/register">
              <Button type="button" variant="secondary">
                Register
              </Button>
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
  )
}

export default NavigationMenu
