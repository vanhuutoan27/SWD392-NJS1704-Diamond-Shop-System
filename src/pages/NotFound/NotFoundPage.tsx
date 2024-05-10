import Header from "@/components/organisms/Header";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Footer from "@/components/organisms/Footer";
import { Link } from "react-router-dom";
import { Button } from "@/components/atoms/button";

function NotFoundPage() {
  const goBack = () => {
    window.history.back();
  };

  return (
    <div className="h-screen">
      <Header />
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="404 Not Found"
      />

      <div className="flex h-3/4 w-full justify-center">
        <div className=" flex w-[700px] flex-col justify-center bg-white px-4 text-center font-medium">
          <h1 className="mb-2 text-9xl font-bold text-gray-200">404</h1>
          <p className="text-2xl font-bold tracking-tight text-gray-900 sm:text-4xl">
            Uh-oh!
          </p>
          <p className="mt-4 text-gray-500">
            Something went wrong. Please try again later.
          </p>
          <div className="mt-6 flex items-center justify-center gap-4">
            <Button type="button" variant="secondary" onClick={goBack}>
              Go back to the previous page
            </Button>
            <Button type="button">
              <Link to="/">Home Page</Link>
            </Button>
          </div>
        </div>
      </div>

      <Footer />
    </div>
  );
}

export default NotFoundPage;
