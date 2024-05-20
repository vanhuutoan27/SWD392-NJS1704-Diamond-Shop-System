import { LogOut, Settings, User } from "lucide-react";
import { Avatar, AvatarImage } from "@/components/atoms/avatar";
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
import { Loader } from "../atoms/Loader";
import { IJwtPayload } from "@/types/user.interface";

interface UserProfileProps {
  userData: IJwtPayload | null;
  onLogout: () => void;
}

function UserProfile({ userData, onLogout }: UserProfileProps) {
  const menuItems = [
    {
      icon: User,
      label: "Profile",
      link: "/profile",
      hoverColor: "group-hover:text-blue-600",
    },
    {
      icon: Settings,
      label: "Settings",
      link: "/setting",
      hoverColor: "group-hover:text-blue-600",
    },
    {
      icon: LogOut,
      label: "Log out",
      link: "#",
      hoverColor: "group-hover:text-red-600",
      separator: true,
      onClick: onLogout,
    },
  ];

  if (!userData) return <Loader />;

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild className="relativeselect-none">
        <div className="flex items-center gap-4">
          <span className="hidden text-right md:block">
            <span className="block cursor-pointer text-sm font-medium transition-all duration-300 hover:text-secondary">
              {userData.name}
            </span>
            <span className="block text-xs text-secondary">
              {userData.email}
            </span>
          </span>
          <Avatar className="cursor-pointer">
            <AvatarImage src="https://github.com/shadcn.png" />
          </Avatar>
        </div>
      </DropdownMenuTrigger>
      <DropdownMenuContent className="absolute -right-20 mt-2 w-60 p-2">
        <DropdownMenuGroup>
          {menuItems.map((item, index) => (
            <Link
              key={index}
              to={item.link}
              onClick={() => {
                scrollToTop();
                if (item.onClick) item.onClick();
              }}
            >
              {item.separator && <DropdownMenuSeparator />}
              <DropdownMenuItem
                className={`group mb-2 cursor-pointer ${item.separator ? "mb-0 mt-2" : ""}`}
              >
                <item.icon
                  className={`slow mr-4 ${item.hoverColor}`}
                  size={20}
                />
                <span className={`slow text-sm ${item.hoverColor}`}>
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
