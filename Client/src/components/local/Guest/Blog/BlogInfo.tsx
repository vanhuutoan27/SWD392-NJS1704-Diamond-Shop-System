import { useState } from "react"

import { Link } from "react-router-dom"

import { formatDate } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

import { blogData } from "../../../../constants/blog"

function BlogInfo() {
  const [hoveredIndex, setHoveredIndex] = useState<number | null>(null)

  return (
    <div className="grid gap-10 sm:grid-cols-2">
      {blogData.map((blog, index) => (
        <div
          key={blog.blogId}
          className="overflow-hidden rounded-md border-2 border-input shadow-md"
        >
          <div
            className="relative h-60 w-full cursor-pointer overflow-hidden"
            onMouseEnter={() => setHoveredIndex(index)}
            onMouseLeave={() => setHoveredIndex(null)}
          >
            <img
              src={blog.img}
              alt={blog.title}
              className="h-full w-full object-cover"
            />
            <div
              className={`slow absolute inset-0 bg-black ${
                hoveredIndex === index ? "opacity-25" : "opacity-0"
              }`}
            ></div>
          </div>

          <div className="p-6">
            <div className="mb-2 flex justify-between text-sm text-gray-600">
              <span className="text-secondary">
                Created on: {formatDate(blog.createdOn)}
              </span>
              <span className="text-secondary">By: {blog.createdBy}</span>
            </div>
            <div className="mb-2 flex">
              <Link to={`/blog/${blog.blogId}`}>
                <h4 className="slow text-xl font-medium hover:text-secondary">
                  {blog.title}
                </h4>
              </Link>
            </div>
            <p className="flex justify-self-start text-sm text-gray-800">
              {blog.intro}
            </p>
            <Link to={`/blog/${blog.blogId}`} className="mt-4 flex justify-end">
              <Button type="button">Read More</Button>
            </Link>
          </div>
        </div>
      ))}
    </div>
  )
}

export default BlogInfo
