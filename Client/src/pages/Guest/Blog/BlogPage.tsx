import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import BlogInfo from "@/components/local/Guest/Blog/BlogInfo"

function BlogPage() {
  return (
    <div className="container mx-auto">
      <BreadcrumbComponent lastPage="Home" lastPageUrl="/" currentPage="Blog" />

      <Section pageName={"Blog"} />

      <BlogInfo />
    </div>
  )
}

export default BlogPage
