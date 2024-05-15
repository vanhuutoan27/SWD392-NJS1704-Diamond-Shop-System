import BlogInfo from "@/components/specific/Blog/BlogInfo"; // Adjust the import path as necessary
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";

function BlogPage() {
  return (
    <div className="container mx-auto">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Blog"
      />

      <Section pageName={"Blog"} />
      <BlogInfo />
    </div>
  );
}

export default BlogPage;
