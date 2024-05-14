import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import ContactInfo from "@/components/molecules/ContactInfo";
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

      <div className="flex h-screen items-center w-full justify-center gap-4">
        {/* <ContactInfo /> */}
        <ContactForm />
      </div>
    </div>
  );
}

export default ContactPage;
