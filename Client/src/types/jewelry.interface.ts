export interface IJewelry {
  jewelryId: string;
  name: string;
  manufacturer: string;
  description: string;
  price: number;
  createdOn: string;
  status: IJewelryStatus;
}

export enum IJewelryStatus {
  Available = 0,
  OutOfStock = 1,
  Discontinued = 2,
}
