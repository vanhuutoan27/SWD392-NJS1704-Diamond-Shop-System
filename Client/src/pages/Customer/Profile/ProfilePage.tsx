import { cn, useIsAdminRoute } from "@/lib/utils";
import { userData } from "@/constants/user";
import { useParams } from "react-router-dom";
import { IUserRole } from "@/types/user.interface";
import { Loader } from "@/components/global/atoms/Loader";
import ProfileInfo from "@/components/local/Customer/Profile/ProfileInfo";
import ProfileSocial from "@/components/local/Customer/Profile/ProfileSocial";
import Section from "@/components/global/organisms/Section";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";

function ProfilePage() {
  const isAdminRoute = useIsAdminRoute();
  const { userId } = useParams<{ userId: string }>();

  const userDetail = userData.find((user) => user.userId === userId);

  if (!userDetail) {
    return <Loader />;
  }

  return (
    <div className={cn("", isAdminRoute ? "p-10" : "container")}>
      {!isAdminRoute && (
        <BreadcrumbComponent
          lastPage={"Home"}
          lastPageUrl="/"
          currentPage="User Profile"
        />
      )}

      <Section pageName="Profile" />

      <div className="overflow-hidden rounded-md border-2 border-input bg-white p-5 pb-10 shadow-md">
        <div className="relative h-[250px]">
          <img
            src="../../images/home_slider_3.jpg"
            className="h-full w-full rounded-md object-cover"
          />

          <div className="absolute -bottom-16 left-1/2 flex -translate-x-1/2 transform flex-col items-center">
            <img
              src={userDetail.avatar}
              className="h-[160px] w-[160px] cursor-pointer rounded-full border-8 object-cover shadow-md"
            />
          </div>
        </div>

        <div className="mt-20 flex flex-col items-center">
          <h3 className="text-2xl font-semibold">{userDetail.fullName}</h3>
          <p className="flex justify-center text-base font-medium text-secondary">
            {IUserRole[userDetail.role]}
          </p>
        </div>

        <ProfileInfo />

        <ProfileSocial />
      </div>
    </div>
  );
}

export default ProfilePage;
