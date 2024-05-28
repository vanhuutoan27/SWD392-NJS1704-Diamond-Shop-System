import { useState } from "react";
import { blogData } from "../../../../constants/blog";
import { Button } from "@/components/global/atoms/button";
import { Link } from "react-router-dom";
import { formatDate } from "@/lib/utils";

function BlogInfo() {
  const [hoveredIndex, setHoveredIndex] = useState<number | null>(null);

  return (
    <div className="grid sm:grid-cols-2 gap-x-20 gap-y-10 px-10">
      {blogData.map((blog, index) => (
        <div
          key={blog.blogId}
          className="overflow-hidden rounded-md bg-white shadow-md"
        >
          <Link to={`/blog/${blog.blogId}`}>
            <div
              className="relative h-60 w-full cursor-pointer overflow-hidden"
              onMouseEnter={() => setHoveredIndex(index)}
              onMouseLeave={() => setHoveredIndex(null)}
            >
              <img
                src={blog.img}
                alt={blog.title}
                className="h-full w-full object-cover transition-opacity duration-300"
              />
              <div
                className={`absolute inset-0 bg-black transition-opacity duration-300 ${
                  hoveredIndex === index ? "opacity-50" : "opacity-0"
                }`}
              ></div>
            </div>
          </Link>

          <div className="p-4">
            <div className="mb-2 flex justify-between text-sm text-gray-600">
              <span className="text-secondary">
                Created on: {formatDate(blog.createdOn)}
              </span>
              <span className="text-secondary">By: {blog.createdBy}</span>
            </div>
            <div className="flex-fit mb-2 flex border-b-2 border-neutral-100">
              <Link to={`/blog/${blog.blogId}`}>
                <p className="text-xl font-medium hover:text-[#c69967]">
                  {blog.title}
                </p>
              </Link>
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
