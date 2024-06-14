export interface IPromotion {
  id: string
  discountCode: string
  payAtLeast: number
  value: number
  dateToUse: string
  dateExpiration: string
  quantity: number
  description: string
  status: string
}
