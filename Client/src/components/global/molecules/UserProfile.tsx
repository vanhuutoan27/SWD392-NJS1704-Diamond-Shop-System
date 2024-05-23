import {
  LogOut,
  LayoutDashboard,
  Settings,
  User,
  ReceiptText,
  PackageCheck,
} from "lucide-react";
import { Avatar, AvatarImage } from "@/components/global/atoms/avatar";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuGroup,
  DropdownMenuItem,
  DropdownMenuSeparator,
  DropdownMenuTrigger,
} from "@/components/global/atoms/dropdown-menu";
import { Link, useLocation } from "react-router-dom";
import { scrollToTop } from "@/lib/utils";
import { IJwtPayload } from "@/types/user.interface";
import { Skeleton } from "../atoms/skeleton";

interface UserProfileProps {
  userData: IJwtPayload | null;
  onLogout: () => void;
}

function UserProfile({ userData, onLogout }: UserProfileProps) {
  const userId = userData?.sid;

  const location = useLocation();
  const isAdminRoute = location.pathname.startsWith("/admin");

  const menuItems = [
    !isAdminRoute && {
      icon: LayoutDashboard,
      label: "Admin",
      link: "/admin/dashboard",
      hoverColor: isAdminRoute
        ? `group-hover:text-blue-600`
        : `group-hover:text-secondary`,
    },
    {
      icon: User,
      label: "My Profile",
      link: isAdminRoute ? `/admin/profile/${userId}` : `/profile/${userId}`,
      hoverColor: isAdminRoute
        ? `group-hover:text-blue-600`
        : `group-hover:text-secondary`,
    },
    !isAdminRoute && {
      icon: PackageCheck,
      label: "My Order",
      link: `/order/${userId}`,
      hoverColor: isAdminRoute
        ? `group-hover:text-blue-600`
        : `group-hover:text-secondary`,
    },
    !isAdminRoute && {
      icon: ReceiptText,
      label: "Invoice",
      link: `/invoice/${userId}`,
      hoverColor: isAdminRoute
        ? `group-hover:text-blue-600`
        : `group-hover:text-secondary`,
    },
    {
      icon: Settings,
      label: "Settings",
      link: isAdminRoute ? `/admin/setting/${userId}` : `/setting/${userId}`,
      hoverColor: isAdminRoute
        ? `group-hover:text-blue-600`
        : `group-hover:text-secondary`,
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
          {menuItems.map(
            (item, index) =>
              item && (
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
              ),
          )}
        </DropdownMenuGroup>
      </DropdownMenuContent>
    </DropdownMenu>
  );
}

export default UserProfile;
