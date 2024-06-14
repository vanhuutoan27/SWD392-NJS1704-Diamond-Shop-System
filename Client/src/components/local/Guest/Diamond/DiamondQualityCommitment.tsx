import { ShieldCheck } from "lucide-react"

import { projectName } from "@/lib/constants"

import Section from "@/components/global/organisms/Section"

function QualityCommitment() {
  return (
    <div className="mt-10">
      <Section pageName={"Quality Commitments"} />

      <ul className="space-y-4">
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of {projectName}'s diamonds are selected with strict standards
            to ensure customers own diamonds that will last over time.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of diamonds are imported officially, ensuring customer assets
            are safe.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            100% of diamonds are assessed by the Gemological Institute of
            America (GIA), authenticating their quality.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            All diamond products at {projectName} have full invoices and
            documents proving their origin.
          </span>
        </li>
        <li className="flex items-start text-secondary">
          <ShieldCheck className="text-red-500" />
          <span className="ml-5">
            Reasonable purchasing and exchange policy, lifetime warranty policy
            for all diamond products at {projectName}.
          </span>
        </li>
      </ul>
    </div>
  )
}

export default QualityCommitment
