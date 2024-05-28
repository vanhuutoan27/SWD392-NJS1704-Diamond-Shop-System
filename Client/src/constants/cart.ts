import { getProductData } from "@/lib/utils";
import { ICart, ICartType } from "@/types/cart.interface";

const rawCartData: Omit<ICart, "price" | "image" | "size" | "jewelryName">[] = [
  {
    cartId: "CD001",
    productType: ICartType.Diamond,
    productId: "D001",
    quantity: 1,
  },
  {
    cartId: "CD002",
    productType: ICartType.Diamond,
    productId: "D002",
    quantity: 2,
  },
  {
    cartId: "CJ003",
    productType: ICartType.Jewelry,
    productId: "J002",
    quantity: 1,
  },
];

export const cartData = rawCartData.map((item) => {
  const productData = getProductData(item as ICart);
  return { ...item, ...productData } as ICart;
});
