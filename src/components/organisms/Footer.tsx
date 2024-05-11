import {
  Circle,
  Facebook,
  Instagram,
  Mail,
  MapPin,
  Phone,
  Twitter,
  Youtube,
} from "lucide-react";
import { Link } from "react-router-dom";

function Footer() {
  const aboutInfos = [
    {
      name: "Address: 123 Pall Mall, London England",
      link: "#",
      icon: <MapPin size={20} />,
    },
    {
      name: "Email: diamoon.contact@gmail.com",
      link: "#",
      icon: <Mail size={20} />,
    },
    { name: "Phone: (84) 012 345 6789", link: "#", icon: <Phone size={20} /> },
  ];

  const quickLinks = [
    { name: "New Brands", link: "#", icon: <Circle size={6} /> },
    { name: "News & Blog", link: "#", icon: <Circle size={6} /> },
    { name: "Our Office", link: "#", icon: <Circle size={6} /> },
    { name: "Our Story", link: "#", icon: <Circle size={6} /> },
    { name: "Return Policy", link: "#", icon: <Circle size={6} /> },
  ];

  const Informations = [
    { name: "Best Value", link: "#", icon: <Circle size={6} /> },
    { name: "Your Order", link: "#", icon: <Circle size={6} /> },
    { name: "Terms & Condition", link: "#", icon: <Circle size={6} /> },
    { name: "Contact us", link: "#", icon: <Circle size={6} /> },
    { name: "Manufactures", link: "#", icon: <Circle size={6} /> },
  ];

  const socialMedias = [
    { name: "Facebook", link: "#", icon: <Facebook /> },
    { name: "Twitter", link: "#", icon: <Twitter /> },
    { name: "Instagram", link: "#", icon: <Instagram /> },
    { name: "Youtube", link: "#", icon: <Youtube /> },
  ];

  return (
    <div className="mt-20 bg-primary text-white">
      <div className="container grid grid-cols-12 gap-6 px-5 py-16 sm:px-8">
        <ul className="col-span-12 mb-5 sm:col-span-12 lg:col-span-6 lg:mb-0">
          <h3 className="mb-6 font-semibold">About Info</h3>
          {aboutInfos.map((aboutInfo) => (
            <li key={aboutInfo.name}>
              <Link
                to={aboutInfo.link}
                className="flex items-center gap-2 text-sm leading-10 transition-all duration-200"
              >
                {aboutInfo.icon}
                <span className="mt-1">{aboutInfo.name}</span>
              </Link>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 font-semibold">Quick Links</h3>
          {quickLinks.map((quickLink) => (
            <li key={quickLink.name}>
              <Link
                to={quickLink.link}
                className="flex items-center gap-2 text-sm leading-8 transition-all duration-200 hover:text-[#888]"
              >
                {quickLink.icon}
                {quickLink.name}
              </Link>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 font-semibold">Information</h3>
          {Informations.map((Information) => (
            <li key={Information.name}>
              <Link
                to={Information.link}
                className="flex items-center gap-2 text-sm leading-8 transition-all duration-200 hover:text-[#888]"
              >
                {Information.icon}
                {Information.name}
              </Link>
            </li>
          ))}
        </ul>
        <ul className="col-span-12 mb-5 sm:col-span-4 md:mb-0 lg:col-span-2">
          <h3 className="mb-6 font-semibold">Follow Us On</h3>
          {socialMedias.map((socialMedia) => (
            <li key={socialMedia.name}>
              <Link
                to={socialMedia.link}
                className="flex items-center gap-2 text-sm leading-10 transition-all duration-200 hover:text-[#888]"
              >
                {socialMedia.icon}

                {socialMedia.name}
              </Link>
            </li>
          ))}
        </ul>
      </div>

      <div className="grid grid-cols-1 items-center gap-y-4 pb-6 pt-2 text-center text-sm text-slate-300 sm:grid-cols-2 lg:grid-cols-3">
        <span>&copy; 2024 Diamoon. All rights reserved.</span>
        <span>Terms &bull; Privacy Policy</span>

        <div>
          {socialMedias.map((socialMedia) => (
            <Link
              to={socialMedia.link}
              key={socialMedia.name}
              className="mx-2 inline-flex items-center rounded-full bg-primary p-2 text-[#888] transition-all duration-200 hover:bg-gray-900 hover:text-slate-100"
            >
              {socialMedia.icon}
            </Link>
          ))}
        </div>
      </div>
    </div>
  );
}

export default Footer;
