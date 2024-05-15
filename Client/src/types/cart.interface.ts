export enum ICartType {
  Jewelry = "Jewelry",
  Diamond = "Diamond",
}

export interface ICartBase {
  cartId: string;
  productType: ICartType;
  productId: string;
  quantity: number;
}

export interface IDiamondCart extends ICartBase {
  productType: ICartType.Diamond;
  diamondId: string;
  size: string;
  image: string;
  price: number;
}

export interface IJewelryCart extends ICartBase {
  productType: ICartType.Jewelry;
  jewelryId: string;
  jewelryName: string;
  image: string;
  price: number;
  jewelryCategory: string;
  mainStoneSize: string;
  sideStoneType: string;
  sideStoneQuantity: number;
  sideStoneWeight: number;
  goldType: string;
  goldKarat: string;
  goldWeight: string;
}

export type ICart = IDiamondCart | IJewelryCart;
