import { LogOut, Settings, User } from "lucide-react";
import { Button } from "@/components/atoms/button";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuItem,
  DropdownMenuSeparator,
  DropdownMenuTrigger,
} from "@/components/atoms/dropdown-menu";
import { Link } from "react-router-dom";
import { scrollToTop } from "@/lib/utils";

function UserProfile() {
  const menuItems = [
    {
      icon: User,
      label: "Profile",
      link: "/admin/profile",
      hoverColor: "group-hover:text-blue-600",
    },
    {
      icon: Settings,
      label: "Settings",
      link: "/admin/setting",
      hoverColor: "group-hover:text-blue-600",
    },
    {
      icon: LogOut,
      label: "Log out",
      link: "/login",
      hoverColor: "group-hover:text-red-600",
      separator: true,
    },
  ];

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild>
        <Button variant="outline">Open</Button>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="mr-5 mt-2 w-60 p-4">
        <DropdownMenuGroup>
          {menuItems.map((item, index) => (
            <Link key={index} to={item.link} onClick={scrollToTop}>
              {item.separator && <DropdownMenuSeparator />}
              <DropdownMenuItem
                className={`group mb-2 cursor-pointer ${item.separator ? "mt-2" : ""}`}
              >
                <item.icon
                  className={`slow mr-4 ${item.hoverColor}`}
                  size={20}
                />
                <span className={`slow text-base ${item.hoverColor}`}>
                  {item.label}
                </span>
              </DropdownMenuItem>
            </Link>
          ))}
        </DropdownMenuGroup>
      </DropdownMenuContent>
    </DropdownMenu>
  );
}

export default UserProfile;
