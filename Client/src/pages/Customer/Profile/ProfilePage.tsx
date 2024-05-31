import { cn, useIsAdminRoute } from "@/lib/utils";
import { useParams } from "react-router-dom";
import { Loader } from "@/components/global/atoms/Loader";
import ProfileInfo from "@/components/local/Customer/Profile/ProfileInfo";
import ProfileSocial from "@/components/local/Customer/Profile/ProfileSocial";
import Section from "@/components/global/organisms/Section";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import { useGetUserById } from "@/api/userApi";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";
import { userAvatar } from "@/lib/constants";

function ProfilePage() {
  const isAdminRoute = useIsAdminRoute();
  const { userId } = useParams<{ userId: string }>();

  const { data: userDetails, isLoading, error } = useGetUserById(userId || "");

  if (!userDetails || isLoading) {
    return <Loader />;
  }

  if (error) {
    <NotFoundPage />;
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
              src={userDetails.avatar || userAvatar}
              className="h-[160px] w-[160px] cursor-pointer rounded-full border-8 object-cover shadow-md"
            />
          </div>
        </div>

        <div className="mt-20 flex flex-col items-center">
          <h3 className="text-2xl font-semibold">{userDetails.fullName}</h3>
          <p className="flex justify-center text-base font-medium text-secondary">
            {userDetails.roles}
          </p>
        </div>

        <ProfileInfo />

        <ProfileSocial />
      </div>
    </div>
  );
}

export default ProfilePage;
