import { Dispatch, SetStateAction } from "react"

export interface IOrder {
  orderId: string
  total: number
  note: string
  receiptDay: string
  customerId: string
  customerName: string
  phone: string
  email: string
  address: string
  orderStatus: OrderStatus
  paymentMethod: OrderPaymentMethod
  dateCreated: string
  dateModified: string
  status: boolean
  items: OrderProductItem[]
}

export enum OrderStatus {
  Pending = 0,
  Processing = 1,
  Shipping = 2,
  Completed = 3,
  Cancelled = 4
}

export interface IOrderPost {
  products: OrderProductItem[]
  total: number
  note: string
  receiptDay: string
  customerId: string
  customerName: string
  phone: string
  email: string
  address: string
  province: string
  district: string
  ward: string
  paymentMethod: OrderPaymentMethod
}

export enum OrderPaymentMethod {
  Deposit500 = 0,
  Deposit1000 = 1,
  Deposit1500 = 2,
  Deposit2000 = 3,
  BankTransfer = 4,
  CreditCard = 5
}

export interface OrderProductItem {
  orderItemId?: string
  productId: string
  quantity: number
  unitPrice: number
  images?: string[]
}

export interface Province {
  id: string
  full_name: string
}

export interface District {
  id: string
  full_name: string
}

export interface Ward {
  id: string
  full_name: string
}
export interface InformationFormProps {
  formData: IOrderPost
  setFormData: (data: IOrderPost) => void
  provinces: Province[]
  setProvinces: (provinces: Province[]) => void
  districts: District[]
  setDistricts: (districts: District[]) => void
  wards: Ward[]
  setWards: (wards: Ward[]) => void
  errors: Partial<Record<keyof IOrderPost, { _errors: string[] }>>
  setErrors: Dispatch<
    SetStateAction<Partial<Record<keyof IOrderPost, { _errors: string[] }>>>
  >
}

export interface PaymentFormProps {
  formData: IOrderPost
  provinces: Province[]
  districts: District[]
  wards: Ward[]
  selectedPaymentMethod: OrderPaymentMethod
  setSelectedPaymentMethod: Dispatch<SetStateAction<OrderPaymentMethod>>
  paymentError: string
  setTab: Dispatch<SetStateAction<number>>
}
