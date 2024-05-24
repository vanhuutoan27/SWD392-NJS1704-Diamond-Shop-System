import { useNavigate } from "react-router-dom";
import { Button } from "@/components/global/atoms/button";
import { cn, scrollToTop, useIsAdminRoute } from "@/lib/utils";

function AccessDenied() {
  const isAdminRoute = useIsAdminRoute();

  const navigate = useNavigate();

  const goBack = () => {
    navigate(-1);
    setTimeout(scrollToTop, 100);
  };

  const goToHome = () => {
    navigate("/");
    setTimeout(scrollToTop, 100);
  };

  return (
    <div
      className={cn(
        "flex w-full select-none items-center justify-center bg-white",
        isAdminRoute ? "h-[calc(100vh-64px)]" : "h-screen",
      )}
    >
      <div className="flex w-[700px] flex-col px-4 text-center font-medium">
        <h1 className="mb-2 text-9xl font-bold text-gray-200">403</h1>
        <p className="text-2xl font-bold tracking-tight text-gray-800 sm:text-4xl">
          Access Denied
        </p>
        <p className="mt-4 text-gray-500">
          You don't have permission to access this page.
        </p>
        <div className="mt-6 flex items-center justify-center gap-4">
          <Button type="button" variant="secondary" onClick={goBack}>
            Go back to the previous page
          </Button>
          <Button type="button" onClick={goToHome}>
            Home Page
          </Button>
        </div>
      </div>
    </div>
  );
}

export default AccessDenied;
