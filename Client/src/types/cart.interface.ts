export interface ICartBase {
  cartId: string;
  productType: string;
  productId: string;
  skuID: string;
  quantity: number;
  price: number;
  image: string;
}

export interface IDiamondCart extends ICartBase {
  productType: string;
  size: number;
}

export interface IJewelryCart extends ICartBase {
  productType: string;
  jewelryName: string;
}

export type ICart = IDiamondCart | IJewelryCart;
