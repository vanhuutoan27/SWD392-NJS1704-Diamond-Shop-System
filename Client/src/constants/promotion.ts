import { IPromotion } from "@/types/promotion.interface"

export const promotionData: IPromotion[] = [
  {
    id: "1",
    discountCode: "BackToSchool",
    payAtLeast: 2000000,
    value: 50,
    dateToUse: "2024-08-15T00:00:00.000Z",
    dateExpiration: "2024-09-15T00:00:00.000Z",
    quantity: 30,
    description:
      "Get ready for school with our exclusive back-to-school discount",
    status: "Active"
  },
  {
    id: "2",
    discountCode: "SummerSale",
    payAtLeast: 5000000,
    value: 15,
    dateToUse: "2024-06-01T00:00:00.000Z",
    dateExpiration: "2024-07-01T00:00:00.000Z",
    quantity: 50,
    description: "Celebrate the summer with our special discount",
    status: "Active"
  },
  {
    id: "3",
    discountCode: "Valentine'sDay",
    payAtLeast: 10000000,
    value: 20,
    dateToUse: "2024-05-24T00:00:00.000Z",
    dateExpiration: "2024-06-24T00:00:00.000Z",
    quantity: 34,
    description:
      "On the occasion of Valentine's Day, we want to express gratitude to customers",
    status: "Active"
  },
  {
    id: "4",
    discountCode: "BlackFriday",
    payAtLeast: 15000000,
    value: 25,
    dateToUse: "2024-11-25T00:00:00.000Z",
    dateExpiration: "2024-11-30T00:00:00.000Z",
    quantity: 100,
    description: "Enjoy massive discounts on Black Friday",
    status: "Inactive"
  }
]
