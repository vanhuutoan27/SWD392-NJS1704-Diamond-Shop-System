export interface IDiamond {
  productType: string
  diamondId: string
  skuID: string
  image: string
  shape: string
  weight: number
  colorLevel: string
  clarity: string
  certification: string
  size: number
  fluorescence: string
  qualityOfCut: string
  price: number
  dateCreated: string
  dateModified: string
  status: string
}

export interface IDiamondPost {
  shape: string
  weight: number
  colorLevel: string
  clarity: string
  certification: string
  size: number
  fluorescence: string
  qualityOfCut: string
  price: number
}

export const IDiamondShape = [
  {
    shapeName: "Round",
    shapeImage: "../images/diamond_shape_round.jpg"
  },
  {
    shapeName: "Emerald",
    shapeImage: "../images/diamond_shape_emerald.jpg"
  },
  {
    shapeName: "Heart",
    shapeImage: "../images/diamond_shape_heat.jpg"
  },
  {
    shapeName: "Cushion",
    shapeImage: "../images/diamond_shape_cushion.jpg"
  },
  {
    shapeName: "Pear",
    shapeImage: "../images/diamond_shape_pear.jpg"
  }
]

export const IDiamondWeight = [
  "0.3 - 0.49",
  "0.5 - 0.89",
  "0.9 - 1.29",
  "1.3 - 1.9",
  "2.0 - 3.0",
  "Over 3.0"
]

export const IDiamondColor = ["D", "E", "F", "G", "H", "I", "J", "K", "L", "M"]

export const IDiamondClarity = [
  "IF",
  "VVS1",
  "VVS2",
  "VS1",
  "VS2",
  "VS3",
  "SI1",
  "SI2",
  "I1"
  // "I2",
]

export const IDiamondSize = [
  "4.3 - 4.9",
  "5.0 - 5.9",
  "6.0 - 6.9",
  "7.0 - 7.9",
  "8.0 - 8.9",
  "Over 9.0"
]

export const IDiamondCertification = ["GIA", "IGI", "HRD", "AGS", "EGL"]

export const IDiamondFluorescence = ["NONE", "FAINT", "MEDIUM", "STRONG"]

export const IDiamondQualityOfCut = [
  "Excellent",
  "Very Good",
  "Good",
  "Fair",
  "Poor"
]
