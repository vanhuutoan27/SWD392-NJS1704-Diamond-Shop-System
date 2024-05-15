import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import Section from "@/components/organisms/Section";
import MemberList from "@/components/specific/About/MemberList";
import AboutInfo from "@/components/specific/About/AboutInfo";

function AboutPage() {
  const memberData = [
    {
      id: "1",
      name: "Phan Van Khai",
      role: "Font-end",
      img: "https://anadi-4.myshopify.com/cdn/shop/files/team-2.png?v=1622707428",
    },
    {
      id: "2",
      name: "Phan Van Khai",
      role: "Font-end",
      img: "https://anadi-4.myshopify.com/cdn/shop/files/team-2.png?v=1622707428",
    },
    {
      id: "3",
      name: "Phan Van Khai",
      role: "Back-end",
      img: "https://anadi-4.myshopify.com/cdn/shop/files/team-2.png?v=1622707428",
    },
    {
      id: "4",
      name: "Phan Van Khai",
      role: "Back-end",
      img: "https://anadi-4.myshopify.com/cdn/shop/files/team-2.png?v=1622707428",
    },
    {
      id: "5",
      name: "Phan Van Khai",
      role: "Back-end",
      img: "https://anadi-4.myshopify.com/cdn/shop/files/team-2.png?v=1622707428",
    },
  ];

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="About"
      />

      <Section pageName={"About"} />

      <AboutInfo />

      <div className="mt-6 flex justify-center">
        {memberData.map((member) => (
          <MemberList key={member.id} member={member} />
        ))}
      </div>
    </div>
  );
}

export default AboutPage;
