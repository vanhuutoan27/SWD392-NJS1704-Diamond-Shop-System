import { projectName } from "@/lib/constants";

function ProfileInfo() {
  return (
    <div className="flex mt-10 flex-col items-center justify-center">
      <h3 className="flex justify-center font-medium">About Me</h3>
      <p className="mt-4 w-3/5 text-center text-sm text-secondary">
        The web manager for {projectName}, a leading online destination for
        high-quality diamonds. With extensive experience in web development and
        e-commerce, I am dedicated to creating an exceptional online shopping
        experience for our customers.
      </p>
    </div>
  );
}

export default ProfileInfo;
