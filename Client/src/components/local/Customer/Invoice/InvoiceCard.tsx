// eslint-disable-next-line @typescript-eslint/no-explicit-any
function InvoiceCard({ formattedInvoiceData }: { formattedInvoiceData: any }) {
  return (
    <div className="flex w-full justify-between text-base">
      <span>#{formattedInvoiceData.invoiceId}</span>
      <span className="mr-4 font-medium">
        {formattedInvoiceData.dateCreated}
      </span>
    </div>
  )
}

export default InvoiceCard
