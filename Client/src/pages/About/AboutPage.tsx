import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";
import InfoAbout from "@/components/molecules/InfoAbout";
import MemberList from "@/components/molecules/MemberList";
import { memberData } from "@/constants/member";

function AboutPage() {
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="About"
      />
      <Section pageName={"About"} />
      <InfoAbout />
      <div className="flex justify-center mt-6">
        {memberData.map((member) => (
          <MemberList key={member.id} member={member} />
        ))}
      </div>
    </div>
  );
}

export default AboutPage;
