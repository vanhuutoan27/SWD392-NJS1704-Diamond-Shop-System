import { useEffect, useRef, useState } from "react"

import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { IOrder, OrderPaymentMethod, OrderStatus } from "@/types/order.interface"

import { useGetOrderById } from "@/apis/orderApi"

// import { formatCurrencyWithoutVND, formatDate } from "@/lib/utils"

import { Loader } from "@/components/global/atoms/Loader"
// import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"
// import {
//   Select,
//   SelectContent,
//   SelectGroup,
//   SelectItem,
//   SelectTrigger,
//   SelectValue
// } from "@/components/global/atoms/select"
// import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

function ViewOrderDialog({
  orderId,
  onClose
}: {
  orderId: string
  onClose: () => void
}) {
  const { data: orderDetails, isLoading, error } = useGetOrderById(orderId)

  const [isEditing, setIsEditing] = useState(false)
  const [formData, setFormData] = useState<IOrder>({
    orderId: "",
    total: 0,
    note: "",
    receiptDay: "",
    customerId: "",
    customerName: "",
    phone: "",
    email: "",
    address: "",
    orderStatus: OrderStatus.Pending,
    paymentMethod: OrderPaymentMethod.Deposit500,
    dateCreated: "",
    dateModified: "",
    status: false,
    items: []
  })

  const dialogRef = useRef<HTMLDivElement | null>(null)

  useEffect(() => {
    if (orderDetails) {
      setFormData({
        orderId: orderDetails.orderId || "", // Ensure orderId is initialized properly
        total: orderDetails.total || 0,
        note: orderDetails.note || "",
        receiptDay: orderDetails.receiptDay || "",
        customerId: orderDetails.customerId || "",
        customerName: orderDetails.customerName || "",
        phone: orderDetails.phone || "",
        email: orderDetails.email || "",
        address: orderDetails.address || "",
        orderStatus: orderDetails.orderStatus || OrderStatus.Pending,
        paymentMethod:
          orderDetails.paymentMethod || OrderPaymentMethod.Deposit500,
        dateCreated: orderDetails.dateCreated || "",
        dateModified: orderDetails.dateModified || "",
        status: orderDetails.status || false,
        items: orderDetails.items || []
      })
    }
  }, [orderDetails])

  const handleEditClick = () => {
    setIsEditing((prev) => !prev)
  }

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleSelectChange = (name: string, value: string) => {
    setFormData((prev) => ({ ...prev, [name]: value }))
  }

  const handleConfirmCancel = () => {
    if (orderDetails) {
      setFormData({
        orderId: orderDetails.orderId || "",
        total: orderDetails.total || 0,
        note: orderDetails.note || "",
        receiptDay: orderDetails.receiptDay || "",
        customerId: orderDetails.customerId || "",
        customerName: orderDetails.customerName || "",
        phone: orderDetails.phone || "",
        email: orderDetails.email || "",
        address: orderDetails.address || "",
        orderStatus: orderDetails.orderStatus || OrderStatus.Pending,
        paymentMethod:
          orderDetails.paymentMethod || OrderPaymentMethod.Deposit500,
        dateCreated: orderDetails.dateCreated || "",
        dateModified: orderDetails.dateModified || "",
        status: orderDetails.status || false,
        items: orderDetails.items || []
      })
    }
    setIsEditing(false)
  }

  if (!orderDetails || isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent ref={dialogRef} className="min-w-[1200px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Order Details
          </DialogTitle>
        </DialogHeader>
        <div>
          <div className="grid grid-cols-8 gap-4"></div>

          <div className="col-span-6">
            <div className="mb-4">
              <span className="ml-1 text-sm font-medium">Order ID</span>
              <input
                type="text"
                name="orderId"
                value={formData.orderId}
                readOnly
                className="input-field mt-1 w-full"
                tabIndex={-1}
              />
            </div>
            <div className="grid grid-cols-3 gap-4">
              <div>
                <span className="ml-1 text-sm font-medium">Customer Name</span>
                <input
                  type="text"
                  name="customerName"
                  value={formData.customerName}
                  onChange={handleChange}
                  readOnly={!isEditing}
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
          </div>
        </div>
      </DialogContent>
    </Dialog>
  )
}

export default ViewOrderDialog
