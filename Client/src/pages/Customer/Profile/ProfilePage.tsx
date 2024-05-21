import { cn, useIsAdminRoute } from "@/lib/utils";

function ProfilePage() {
  const isAdminRoute = useIsAdminRoute();

  return (
    <div className={cn("", isAdminRoute ? "p-5" : "container")}>
      ProfilePage
    </div>
  );
}

export default ProfilePage;
