import { ShieldCheck } from "lucide-react";
import Section from "../../organisms/Section";
import { projectName } from "@/lib/constants";

function JewelryQualityCommitment() {
  return (
    <div className="mt-10">
      <Section pageName={"Quality Commitments"} />

      <ul className="space-y-4">
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            All jewelry is completely accurate in terms of gold content and
            weight, strictly tested by spectroscopy.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of diamond jewelry is certified to meet GIA standards.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            All jewelry products at {projectName} have full invoices and
            documents proving origin and full information about gold content and
            weight.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            All jewelry products at Jemmia have full invoices and documents
            proving origin and full information about gold content and weight.
          </span>
        </li>
      </ul>
    </div>
  );
}

export default JewelryQualityCommitment;
