import { cn, useIsAdminRoute } from "@/lib/utils";
import { userData } from "@/constants/user";
import { useParams } from "react-router-dom";
import { IUser } from "@/types/user.interface";
import SettingChangPhoto from "@/components/local/Customer/Setting/SettingChangPhoto";
import SettingForm from "@/components/local/Customer/Setting/SettingForm";
import { Loader } from "@/components/global/atoms/Loader";
import Section from "@/components/global/organisms/Section";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";

function SettingPage() {
  const isAdminRoute = useIsAdminRoute();

  const { userId } = useParams<{ userId: string }>();

  const userDetails = userData.find((user) => user.id === userId);

  const handleSave = (updatedUser: IUser) => {
    console.log("Updated user successfully!", updatedUser);
  };

  if (!userDetails) {
    return <Loader />;
  }

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
          <SettingForm user={userDetails} onSave={handleSave} />
        </div>
        <div className="w-1/3">
          <SettingChangPhoto user={userDetails} onSave={handleSave} />
        </div>
      </div>
    </div>
  );
}

export default SettingPage;
