import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";
import ContactForm from "@/components/specific/Contact/ContactForm";

function ContactPage() {
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Contact"
      />

      <Section pageName={"Contact"} />

      <div className="my-20 flex w-full items-center justify-center gap-4">
        {/* <ContactInfo /> */}
        <ContactForm />
      </div>
    </div>
  );
}

export default ContactPage;
