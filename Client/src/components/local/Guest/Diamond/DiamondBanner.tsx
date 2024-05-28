import { projectName } from "@/lib/constants";

function DiamondBanner() {
  return (
    <div className="mt-10 flex w-full gap-4">
      <div className="w-1/2">
        <img
          src="https://images.unsplash.com/photo-1588444650733-d0767b753fc8?q=80&w=1798&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
          alt={projectName}
          className="h-[230px] w-full rounded-md object-cover"
        />
      </div>
      <div className="w-1/2">
        <img
          src="https://images.unsplash.com/photo-1631013636761-c533d81e96a4?q=80&w=1929&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
          alt={projectName}
          className="h-[230px] w-full rounded-md object-cover"
        />
      </div>
    </div>
  );
}

export default DiamondBanner;
