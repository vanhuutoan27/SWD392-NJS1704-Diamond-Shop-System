import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/global/atoms/accordion";

import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";
import { userData } from "@/constants/user";
import { formatInvoiceData, getProductData } from "@/lib/utils";
import { ICart, ICartType } from "@/types/cart.interface";
import { useParams } from "react-router-dom";
import { vatPercentage, shippingCost } from "@/lib/constants";
import InvoiceCard from "@/components/local/Customer/Invoice/InvoiceCard";
import InvoiceItem from "@/components/local/Customer/Invoice/InvoiceItem";

function InvoicePage() {
  const { userId } = useParams<{ userId: string }>();

  const billingToUser = userData.find((u) => u.userId === userId);

  const invoiceData = {
    invoiceId: "DIAMOON27082003",
    dateIssued: "25 May 2024",
    dueDate: "25 Jun 2024",
    billingTo: billingToUser,
    items: [
      {
        productType: ICartType.Diamond,
        productId: "D002",
        quantity: 1,
      },
      {
        productType: ICartType.Jewelry,
        productId: "J002",
        quantity: 3,
      },
      {
        productType: ICartType.Jewelry,
        productId: "J003",
        quantity: 1,
      },
    ] as ICart[],
  };

  // Map items with product data
  const mappedItems = invoiceData.items.map((item) => {
    const productData = getProductData(item as ICart);
    return {
      ...item,
      description: productData
        ? "jewelryName" in productData
          ? productData.jewelryName
          : `KIM CƯƠNG TỰ NHIÊN x ${productData.size}MM`
        : "",
      price: productData?.price || 0,
      total: (productData?.price || 0) * item.quantity,
    };
  });

  const formattedInvoiceData = formatInvoiceData(
    { ...invoiceData, items: mappedItems },
    vatPercentage,
    shippingCost,
  );

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="Invoices"
      />

      <Section pageName="Invoices" />

      <Accordion
        type="single"
        collapsible
        className="flex w-full flex-col gap-4"
      >
        <AccordionItem value="item-1">
          <div className="rounded-md border-2 border-input px-10 py-2 shadow-md">
            <AccordionTrigger>
              <InvoiceCard formattedInvoiceData={formattedInvoiceData} />
            </AccordionTrigger>
          </div>
          <AccordionContent>
            <InvoiceItem
              formattedInvoiceData={formattedInvoiceData}
              billingToUser={billingToUser}
            />
          </AccordionContent>
        </AccordionItem>

        <AccordionItem value="item-2">
          <div className="rounded-md border-2 border-input px-10 py-2 shadow-md">
            <AccordionTrigger>
              <InvoiceCard formattedInvoiceData={formattedInvoiceData} />
            </AccordionTrigger>
          </div>
          <AccordionContent>
            <InvoiceItem
              formattedInvoiceData={formattedInvoiceData}
              billingToUser={billingToUser}
            />
          </AccordionContent>
        </AccordionItem>

        <AccordionItem value="item-3">
          <div className="rounded-md border-2 border-input px-10 py-2 shadow-md">
            <AccordionTrigger>
              <InvoiceCard formattedInvoiceData={formattedInvoiceData} />
            </AccordionTrigger>
          </div>
          <AccordionContent>
            <InvoiceItem
              formattedInvoiceData={formattedInvoiceData}
              billingToUser={billingToUser}
            />
          </AccordionContent>
        </AccordionItem>
      </Accordion>
    </div>
  );
}

export default InvoicePage;
