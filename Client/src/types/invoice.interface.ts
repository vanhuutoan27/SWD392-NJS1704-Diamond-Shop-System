import { IOrder } from "./order.interface"
import { IUser } from "./user.interface"

export interface IInvoice {
  invoiceId: string
  userId: string
  orderId: string
  createDate: string
  amountDate?: string
  invoiceAmount?: number
  statusInvoice: number
  amountDue?: string
  order: IOrder
  user: IUser
}
