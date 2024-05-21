import { cn, useIsAdminRoute } from "@/lib/utils";
import { userData } from "@/constants/user";
import { useParams } from "react-router-dom";
import { Loader } from "@/components/atoms/Loader";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import { IUserRole } from "@/types/user.interface";
import { Camera } from "lucide-react";
import InfoProfile from "@/components/specific/Proflie/InfoProfile";
import FollowMe from "@/components/specific/Proflie/FollowMe";

function ProfilePage() {
  const isAdminRoute = useIsAdminRoute();
  const { userId } = useParams<{ userId: string }>();

  const userDetail = userData.find((user) => user.userId === userId);

  if (!userDetail) {
    return <Loader />;
  }

  return (
    <div className={cn("", isAdminRoute ? "p-5" : "container")}>
      <BreadcrumbComponent
        lastPage="Dashboard"
        lastPageUrl="/"
        currentPage="Profile"
      />

      <div className="h-[600px] w-full border-2">
        <div className="h-1/3">
          <img
            src="https://t4.ftcdn.net/jpg/03/26/59/69/360_F_326596944_m7WkrlErKIg1W2HAIzuOWUwGZ5R54v4h.jpg"
            className="block h-full w-full object-cover"
          />
        </div>

        <div className="absolute left-1/2 top-[360px] -translate-x-1/2 transform">
          <div className=" flex flex-col items-center">
            <img
              src={userDetail.avatar}
              className="h-[140px] w-[140px] rounded-full border-[8px] border-gray-200 object-cover"
            />
            <div className="mt-[-20px] flex h-[32px] w-[32px] cursor-pointer items-center justify-center rounded-full bg-blue-600 hover:bg-blue-800">
              <Camera size={15} className="text-white" />
            </div>
          </div>
        </div>

        <div className="mt-24 flex flex-auto justify-center">
          <h1 className="text-xl font-medium">{userDetail.name}</h1>
        </div>
        <p className="flex justify-center text-sm font-medium text-gray-500">
          {IUserRole[userDetail.role]}
        </p>
        <div className="md:mt-10">
          <InfoProfile />
        </div>
        <div className="mt-20">
          <FollowMe />
        </div>
      </div>
    </div>
  );
}

export default ProfilePage;
