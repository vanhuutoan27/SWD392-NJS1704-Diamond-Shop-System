import { useEffect, useRef, useState } from "react"

import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import {
  IOrder,
  IOrderPaymentMethod,
  OrderStatus
} from "@/types/order.interface"

import { useGetOrderById } from "@/apis/orderApi"

import { formatCurrency, formatDate, getPaymentMethodString } from "@/lib/utils"

import { Loader } from "@/components/global/atoms/Loader"
import { Button } from "@/components/global/atoms/button"
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle
} from "@/components/global/atoms/dialog"
import { ScrollArea } from "@/components/global/atoms/scroll-area"
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectTrigger,
  SelectValue
} from "@/components/global/atoms/select"
import AlertDialogComponent from "@/components/global/molecules/AlertDialogComponent"

function ViewOrderDialog({
  orderId,
  onClose
}: {
  orderId: string
  onClose: () => void
}) {
  const { data: orderDetails, isLoading, error } = useGetOrderById(orderId)

  console.log(orderDetails)

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
    paymentMethod: IOrderPaymentMethod.BankTransfer,
    dateCreated: "",
    dateModified: "",
    status: false,
    items: [
      {
        orderItemId: "",
        productId: "",
        productType: "",
        skuId: "",
        images: [],
        quantity: 0,
        unitPrice: 0
      }
    ]
  })

  const dialogRef = useRef<HTMLDivElement | null>(null)

  useEffect(() => {
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
          orderDetails.paymentMethod || IOrderPaymentMethod.Deposit500,
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

  const handleSelectChange = (name: string, value: OrderStatus) => {
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
          orderDetails.paymentMethod || IOrderPaymentMethod.Deposit500,
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

  const OrderStatusStrings = Object.keys(OrderStatus).filter((key) =>
    isNaN(Number(key))
  )

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent ref={dialogRef} className="min-w-[1200px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Order Details
          </DialogTitle>
        </DialogHeader>
        <ScrollArea className="max-h-[70vh] p-4">
          <div className="grid grid-cols-5 gap-4">
            <div className="col-span-2">
              <div>
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
            </div>

            <div className="col-span-1">
              <div>
                <span className="ml-1 text-sm font-medium">Date Created</span>
                <input
                  type="text"
                  name="dateCreated"
                  value={formatDate(formData.dateCreated)}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-1">
              <div>
                <span className="ml-1 text-sm font-medium">Date Modified</span>
                <input
                  type="text"
                  name="dateModified"
                  value={formatDate(formData.dateModified)}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>

            <div className="col-span-1">
              <div>
                <span className="ml-1 text-sm font-medium">Date Receipt</span>
                <input
                  type="text"
                  name="receiptDay"
                  value={formatDate(formData.receiptDay)}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
          </div>

          <div className="grid grid-cols-8 gap-4">
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Customer</span>
                <input
                  type="text"
                  name="customerName"
                  value={formData.customerName}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Phone</span>
                <input
                  type="text"
                  name="phone"
                  value={formData.phone}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Email</span>
                <input
                  type="text"
                  name="email"
                  value={formData.email}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Address</span>
                <input
                  type="text"
                  name="address"
                  value={formData.address}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
          </div>

          <div className="grid grid-cols-8 gap-4">
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Note</span>
                <input
                  type="text"
                  name="note"
                  value={formData.note}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Payment Method</span>
                <input
                  type="text"
                  name="paymentMethod"
                  value={getPaymentMethodString(formData.paymentMethod)}
                  readOnly
                  className="input-field mt-1 w-full"
                  tabIndex={-1}
                />
              </div>
            </div>
            <div className="col-span-2">
              <div>
                <span className="ml-1 text-sm font-medium">Total</span>
                <input
                  type="text"
                  name="total"
                  value={formatCurrency(formData.total)}
                  readOnly
                  className="input-field mt-1 w-full"
                  tabIndex={-1}
                />
              </div>
            </div>

            <div className="col-span-2">
              <span className="ml-1 text-sm font-medium">Status</span>
              {isEditing ? (
                <Select
                  value={OrderStatus[formData.orderStatus]}
                  onValueChange={(value) =>
                    handleSelectChange(
                      "orderStatus",
                      OrderStatus[value as keyof typeof OrderStatus]
                    )
                  }
                >
                  <SelectTrigger className="mt-1 h-11 w-full px-5">
                    <SelectValue placeholder="Select order status" />
                  </SelectTrigger>
                  <SelectContent>
                    <SelectGroup>
                      {OrderStatusStrings.map((status) => (
                        <SelectItem key={status} value={status}>
                          {status}
                        </SelectItem>
                      ))}
                    </SelectGroup>
                  </SelectContent>
                </Select>
              ) : (
                <input
                  type="text"
                  name="orderStatus"
                  value={OrderStatus[formData.orderStatus]}
                  readOnly
                  className="input-field mt-1"
                  tabIndex={-1}
                />
              )}
            </div>
          </div>

          <table className="mt-4 min-w-full border border-gray-200 bg-white ">
            <thead>
              <tr className="grid grid-cols-8 gap-4 border-b">
                <th className="col-span-2 py-2 text-sm font-medium">
                  Product Id
                </th>
                <th className="col-span-2 py-2 text-sm font-medium">Images</th>
                <th className="col-span-2 py-2 text-sm font-medium">
                  Quantity
                </th>
                <th className="col-span-2 py-2 text-sm font-medium">
                  Unit Price
                </th>
              </tr>
            </thead>
            <tbody>
              {formData.items?.length > 0 ? (
                formData.items.map((item, index) => (
                  <tr key={index} className="grid grid-cols-8 gap-4 border-b">
                    <td className="col-span-2 content-center px-4 py-2 text-center text-sm font-medium">
                      {item.skuId}
                    </td>
                    <td className="col-span-2 flex content-center items-center justify-center px-4 py-2">
                      {item.images && item.images.length > 0 ? (
                        <img
                          key={0}
                          src={item.images[0]}
                          alt={`Product ${index + 1} Image 1`}
                          className="mr-2 inline-block h-16 w-16 object-cover"
                        />
                      ) : (
                        "No images"
                      )}
                    </td>
                    <td className="col-span-2 content-center px-4 py-2 text-center text-sm font-medium">
                      {item.quantity}
                    </td>
                    <td className="col-span-2 content-center px-4 py-2 text-center text-sm font-medium">
                      {formatCurrency(item.unitPrice)}
                    </td>
                  </tr>
                ))
              ) : (
                <tr>
                  <td className="px-4 py-2 text-center">No items found.</td>
                </tr>
              )}
            </tbody>
          </table>
        </ScrollArea>

        <div className="mt-4 flex justify-between gap-4">
          <div className="flex justify-between gap-4">
            <Button type="button" onClick={handleEditClick}>
              {isEditing ? "Save" : "Edit"}
            </Button>
            {isEditing && (
              <AlertDialogComponent
                variant="secondary"
                actionBtn="Cancel"
                title="Discard changes?"
                description="You have unsaved changes. Are you sure you want to discard them?"
                action="Discard"
                onConfirm={handleConfirmCancel}
              />
            )}
          </div>
          <Button type="button" onClick={onClose}>
            Close
          </Button>
        </div>
      </DialogContent>
    </Dialog>
  )
}

export default ViewOrderDialog
