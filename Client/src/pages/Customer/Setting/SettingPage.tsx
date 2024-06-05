import { cn, useIsAdminRoute } from "@/lib/utils";
import { useParams } from "react-router-dom";
import { IUser } from "@/types/user.interface";
import SettingChangePhoto from "@/components/local/Customer/Setting/SettingChangePhoto";
import SettingForm from "@/components/local/Customer/Setting/SettingForm";
import { Loader } from "@/components/global/atoms/Loader";
import Section from "@/components/global/organisms/Section";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import { useGetUserById } from "@/api/userApi";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";

function SettingPage() {
  const isAdminRoute = useIsAdminRoute();
  const { userId } = useParams<{ userId: string }>();

  const { data: userDetails, isLoading, error } = useGetUserById(userId || "");

  if (!userDetails || isLoading) {
    return <Loader />;
  }

  if (error) {
    <NotFoundPage />;
  }

  const handleSave = (updatedUser: IUser) => {
    console.log("Updated user successfully!", updatedUser);
  };

  return (
    <div className={cn("", isAdminRoute ? "p-10" : "container")}>
      {!isAdminRoute && (
        <BreadcrumbComponent
          lastPage={"Home"}
          lastPageUrl="/"
          currentPage="Account Settings"
        />
      )}

      <Section pageName="Settings" />

      <div className="flex w-full flex-col gap-8 md:flex-row">
        <div className="w-2/3">
          <SettingForm user={userDetails} />
        </div>
        <div className="w-1/3">
          <SettingChangePhoto user={userDetails} onSave={handleSave} />
        </div>
      </div>
    </div>
  );
}

export default SettingPage;
