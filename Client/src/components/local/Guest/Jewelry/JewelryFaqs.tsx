import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/global/atoms/accordion";
import Section from "@/components/global/organisms/Section";
import { projectName } from "@/lib/constants";

function JewelryFaqs() {
  return (
    <div className="mt-10">
      <Section pageName="FAQs" />

      <Accordion type="multiple">
        <AccordionItem value="item-1">
          <AccordionTrigger className="text-base">
            Why should you choose {projectName}?
          </AccordionTrigger>
          <AccordionContent>
            <ul className="list-disc pl-5">
              <h4 className="mb-1 text-base font-semibold">
                Diamond Jewelry At {projectName}
              </h4>
              <li className="text-secondary">
                Diverse Jewelry Designs, Personalized Design.
              </li>
              <li className="text-secondary">
                The Most Modern Inspection Technology Equipment.
              </li>
              <li className="text-secondary">
                Experience High-Class Diamond Service.
              </li>
            </ul>
            <ul className="mt-4 list-disc pl-5">
              <h4 className="mb-1 font-semibold">Diamonds At {projectName}</h4>
              <li className="text-secondary">
                Have GIA Accreditation certificate
              </li>
              <li className="text-secondary">VAT Invoice issued</li>
              <li className="text-secondary">Official Customs Import</li>
            </ul>
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-2">
          <AccordionTrigger className="text-base">
            Post-purchase service
          </AccordionTrigger>
          <AccordionContent>
            <ul className="list-disc pl-5">
              <li className="text-secondary">
                Free lifetime product polishing and renewing service.
              </li>
              <li className="text-secondary">
                Free 6-month warranty for technical errors and polish.
              </li>
              <li className="text-secondary">
                Free natural diamond testing service with advanced equipment
                from GIA.
              </li>
              <li className="text-secondary">
                Free adjustment of jewelry size (in case you need to compensate
                for additional gold for the product, you will bear the
                additional costs calculated based on the listed gold price)
              </li>
              <li className="text-secondary">
                Attractive purchasing and exchange policies.
              </li>
              <li className="text-secondary">
                Attractive preferential policies exclusively for member
                customers, VIP/VVIP.
              </li>
              <li className="text-secondary">
                Customer referral program with high discounts and exclusive
                incentives for referred customers.
              </li>
            </ul>
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-3">
          <AccordionTrigger className="text-base">
            Frequently asked questions
          </AccordionTrigger>
          <AccordionContent>
            <ul className="list-disc pl-5">
              <h4 className="mb-1 font-semibold">
                What if I receive the goods and the product is not of good
                quality?
              </h4>
              <li className="text-secondary">
                Customers please contact the consultant within 24 HOURS of
                receiving the product. {projectName} will support completely
                free exchange in case the product is defective due to
                manufacturing.
              </li>
            </ul>

            <ul className="mt-4 list-disc pl-5">
              <h4 className="mb-1 font-semibold">
                When shopping online, how do you know which ring size fits your
                hand?
              </h4>
              <li className="text-secondary">
                {projectName} will send a hand-measuring kit to your home
                completely free of charge. You just need to choose the right
                ring and notify our consultant. In addition, {projectName}{" "}
                supports lifetime free ring size adjustment in case you want to
                change.
              </li>
            </ul>

            <ul className="mt-4 list-disc pl-5">
              <h4 className="mb-1 font-semibold">
                Is there anything to prove I bought a {projectName} product?
              </h4>
              <li className="text-secondary">
                {projectName} products are guaranteed legal through the
                following 3 types of documents: sales invoice, sales contract
                and VAT invoice to ensure all customer rights.
              </li>
            </ul>

            <ul className="mt-4 list-disc pl-5">
              <h4 className="mb-1 font-semibold">
                Does {projectName} design products upon request?
              </h4>
              <li className="text-secondary">
                {projectName} is pleased to create unique jewelry designs with
                you. We are ready to listen to your ideas, sketch, complete and
                process according to your individual requirements.
              </li>
            </ul>
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-4">
          <AccordionTrigger className="text-base">
            Comments & reviews
          </AccordionTrigger>
          <AccordionContent>
            <ul className="mt-4 list-disc pl-5">
              <h4 className="mb-1 font-semibold">No comment</h4>
            </ul>
          </AccordionContent>
        </AccordionItem>
      </Accordion>
    </div>
  );
}

export default JewelryFaqs;
