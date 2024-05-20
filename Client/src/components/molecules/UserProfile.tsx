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
import { IJwtPayload } from "@/types/user.interface";
import { Skeleton } from "../atoms/skeleton";

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

  if (!userData)
    return (
      <div className="flex gap-4">
        <div className="flex flex-col items-end gap-1">
          <Skeleton className="h-5 w-20 rounded-md" />
          <Skeleton className="h-4 w-24 rounded-md" />
        </div>
        <Skeleton className="h-10 w-10 rounded-full" />
      </div>
    );

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild className="relative select-none">
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
