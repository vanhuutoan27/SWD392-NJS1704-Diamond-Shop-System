import {
  Circle,
  Facebook,
  Instagram,
  Mail,
  MapPin,
  Phone,
  Youtube
} from "lucide-react"
import { Link } from "react-router-dom"

import { projectName } from "@/lib/constants"
import { scrollToTop } from "@/lib/utils"

function Footer() {
  const aboutInfos = [
    {
      name: "Address: Long Thanh My, Thu Duc City, Ho Chi Minh City, Vietnam",
      link: "#",
      icon: <MapPin size={20} />
    },
    {
      name: "Email: diamoon.contact@gmail.com",
      link: "#",
      icon: <Mail size={20} />
    },
    { name: "Phone: (84) 098 765 321", link: "#", icon: <Phone size={20} /> }
  ]

  const quickLinks = [
    { name: "Home", link: "/", icon: <Circle size={6} /> },
    { name: "Diamond", link: "/diamond", icon: <Circle size={6} /> },
    { name: "Jewelry", link: "/jewelry", icon: <Circle size={6} /> },
    { name: "News & Blog ", link: "/blog", icon: <Circle size={6} /> }
  ]

  const Informations = [
    { name: "About Us", link: "/about", icon: <Circle size={6} /> },
    { name: "Contact us", link: "/contact", icon: <Circle size={6} /> },
    { name: "Promotion", link: "/promotion", icon: <Circle size={6} /> },
    { name: "Terms & Condition", link: "#", icon: <Circle size={6} /> }
  ]

  const socialMedias = [
    { name: "Facebook", link: "#", icon: <Facebook /> },
    { name: "Instagram", link: "#", icon: <Instagram /> },
    { name: "Youtube", link: "#", icon: <Youtube /> }
  ]

  return (
    <div className="mt-20 bg-primary text-white">
      <div className="container grid grid-cols-12 gap-6 px-5 py-16 sm:px-8">
        <ul className="col-span-12 mb-5 sm:col-span-12 lg:col-span-6 lg:mb-0">
          <div className="mb-4 uppercase">
            <h2 className="cursor-pointer select-none text-4xl font-bold">
              <Link to="/" onClick={scrollToTop}>
                {projectName}
              </Link>
            </h2>
            <h4 className="select-none font-semibold tracking-widest">
              Diamond Shop System
            </h4>
          </div>
          {aboutInfos.map((aboutInfo) => (
            <li key={aboutInfo.name}>
              <span className="flex items-center gap-2 text-sm leading-8 slow">
                {aboutInfo.icon}
                <span className="mt-1">{aboutInfo.name}</span>
              </span>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 text-xl font-semibold uppercase">Quick Links</h3>
          {quickLinks.map((quickLink) => (
            <li key={quickLink.name}>
              <Link
                onClick={scrollToTop}
                to={quickLink.link}
                className="flex items-center gap-2 text-sm leading-8 slow hover:text-secondary"
              >
                {quickLink.icon}
                {quickLink.name}
              </Link>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 text-xl font-semibold uppercase">Information</h3>
          {Informations.map((Information) => (
            <li key={Information.name}>
              <Link
                onClick={scrollToTop}
                to={Information.link}
                className="flex items-center gap-2 text-sm leading-8 slow hover:text-secondary"
              >
                {Information.icon}
                {Information.name}
              </Link>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 text-xl font-semibold uppercase">Follow Us On</h3>
          {socialMedias.map((socialMedia) => (
            <li key={socialMedia.name}>
              <Link
                onClick={scrollToTop}
                to={socialMedia.link}
                className="flex items-center gap-2 text-sm leading-[45px] slow hover:text-secondary"
              >
                {socialMedia.icon}

                {socialMedia.name}
              </Link>
            </li>
          ))}
        </ul>
      </div>

      <div className="grid grid-cols-1 items-center gap-y-4 pb-6 pt-2 text-center text-sm text-slate-300 sm:grid-cols-2 lg:grid-cols-3">
        <span>&copy; 2024 {projectName}. All rights reserved.</span>
        <span>Terms &bull; Privacy Policy</span>

        <div>
          {socialMedias.map((socialMedia) => (
            <Link
              onClick={scrollToTop}
              to={socialMedia.link}
              key={socialMedia.name}
              className="mx-2 inline-flex items-center rounded-full bg-primary p-2 text-secondary slow hover:bg-gray-800 hover:text-slate-100"
            >
              {socialMedia.icon}
            </Link>
          ))}
        </div>
      </div>
    </div>
  )
}

export default Footer
