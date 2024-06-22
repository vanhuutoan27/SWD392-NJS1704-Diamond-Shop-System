import { IInvoice } from "@/types/invoice.interface"

import { formatDate } from "@/lib/utils"

function InvoiceCard({ invoiceItem }: { invoiceItem: IInvoice }) {
  return (
    <div className="flex w-full justify-between text-base">
      <span>#{invoiceItem.invoiceId}</span>
      <span className="mr-4 font-medium">
        {formatDate(invoiceItem.createDate)}
      </span>
    </div>
  )
}

export default InvoiceCard
