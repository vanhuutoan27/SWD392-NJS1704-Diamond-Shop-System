import { projectName } from "@/lib/constants";
import { cn } from "@/lib/utils";
import { Bomb, ChevronDown, LayoutDashboard } from "lucide-react";
import { useRef, useState, useEffect, useLayoutEffect } from "react";
import { Link, useLocation } from "react-router-dom";

function SidebarHeader() {
  return (
    <div className="h-18 mb-4 mt-2 flex flex-col uppercase text-white">
      <h2 className="cursor-pointer select-none text-center text-4xl font-bold md:text-left">
        {projectName}
      </h2>
      <h4 className="select-none font-semibold tracking-widest text-[#888]">
        Diamond Shop System
      </h4>
    </div>
  );
}

type SidebarItemProps = {
  onClick: (title: string) => void;
  title: string;
  link?: string;
  icon?: React.ReactNode;
  isActive: boolean;
  hasSubNav?: boolean;
};

function SidebarItem({
  onClick,
  title,
  link,
  icon,
  isActive,
  hasSubNav,
}: SidebarItemProps) {
  return (
    <Link to={link || "#"} className="mt-2 w-full">
      <span
        onClick={() => onClick(title)}
        className={cn(
          "relative flex h-12 w-full items-center gap-4 rounded-md bg-gray-800 px-4 text-white transition-colors duration-300",
          isActive ? "bg-blue-600" : "hover:bg-blue-600",
        )}
      >
        {icon && <span>{icon}</span>}
        <span>{title}</span>
        {hasSubNav && <ChevronDown size={20} className="ml-auto" />}
      </span>
    </Link>
  );
}

type SubSidebarItemProps = {
  item: {
    title: string;
    link: string;
    items?: { title: string; link: string }[];
  };
  isActive: string;
  handleClick: (title: string) => void;
};

function SubSidebarItem({ item, isActive, handleClick }: SubSidebarItemProps) {
  const sidebarRef = useRef<HTMLDivElement>(null);
  const [subMenuHeight, setSubMenuHeight] = useState<number>(0);

  const isSubSidebarItemOpen = (item: string, items: string[] = []) =>
    items.some((i) => i === isActive) || item === isActive;

  useLayoutEffect(() => {
    if (sidebarRef.current) {
      const height = sidebarRef.current.clientHeight + 8;
      setSubMenuHeight(height);
    }
  }, [isActive]);

  return (
    <div
      className={`overflow-hidden transition-all duration-500 ${
        isSubSidebarItemOpen(item.title, item.items?.map((i) => i.title) || [])
          ? "h-auto"
          : "h-0"
      }`}
      style={{
        height: !isSubSidebarItemOpen(
          item.title,
          item.items?.map((i) => i.title) || [],
        )
          ? 0
          : subMenuHeight,
      }}
    >
      <div ref={sidebarRef} className="flex flex-col">
        {item?.items?.map((subItem) => (
          <SidebarItem
            key={subItem.title}
            onClick={handleClick}
            title={subItem.title}
            link={subItem.link}
            isActive={isActive === subItem.title}
          />
        ))}
      </div>
    </div>
  );
}

function Sidebar() {
  const location = useLocation();

  const [isActive, setIsActive] = useState<string>(location.pathname);

  const handleClick = (item: string) => {
    setIsActive(item !== isActive ? item : "");
  };

  useEffect(() => {
    setIsActive(location.pathname);
  }, [location.pathname]);

  console.log(isActive, location.pathname);

  const menuItems = [
    {
      title: "Dashboard",
      link: "/dashboard",
      icon: <LayoutDashboard />,
    },
    {
      title: "More",
      link: "#",
      icon: <Bomb />,
      items: [
        { title: "View More", link: "/view-more" },
        { title: "Edit More", link: "/edit-more" },
      ],
    },
    {
      title: "Bomb",
      link: "#",
      icon: <Bomb />,
      items: [
        { title: "View Bomb", link: "/view-bomb" },
        { title: "Edit Bomb", link: "/edit-bomb" },
      ],
    },
  ];

  return (
    <div className="fixed left-0 top-0 flex h-full w-72 flex-col gap-2 bg-gray-900 p-4 transition-all duration-300">
      <SidebarHeader />

      {menuItems.map((item) => (
        <div key={item.title}>
          <SidebarItem
            onClick={handleClick}
            title={item.title}
            link={item.link}
            icon={item.icon}
            isActive={isActive === item.link}
            hasSubNav={!!item.items}
          />
          {item.items && (
            <SubSidebarItem
              isActive={isActive}
              handleClick={handleClick}
              item={item}
            />
          )}
        </div>
      ))}
    </div>
  );
}

export default Sidebar;
