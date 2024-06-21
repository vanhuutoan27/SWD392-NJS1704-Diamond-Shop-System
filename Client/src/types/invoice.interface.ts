export interface IInvoiceItem {
  invoiceId: string
  userId:string
  orderId:string
  createDate:string
  amountDate:string
  invoiceAmount:string
  statusInvoice:number
  amountDue:string
  productType: string
  productId: string
  skuID: string
  quantity: number
  description?: string
  price?: number
  total?: number
}
