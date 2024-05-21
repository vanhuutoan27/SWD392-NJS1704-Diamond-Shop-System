import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/global/atoms/BreadcrumbComponent";
import { Loader } from "@/components/global/atoms/Loader";
import { formatDate } from "@/lib/utils";
import { blogData } from "@/constants/blog";

function BlogDetailPage() {
  const { blogId } = useParams<{ blogId: string }>();

  const blogItem = blogData.find((blog) => blog.blogId === blogId);

  if (!blogItem) {
    return <Loader />;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Blog"
        currentPageUrl="/blog"
        currentDetailPage={blogItem.title}
      />

      <div className={`overflow-hidden rounded-md shadow-md`}>
        <img
          src={blogItem.img}
          alt={blogItem.title}
          className="h-96 w-full object-cover"
        />
        <div className="p-4">
          <h1 className="my-4 text-center text-3xl font-semibold">
            {blogItem.title}
          </h1>

          <p className="text-primary">{blogItem.description}</p>

          <div className="mt-10 flex flex-col items-end gap-y-2">
            <div>
              <span className="font-semibold">Created on: </span>
              <span>{formatDate(blogItem.createdOn)}</span>
            </div>
            <div>
              <span className="font-semibold">Author: </span>
              <span>{blogItem.createdBy}</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default BlogDetailPage;
