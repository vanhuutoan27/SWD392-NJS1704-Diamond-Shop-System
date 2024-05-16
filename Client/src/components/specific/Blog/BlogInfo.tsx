import React, { useState } from "react";
import { blogData } from "../../../constants/blog";
import { Button } from "@/components/atoms/button";
import { Link } from "react-router-dom";

const BlogInfo: React.FC = () => {
  const [hoveredIndex, setHoveredIndex] = useState<number | null>(null);

  return (
    <div className="container mx-auto p-4">
      <div className="grid grid-cols-1 gap-20 sm:grid-cols-2">
        {blogData.map((blog, index) => (
          <div
            key={blog.blogID}
            className="bg-white shadow-lg"
            onMouseEnter={() => setHoveredIndex(index)}
            onMouseLeave={() => setHoveredIndex(null)}
          >
            <Link to={`/blog/${blog.blogID}`}>
              <img
                src={blog.img}
                alt={blog.title}
                className={`h-60 w-full cursor-pointer object-cover transition-transform ${
                  hoveredIndex === index ? "scale-x-95 scale-y-90" : ""
                }`}
              />
            </Link>
            <div className="p-4">
              <div className="mb-2 flex justify-between text-sm text-gray-600">
                <span className="font-light">Created on: {blog.createOn}</span>
                <span className="font-light">By: {blog.createBy}</span>
              </div>
              <div className="border-b-2 border-x-neutral-100">
                <p className="text-xl font-medium">{blog.title}</p>
              </div>
              <p className="flex justify-self-start text-sm text-gray-800">
                {blog.intro}
              </p>
              <Link to={`/blog/${blog.blogID}`}>
                <Button type="button" className="mt-2">
                  Read More
                </Button>
              </Link>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default BlogInfo;
