import React from "react";
import { useParams } from "react-router-dom";
import { blogData } from "../../constants/blog"; // Adjust the import path as necessary
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";
import { Loader } from "@/components/atoms/Loader";

const BlogDetailPage: React.FC = () => {
  const { blogID } = useParams<{ blogID: string }>();

  // Find the blog post with the matching ID
  const blogPost = blogData.find((blog) => blog.blogID === blogID);

  // If no matching blog post is found, display a message
  if (!blogPost) {
    return <Loader />;
  }

  return (
    <div className="container">
      <BreadcrumbComponent lastPage="Home" lastPageUrl="/" currentPage="Blog" />

      <Section pageName={blogPost.title} />
      <div className={`overflow-hidden rounded-lg`}>
        <img
          src={blogPost.img}
          alt={blogPost.title}
          className="h-96 w-full object-cover"
        />
        <div className="p-4">
          <h1 className="mb-4 text-center text-3xl font-semibold">
            {blogPost.title}
          </h1>
          <div className="mb-2 text-gray-600">
            <span className="font-semibold">Created on: </span>
            <span>{blogPost.createOn}</span>
          </div>
          <div className="mb-2 text-gray-600">
            <span className="font-semibold">Author: </span>
            {blogPost.createBy}
          </div>
          <p className="text-gray-800">{blogPost.description}</p>
        </div>
      </div>
    </div>
  );
};

export default BlogDetailPage;
