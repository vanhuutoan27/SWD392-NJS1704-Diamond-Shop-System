export interface IInvoiceItem {
  productType: string;
  productId: string;
  skuID: string;
  quantity: number;
  description?: string;
  price?: number;
  total?: number;
}
