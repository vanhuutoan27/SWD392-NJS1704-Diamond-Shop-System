import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";
import ContactForm from "@/components/local/Guest/Contact/ContactForm";
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
          className="hidden w-full rounded-md shadow-md lg:block"
        />

        <div className="absolute right-0 top-8 w-full justify-center p-4 max-sm:top-[-35px] max-lg:top-[-30px] lg:w-1/2">
          <ContactForm />
        </div>
      </div>
    </div>
  );
}

export default ContactPage;
