import { useGetAllUsers } from "@/api/userApi";
import { Loader } from "@/components/global/atoms/Loader";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";
import AboutInfo from "@/components/local/Guest/About/AboutInfo";

function AboutPage() {
  const { data: userData, isLoading, error } = useGetAllUsers();

  if (!userData || isLoading || error) {
    return <Loader />;
  }

  const adminData = userData.filter((user) => user.roles.includes("Admin"));

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
          {adminData.map((member) => (
            <div
              key={member.id}
              className="overflow-hidden rounded-md text-center shadow-md"
            >
              <img
                src={member.avatar}
                alt={member.fullName}
                className="h-72 w-full cursor-pointer object-cover"
              />
              <div className="px-6 py-4">
                <h4 className="slow mb-1 cursor-pointer text-sm font-semibold hover:text-secondary">
                  {member.fullName}
                </h4>
                <p className="text-sm text-secondary">{member.roles}</p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
}

export default AboutPage;
