import BlogInfo from "@/components/local/Guest/Blog/BlogInfo";
import BreadcrumbComponent from "@/components/global/atoms/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";

function BlogPage() {
  return (
    <div className="container mx-auto">
      <BreadcrumbComponent lastPage="Home" lastPageUrl="/" currentPage="Blog" />

      <Section pageName={"Blog"} />

      <BlogInfo />
    </div>
  );
}

export default BlogPage;
