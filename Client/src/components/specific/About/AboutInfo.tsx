import { projectName } from "@/lib/constants";

function AboutInfo() {
  return (
    <div className="flex flex-col items-center gap-8 lg:flex-row lg:items-start">
      <div className="flex justify-center lg:w-1/2">
        <img
          src="https://scontent.fsgn2-9.fna.fbcdn.net/v/t1.15752-9/438267265_872545577967313_3582630192194091809_n.png?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeFA1O0ZoEA-QI2Zs0NBgQ-w3HJMssYxVRDcckyyxjFVEJl-ngmjBNCVWET4Wpqoxiv8_Pw6Ff_FlSiWqnpSFh54&_nc_ohc=X05potZ5NfsQ7kNvgGMFCIC&_nc_ht=scontent.fsgn2-9.fna&oh=03_Q7cD1QFW4vscggniggF-TA-9XZ9nim-8JI1EfmTVi1FzSy_swA&oe=666804E3"
          alt={projectName}
        />
      </div>
      <div className="text-left lg:w-1/2">
        <h2 className="mb-4 text-4xl font-medium uppercase">
          WELCOME TO {projectName}
        </h2>
        <p className="mb-6 text-sm">
          {projectName} your gateway to luxurious diamonds welcomes you with
          open arms. Explore our exquisitecollection meticulously crafted to
          elevate your style and grace.Experience unparalleled elegance and
          sophistication.
        </p>
        <h2 className="mb-2 text-2xl font-normal">WE START AT 2022</h2>
        <p className="mb-6 text-sm">
          {projectName} commencing its journeyin 2022, stands as your premier
          destination for exquisite diamonds. Withunparalleled quality and
          service, explore our curated collection to find timeless elegance for
          every occasion.
        </p>
        <h2 className="mb-2 text-2xl font-normal">
          WIN BEST ONLINE SHOP AT 2022
        </h2>
        <p className="text-sm">
          {projectName} the proud recipient of the Best Online Shop award in
          2022, is your premier destination for exquisite diamonds. Explore our
          meticulously curated collection, crafted with passion and precision,
          to discover timeless elegance for every occasion.
        </p>
      </div>
    </div>
  );
}

export default AboutInfo;
