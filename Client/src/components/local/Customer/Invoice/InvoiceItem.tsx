import { useRef } from "react"

import { toPng } from "html-to-image"
import { jsPDF } from "jspdf"
import { toast } from "sonner"

import { IInvoice } from "@/types/invoice.interface"
import { IOrderProductItem } from "@/types/order.interface"

import { projectName } from "@/lib/constants"
import { formatCurrency } from "@/lib/utils"

import { Button } from "@/components/global/atoms/button"

interface InvoiceItemProps {
  invoiceItem: IInvoice
}

function InvoiceItem({ invoiceItem }: InvoiceItemProps) {
  const invoiceRef = useRef<HTMLDivElement>(null)

  const downloadPDF = () => {
    const input = invoiceRef.current
    if (input) {
      toPng(input, { cacheBust: true })
        .then((dataUrl) => {
          const pdf = new jsPDF("p", "mm", "a4")
          const pdfWidth = pdf.internal.pageSize.getWidth()
          const imgProps = pdf.getImageProperties(dataUrl)
          const pdfHeight = (imgProps.height * pdfWidth) / imgProps.width
          pdf.addImage(dataUrl, "PNG", 0, 0, pdfWidth, pdfHeight)
          pdf.save(`DIAMOON-${invoiceItem.invoiceId}.pdf`)
          toast.success("Downloaded PDF successfully!")
        })
        .catch((error) => {
          console.error("Error generating PDF: ", error)
        })
    }
  }

  return (
    <div className="rounded-md border-2 border-input shadow-md">
      <div className="flex w-full justify-end p-10 pb-0">
        <Button type="button" onClick={downloadPDF}>
          Download
        </Button>
      </div>

      <div className="p-10" ref={invoiceRef}>
        <div className="mb-10 flex justify-between gap-5">
          <div className="w-1/2">
            <p className="mb-1.5 font-medium">Billing From:</p>
            <h4 className="mb-3 text-xl font-semibold text-primary">
              {projectName}
            </h4>
            <p className="text-sm text-secondary">
              <span className="font-medium text-primary">Email: </span>
              diamoon.contact@gmail.com
            </p>
            <p className="mt-1.5 text-sm text-secondary">
              <span className="font-medium text-primary">Address: </span>
              Long Thanh My, Thu Duc City, Ho Chi Minh City, Vietnam
            </p>
          </div>

          <div className="w-1/2">
            <p className="mb-1.5 font-medium">Billing To:</p>
            <h4 className="mb-3 text-xl font-semibold text-primary">
              {invoiceItem.order.customerName}
            </h4>
            <p className="text-sm text-secondary">
              <span className="font-medium text-primary">Email: </span>
              {invoiceItem.order.email}
            </p>
            <p className="mt-1.5 text-sm text-secondary">
              <span className="font-medium text-primary">Address: </span>
              {invoiceItem.order.address}
            </p>
          </div>
        </div>

        <div className="mb-10 grid grid-cols-1 rounded-md border-2 border-input sm:grid-cols-3">
          <div className="border-r-2 border-input px-5 py-4">
            <h5 className="mb-1.5 font-semibold">Invoice ID:</h5>
            <span className="text-sm font-medium">{invoiceItem.invoiceId}</span>
          </div>
          <div className="border-r-2 border-input px-5 py-4">
            <h5 className="mb-1.5 font-semibold">Date Created:</h5>
            <span className="text-sm font-medium">
              {invoiceItem.order.dateCreated}
            </span>
          </div>
          <div className="border-input px-5 py-4">
            <h5 className="mb-1.5 font-semibold">Date of Receipt:</h5>
            <span className="text-sm font-medium">
              {invoiceItem.order.receiptDay}
            </span>
          </div>
        </div>

        <div className="grid grid-cols-12 rounded-t-md border-2 border-input py-3.5 pl-5 pr-6">
          <div className="col-span-2">
            <h5 className="font-semibold">ID</h5>
          </div>
          <div className="col-span-4">
            <h5 className="font-semibold">Name</h5>
          </div>
          <div className="col-span-2">
            <h5 className="font-semibold">Quantity</h5>
          </div>
          <div className="col-span-2">
            <h5 className="font-semibold">Price Per Unit</h5>
          </div>
          <div className="col-span-2">
            <h5 className="font-semibold">Total</h5>
          </div>
        </div>

        {invoiceItem.order.items.map((item: IOrderProductItem, index) => (
          <div
            key={index}
            className={`grid grid-cols-12 border-2 border-t-0 border-input py-3.5 pl-5 pr-6 ${
              index === invoiceItem.order.items.length - 1 && "rounded-b-md"
            }`}
          >
            <div className="col-span-2">
              <p className="text-sm font-medium text-secondary">
                {item.productId}
              </p>
            </div>
            <div className="col-span-4">
              <p className="text-sm font-medium text-secondary"></p>
            </div>
            <div className="col-span-2">
              <p className="text-sm font-medium text-secondary">
                {item.quantity}
              </p>
            </div>
            <div className="col-span-2">
              <p className="text-sm font-medium text-secondary">
                {formatCurrency(item.unitPrice)}
              </p>
            </div>
            <div className="col-span-2">
              <p className="text-sm font-medium text-secondary">
                {formatCurrency(item.quantity * item.unitPrice)}
              </p>
            </div>
          </div>
        ))}

        <div className="mt-10">
          <div className="flex justify-between px-4">
            <div className="w-1/2"></div>
            <div className="flex w-1/2 flex-col gap-4">
              <p className="flex justify-between font-medium">
                <span>Subtotal</span>
                <span>
                  {formatCurrency(
                    invoiceItem.order.total - invoiceItem.order.total * 0.1
                  )}
                </span>
              </p>
              <p className="flex justify-between font-medium">
                <span>
                  Coupon Discount <span className="text-meta-3">(0%)</span>
                </span>
                <span>{invoiceItem.order.discount || "0 VND"}</span>
              </p>
              <p className="flex justify-between font-medium">
                <span>
                  Vat <span className="text-red">(10%)</span>
                </span>
                <span>{formatCurrency(invoiceItem.order.total * 0.1)}</span>
              </p>
              <p className="flex justify-between">
                <span className="font-medium">Total</span>
                <span className="text-meta-3 font-semibold">
                  {formatCurrency(invoiceItem.order.total)}
                </span>
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default InvoiceItem
