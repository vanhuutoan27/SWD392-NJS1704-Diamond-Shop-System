import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";
import AboutInfo from "@/components/local/Guest/About/AboutInfo";
import { userData } from "@/constants/user";
import { getUserRole } from "@/lib/utils";
import { IUserRole, IUserStatus } from "@/types/user.interface";

function AboutPage() {
  const teamMemberData = userData.filter(
    (item) =>
      item.role === IUserRole.Admin && item.status === IUserStatus.Active,
  );

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="About"
      />

      <Section pageName={"About"} />

      <AboutInfo />

      <div className="mt-10 flex flex-col">
        <Section pageName="Team Member" />

        <div className="flex justify-between gap-4">
          {teamMemberData.map((member) => (
            <div className="overflow-hidden rounded-md text-center shadow-md">
              <img
                src={member.avatar}
                alt={member.name}
                className="h-72 w-full cursor-pointer object-cover"
              />
              <div className="px-6 py-4">
                <h4 className="slow mb-1 cursor-pointer text-sm font-semibold hover:text-secondary">
                  {member.name}
                </h4>
                <p className="text-sm text-secondary">
                  {getUserRole(member.role)}
                </p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
}

export default AboutPage;
