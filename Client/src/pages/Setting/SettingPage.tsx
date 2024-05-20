import { cn, useIsAdminRoute } from "@/lib/utils";

function SettingPage() {
  const isAdminRoute = useIsAdminRoute();

  return (
    <div className={cn("", isAdminRoute ? "p-5" : "container")}>
      SettingPage
    </div>
  );
}

export default SettingPage;
