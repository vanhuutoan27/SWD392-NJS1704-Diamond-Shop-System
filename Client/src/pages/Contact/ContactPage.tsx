import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";
import ContactForm from "@/components/specific/Contact/ContactForm";
import { projectName } from "@/lib/constants";

function ContactPage() {
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Contact"
      />

      <Section pageName={"Contact"} />

      <div className="relative flex w-full items-center justify-center gap-4">
        <img
          src="https://cdn.shopify.com/s/files/1/1115/6326/files/B1004_Diamonds_banner_2_thumb_61466c50-3bfb-4d54-a2b3-205219e956f5.jpg?v=1511876014"
          alt={projectName}
          className="rounded-md shadow-md"
        />

        <div className="absolute right-0 top-0 h-full w-1/2 p-4">
          <ContactForm />
        </div>
      </div>
    </div>
  );
}

export default ContactPage;
