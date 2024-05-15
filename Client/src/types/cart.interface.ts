export enum ICartType {
  Diamond = "Diamond",
  Jewelry = "Jewelry",
}

export interface ICartBase {
  cartId: string;
  productType: ICartType;
  productId: string;
  quantity: number;
  price?: number;
  image?: string;
}

export interface IDiamondCart extends ICartBase {
  productType: ICartType.Diamond;
  size: string;
}

export interface IJewelryCart extends ICartBase {
  productType: ICartType.Jewelry;
  jewelryName: string;
}

export type ICart = IDiamondCart | IJewelryCart;
