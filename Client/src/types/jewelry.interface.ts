import { ICartType } from "./cart.interface";

export interface IJewelry {
  productType: ICartType.Jewelry;
  jewelryId: string;
  jewelryCategory: string;
  jewelryName: string;
  image: string;
  price: number;
  mainStoneSize: string;
  sideStoneType: string;
  sideStoneQuantity: number;
  sideStoneWeight: number;
  goldType: string;
  goldKarat: string;
  goldWeight: string;
  status: IJewelryStatus;
}

export const enum IJewelryStatus {
  AVAILABLE = "Available",
  UNAVAILABLE = "Unavailable",
}
