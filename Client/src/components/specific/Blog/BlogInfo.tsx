import { useState } from "react";
import { blogData } from "../../../constants/blog";
import { Button } from "@/components/atoms/button";
import { Link } from "react-router-dom";
import { formatDate } from "@/lib/utils";

function BlogInfo() {
  const [hoveredIndex, setHoveredIndex] = useState<number | null>(null);

  return (
    <div className="grid grid-cols-1 gap-10 sm:grid-cols-2">
      {blogData.map((blog, index) => (
        <div
          key={blog.blogId}
          className="overflow-hidden rounded-md bg-white shadow-md"
        >
          <Link to={`/blog/${blog.blogId}`}>
            <img
              src={blog.img}
              alt={blog.title}
              className={`h-60 w-full cursor-pointer object-cover transition-transform ${
                hoveredIndex === index ? "scale-x-95 scale-y-90" : ""
              }`}
              onMouseEnter={() => setHoveredIndex(index)}
              onMouseLeave={() => setHoveredIndex(null)}
            />
          </Link>
          <div className="p-4">
            <div className="mb-2 flex justify-between text-sm text-gray-600">
              <span className="text-[#888]">
                Created on: {formatDate(blog.createdOn)}
              </span>
              <span className="text-[#888]">By: {blog.createdBy}</span>
            </div>
            <div className="mb-2 border-b-2 border-neutral-100">
              <p className="text-xl font-medium">{blog.title}</p>
            </div>
            <p className="flex justify-self-start text-sm text-gray-800">
              {blog.intro}
            </p>
            <Link to={`/blog/${blog.blogId}`} className="mt-8 flex justify-end">
              <Button type="button">Read More</Button>
            </Link>
          </div>
        </div>
      ))}
    </div>
  );
}

export default BlogInfo;
