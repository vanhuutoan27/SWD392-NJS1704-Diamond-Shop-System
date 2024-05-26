import { ICartType } from "./cart.interface";

export interface IInvoiceItem {
  productType: ICartType;
  productId: string;
  quantity: number;
  description?: string;
  price?: number;
  total?: number;
}
