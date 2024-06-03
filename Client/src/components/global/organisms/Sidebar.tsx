import { useEffect, useRef, useState } from "react";
import {
  Gem,
  LayoutDashboard,
  Package,
  User,
  ChevronDown,
  ChevronsUpDown,
  Settings,
  LogOut,
} from "lucide-react";
import { Link, useLocation } from "react-router-dom";
import { projectName } from "@/lib/constants";
import { Avatar, AvatarImage } from "../atoms/avatar";
import { useAuthContext } from "@/contexts/AuthContext";

const menuItems = [
  {
    title: "Dashboard",
    link: "/admin/dashboard",
    icon: <LayoutDashboard />,
  },
  {
    title: "Jewelry",
    link: "/admin/jewelry-list",
    icon: <Gem />,
  },
  {
    title: "Diamond",
    link: "/admin/diamond-list",
    icon: <Gem />,
  },
  {
    title: "User",
    link: "#",
    icon: <User />,
    items: [
      { title: "User List", link: "/admin/user-list" },
      { title: "User Permission", link: "/admin/user-permission" },
    ],
  },
  {
    title: "Order",
    link: "/admin/order-list",
    icon: <Package />,
  },
];

interface Item {
  title: string;
  link: string;
  icon: JSX.Element;
  items?: { title: string; link: string }[];
}

function SidebarHeader() {
  return (
    <div className="h-18 mb-4 mt-2 flex flex-col uppercase text-white">
      <h2 className="cursor-pointer select-none text-center text-4xl font-bold md:text-left">
        <Link to="/">{projectName}</Link>
      </h2>
      <h4 className="select-none font-semibold tracking-widest text-secondary">
        Diamond Shop System
      </h4>
    </div>
  );
}

function SidebarFooter() {
  const { user, logout } = useAuthContext();
  const accountMenuRef = useRef<HTMLDivElement>(null);

  const accountMenus = [
    {
      title: "My Profile",
      link: `/admin/profile/${user?.id}`,
      icon: <User />,
    },
    {
      title: "Settings",
      link: `/admin/settings/${user?.id}`,
      icon: <Settings />,
    },
    {
      title: "Log out",
      link: "/login",
      icon: <LogOut />,
      onClick: logout,
    },
  ];

  const [isAccountMenuOpen, setIsAccountMenuOpen] = useState(false);

  const handleToggleAccountMenu = () => {
    setIsAccountMenuOpen(!isAccountMenuOpen);
  };

  const handleClickOutside = (event: MouseEvent) => {
    if (
      accountMenuRef.current &&
      !accountMenuRef.current.contains(event.target as Node)
    ) {
      setIsAccountMenuOpen(false);
    }
  };

  useEffect(() => {
    if (isAccountMenuOpen) {
      document.addEventListener("mousedown", handleClickOutside);
    } else {
      document.removeEventListener("mousedown", handleClickOutside);
    }

    return () => {
      document.removeEventListener("mousedown", handleClickOutside);
    };
  }, [isAccountMenuOpen]);

  return (
    <div className="relative" ref={accountMenuRef}>
      <div
        className="slow flex w-full cursor-pointer select-none items-center gap-4 rounded-md bg-gray-800 p-3 text-slate-200 hover:bg-blue-700"
        onClick={handleToggleAccountMenu}
      >
        <Avatar className="cursor-pointer">
          <AvatarImage
            src={
              user?.avatar ||
              "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Test%2F3fab077cc8865e75354d5fbf20b35488.jpg?alt=media&token=fa6a539e-1f0f-4a6f-83f6-d03ad9b39eea"
            }
          />
        </Avatar>
        <div className="flex w-full items-center justify-between">
          <div className="flex flex-col justify-center gap-1">
            <span className="text-sm font-medium">{user?.fullName}</span>
            <span className="text-xs text-secondary">Admin</span>
          </div>
          <ChevronsUpDown size={20} />
        </div>
      </div>
      {isAccountMenuOpen && (
        <div className="absolute bottom-[72px] w-full overflow-hidden rounded-md">
          {accountMenus.map((item) => (
            <Link key={item.title} to={item.link}>
              <SidebarItem
                onClick={item.onClick || (() => {})}
                title={item.title}
                icon={item.icon}
                isActive={false}
                className={`slow rounded-none ${
                  item.title === "Log out" ? "hover:bg-red-600" : ""
                }`}
              />
            </Link>
          ))}
        </div>
      )}
    </div>
  );
}

interface SidebarItemProps {
  onClick: (item: string) => void;
  title: string;
  icon?: JSX.Element;
  isActive: boolean;
  hasSubNav?: boolean;
  link?: string;
  className?: string;
}

function SidebarItem({
  onClick,
  title,
  icon,
  isActive,
  hasSubNav,
  className = "",
}: SidebarItemProps) {
  return (
    <span
      onClick={() => onClick(title)}
      className={`slow flex w-full cursor-pointer items-center rounded-md p-3 text-slate-200 ${
        isActive ? "bg-blue-700" : "bg-gray-800 hover:bg-blue-700"
      } ${className}`}
    >
      {icon && <span className="mr-4">{icon}</span>}
      <span className="flex w-full items-center justify-between">
        <span>{title}</span>
        {hasSubNav && (
          <ChevronDown
            className={`slow ${isActive ? "rotate-180" : "rotate-0"}`}
            size={20}
          />
        )}
      </span>
    </span>
  );
}

interface SubMenuProps {
  item: Item;
  activeItem: string;
  handleClick: (item: string) => void;
}

function SubMenu({ item, activeItem, handleClick }: SubMenuProps) {
  const navRef = useRef<HTMLDivElement>(null);

  const isSubNavOpen = (item: string, items?: { title: string }[]) =>
    items?.some((i) => i.title === activeItem) || item === activeItem;

  return (
    <div
      className={`transition-height overflow-hidden duration-500 ${
        isSubNavOpen(item.title, item.items) ? "h-auto" : "h-0"
      }`}
      style={{
        height: !isSubNavOpen(item.title, item.items)
          ? 0
          : (navRef.current?.clientHeight ?? 0) + 12,
      }}
    >
      <div ref={navRef} className="my-2 flex flex-col gap-2">
        {item.items?.map((subItem) => (
          <Link key={subItem.title} to={subItem.link}>
            <SidebarItem
              onClick={handleClick}
              title={subItem.title}
              isActive={activeItem === subItem.title}
              className="pl-[52px]"
            />
          </Link>
        ))}
      </div>
    </div>
  );
}

function Sidebar() {
  const location = useLocation();
  const [activeItem, setActiveItem] = useState<string>("");

  useEffect(() => {
    menuItems.forEach((item) => {
      if (item.items) {
        item.items.forEach((subItem) => {
          if (location.pathname === subItem.link) {
            setActiveItem(subItem.title);
          }
        });
      } else if (location.pathname === item.link) {
        setActiveItem(item.title);
      }
    });
  }, [location.pathname]);

  const handleClick = (item: string) => {
    setActiveItem(item !== activeItem ? item : "");
  };

  return (
    <div className="fixed left-0 top-0 flex h-full w-72 flex-col justify-between bg-gray-900 p-6 shadow-md">
      <div className="flex flex-col gap-2">
        <SidebarHeader />

        {menuItems.map((item) => (
          <div key={item.title}>
            {!item.items ? (
              <Link to={item.link}>
                <SidebarItem
                  onClick={handleClick}
                  title={item.title}
                  icon={item.icon}
                  isActive={activeItem === item.title}
                />
              </Link>
            ) : (
              <>
                <SidebarItem
                  onClick={handleClick}
                  title={item.title}
                  icon={item.icon}
                  isActive={activeItem === item.title}
                  hasSubNav={!!item.items}
                />
                <SubMenu
                  activeItem={activeItem}
                  handleClick={handleClick}
                  item={item}
                />
              </>
            )}
          </div>
        ))}
      </div>

      <SidebarFooter />
    </div>
  );
}

export default Sidebar;
