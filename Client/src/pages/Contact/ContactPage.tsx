import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import IntroContact from "@/components/atoms/IntroContact";
import FormInput from "@/components/atoms/FormInput";

function ContactPage() {
  return (
    <div className="container">
      <div>
        <BreadcrumbComponent
          lastPage="HOME"
          lastPageUrl="/"
          currentPage="CONTACT"
        />
      </div>
      <div className="intro_contact mt-14 flex">
        <IntroContact />
        <FormInput />
      </div>
    </div>
  );
}

export default ContactPage;
