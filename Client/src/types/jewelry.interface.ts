export interface IJewelry {
  productType: string
  jewelryId: string
  skuID: string
  images: string[]
  jewelryCategory: string
  jewelryName: string
  mainStoneSize: string
  sideStoneType: string
  sideStoneQuantity: number
  stoneWeight: number
  goldType: string
  goldKarat: string
  goldWeight: number
  price: number
  dateModified: string
  dateCreated: string
  status: number
}

export interface IJewelryPost {
  name: string
  mainStoneSize: string
  sideStoneType: string
  sideStoneQuantity: number
  stoneWeight: number
  goldType: string
  goldKarat: string
  goldWeight: number
  price: number
  images: string[]
}
