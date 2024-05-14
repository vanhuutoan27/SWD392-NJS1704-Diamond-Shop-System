import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import ContactForm from "@/components/molecules/ContactForm";
import Section from "@/components/organisms/Section";

function ContactPage() {
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Contact"
      />

      <Section pageName={"Contact"} />

      <div className="flex h-screen w-full items-center justify-center gap-4">
        {/* <ContactInfo /> */}
        <ContactForm />
      </div>
    </div>
  );
}

export default ContactPage;
