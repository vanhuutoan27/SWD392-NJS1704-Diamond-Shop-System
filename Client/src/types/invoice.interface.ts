export interface IInvoiceItem {
  productType: string;
  productId: string;
  quantity: number;
  description?: string;
  price?: number;
  total?: number;
}
