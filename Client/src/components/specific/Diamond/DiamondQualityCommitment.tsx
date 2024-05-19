import { ShieldCheck } from "lucide-react";
import Section from "../../organisms/Section";
import { projectName } from "@/lib/constants";

function QualityCommitment() {
  return (
    <div className="mt-10">
      <Section pageName={"Quality Commitments"} />

      <ul className="space-y-4">
        <li className="flex items-start text-[#908e9b]">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of {projectName}'s diamonds are selected with strict standards
            to ensure customers own diamonds that will last over time.
          </span>
        </li>
        <li className="flex items-start text-[#908e9b]">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of diamonds are imported officially, ensuring customer assets
            are safe.
          </span>
        </li>
        <li className="flex items-start text-[#908e9b]">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of diamonds are assessed by the Gemological Institute of
            America (GIA), authenticating their quality.
          </span>
        </li>
        <li className="flex items-start text-[#908e9b]">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            All diamond products at {projectName} have full invoices and
            documents proving their origin.
          </span>
        </li>
        <li className="flex items-start text-[#908e9b]">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            Reasonable purchasing and exchange policy, lifetime warranty policy
            for all diamond products at {projectName}.
          </span>
        </li>
      </ul>
    </div>
  );
}

export default QualityCommitment;