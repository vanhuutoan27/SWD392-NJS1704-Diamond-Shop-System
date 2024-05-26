function InvoiceCard({ formattedInvoiceData }: { formattedInvoiceData: any }) {
  return (
    <div className="flex w-full justify-between text-base">
      <span>#{formattedInvoiceData.invoiceId}</span>
      <span className="mr-4 font-medium">
        {formattedInvoiceData.dateIssued}
      </span>
    </div>
  );
}

export default InvoiceCard;
