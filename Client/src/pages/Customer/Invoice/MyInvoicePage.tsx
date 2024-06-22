import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetAllDiamonds } from "@/apis/diamondApi"
import { useGetAllInvoices } from "@/apis/invoiceApi"
import { useGetAllJewelries } from "@/apis/jewelryApi"

import { Loader } from "@/components/global/atoms/Loader"
import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger
} from "@/components/global/atoms/accordion"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import InvoiceCard from "@/components/local/Customer/Invoice/InvoiceCard"
import InvoiceItem from "@/components/local/Customer/Invoice/InvoiceItem"

function MyInvoicePage() {
  // const { userId } = useParams<{ userId: string }>()

  const {
    data: allUserInvoices,
    error: isInvoicesError,
    isLoading: isInvoicesLoading
  } = useGetAllInvoices()

  const {
    data: allDiamonds,
    error: isDiamondsError,
    isLoading: isDiamondsLoading
  } = useGetAllDiamonds()

  const {
    data: allJewelries,
    error: isJewelriesError,
    isLoading: isJewelriesLoading
  } = useGetAllJewelries()

  if (
    !allUserInvoices ||
    !allDiamonds ||
    !allJewelries ||
    isInvoicesLoading ||
    isDiamondsLoading ||
    isJewelriesLoading
  ) {
    return <Loader />
  }

  if (isInvoicesError || isDiamondsError || isJewelriesError) {
    return <NotFoundPage />
  }

  return (
    <div className="container mx-auto px-4 py-8">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="User"
        currentDetailPage="My Invoices"
      />

      <Section pageName="Diamoon Invoices" />

      <Accordion
        type="single"
        collapsible
        className="flex w-full flex-col gap-4"
      >
        {allUserInvoices.map((invoiceItem) => (
          <AccordionItem
            value={`item-${invoiceItem.invoiceId}`}
            key={invoiceItem.invoiceId}
          >
            <div className="rounded-md border-2 border-input px-10 py-2 shadow-md">
              <AccordionTrigger>
                <InvoiceCard invoiceItem={invoiceItem} />
              </AccordionTrigger>
            </div>
            <AccordionContent>
              <InvoiceItem invoiceItem={invoiceItem} />
            </AccordionContent>
          </AccordionItem>
        ))}
      </Accordion>
    </div>
  )
}

export default MyInvoicePage
