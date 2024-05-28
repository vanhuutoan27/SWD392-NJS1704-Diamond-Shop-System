import {
  LogOut,
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
import { Link } from "react-router-dom";
import { scrollToTop } from "@/lib/utils";
import { IJwtPayload } from "@/types/user.interface";
import { Skeleton } from "../atoms/skeleton";

interface UserProfileProps {
  userData: IJwtPayload | null;
  onLogout: () => void;
}

function UserProfile({ userData, onLogout }: UserProfileProps) {
  const userId = userData?.id;

  const menuItems = [
    {
      icon: User,
      label: "My Profile",
      link: `/profile/${userId}`,
      hoverColor: "group-hover:text-secondary",
    },
    {
      icon: PackageCheck,
      label: "My Order",
      link: `/orders/${userId}`,
      hoverColor: "group-hover:text-secondary",
    },
    {
      icon: ReceiptText,
      label: "Invoices",
      link: `/invoices/${userId}`,
      hoverColor: "group-hover:text-secondary",
    },
    {
      icon: Settings,
      label: "Settings",
      link: `/settings/${userId}`,
      hoverColor: "group-hover:text-secondary",
    },
    {
      icon: LogOut,
      label: "Log out",
      link: "/login",
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
      <div className="flex items-center gap-4">
        <span className="hidden text-right md:block">
          <span className="slow block cursor-pointer text-sm font-medium text-primary hover:text-secondary">
            {userData.fullname}
          </span>
          <span className="block text-xs text-secondary">{userData.email}</span>
        </span>
        <DropdownMenuTrigger asChild className="relative select-none">
          <Avatar className="cursor-pointer">
            <AvatarImage
              src={
                userData.avatar ||
                "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Test%2F3fab077cc8865e75354d5fbf20b35488.jpg?alt=media&token=fa6a539e-1f0f-4a6f-83f6-d03ad9b39eea"
              }
            />
          </Avatar>
        </DropdownMenuTrigger>
      </div>
      <DropdownMenuContent className="absolute -right-5 mt-2 w-60 p-2">
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
