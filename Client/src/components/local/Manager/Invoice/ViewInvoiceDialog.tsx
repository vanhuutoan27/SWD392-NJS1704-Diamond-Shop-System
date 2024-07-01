import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import "@/apis/invoiceApi"
import { useGetInvoiceById } from "@/apis/invoiceApi"

import { Loader } from "@/components/global/atoms/Loader"
import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"

import InvoiceItem from "../../Customer/Invoice/InvoiceItem"

function ViewInvoiceDialog({
  invoiceId,
  onClose
}: {
  invoiceId: string
  onClose: () => void
}) {
  const {
    data: invoiceDetails,
    isLoading,
    error
  } = useGetInvoiceById(invoiceId)

  if (!invoiceDetails || isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent className="min-w-[800px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View InVoice Details
          </DialogTitle>
        </DialogHeader>
        <div className="mt-4">
          <InvoiceItem invoiceItem={invoiceDetails} />

          <div className="mt-4 flex justify-between gap-4">
            <Button type="button" onClick={onClose}>
              Close
            </Button>
          </div>
        </div>
      </DialogContent>
    </Dialog>
  )
}

export default ViewInvoiceDialog
