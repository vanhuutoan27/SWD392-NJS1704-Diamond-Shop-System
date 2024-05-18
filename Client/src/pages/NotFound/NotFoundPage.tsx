import { useNavigate } from "react-router-dom";
import { Button } from "@/components/atoms/button";
import { scrollToTop } from "@/lib/utils";

function NotFoundPage() {
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
    <div className="flex h-screen w-full select-none items-center justify-center">
      <div className="flex w-[700px] flex-col bg-white px-4 text-center font-medium">
        <h1 className="mb-2 text-9xl font-bold text-gray-200">404</h1>
        <p className="text-2xl font-bold tracking-tight text-gray-800 sm:text-4xl">
          Uh-oh!
        </p>
        <p className="mt-4 text-gray-500">
          Something went wrong. Please try again later.
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

export default NotFoundPage;
