import { cn, useIsAdminRoute } from "@/lib/utils";
import { userData } from "@/constants/user";
import { useParams } from "react-router-dom";
import { Loader } from "@/components/atoms/Loader";
import EditUserForm from "@/components/specific/User/EditUserForm";
import { IUser } from "@/types/user.interface";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";

function SettingPage() {
  const isAdminRoute = useIsAdminRoute();
  const { userId } = useParams<{ userId: string }>();

  const userDetail = userData.find((user) => user.userId === userId);

  const handleSave = (updatedUser: IUser) => {
    // Add your save logic here, such as making an API call to save the user data
    console.log("User saved:", updatedUser);
    // Optionally, update the userData array or state here if necessary
  };

  if (!userDetail) {
    return <Loader />;
  }

  return (
    <div className={cn("", isAdminRoute ? "p-5" : "container")}>
      <BreadcrumbComponent
        lastPage="Dashboard"
        lastPageUrl="/"
        currentPage="Settings"
      />

      <h1 className="text-2xl font-semibold">Settings</h1>
      <div className="mt-8 w-1/3">
        <EditUserForm user={userDetail} onSave={handleSave} />
      </div>
    </div>
  );
}

export default SettingPage;
