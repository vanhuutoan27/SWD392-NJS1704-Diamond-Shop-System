export interface IDiamond {
  diamondId: string;
  shape: string;
  weight: string;
  color: string;
  clarify: string;
  certification: string;
  size: string;
  fluorescence: string;
  qualityOfCut: string;
}

export const IDiamondShape = [
  {
    shapeName: "Diamond Round",
    shapeImage: "../../public/images/diamond_shape_round.jpg",
  },
  {
    shapeName: "Diamond Emerald",
    shapeImage: "../../public/images/diamond_shape_emerald.jpg",
  },
  {
    shapeName: "Diamond Heart",
    shapeImage: "../../public/images/diamond_shape_heat.jpg",
  },
  {
    shapeName: "Diamond Cushion",
    shapeImage: "../../public/images/diamond_shape_cushion.jpg",
  },
  {
    shapeName: "Diamond Pear",
    shapeImage: "../../public/images/diamond_shape_pear.jpg",
  },
];

export const IDiamondWeight = [
  "0.3 - 0.49",
  "0.5 - 0.89",
  "0.9 - 1.29",
  "1.3 - 1.9",
  "2.0 - 3.0",
  "Over 3.0",
];

export const IDiamondColor = ["D", "E", "F", "G", "H", "I", "J", "K", "L", "M"];

export const IDiamondClarify = [
  "IF",
  "VVS1",
  "VVS2",
  "VS1",
  "VS2",
  "SI1",
  "SI2",
  "I1",
  "I2",
];

export const IDiamondSize = [
  "4.3 - 4.9",
  "5.0 - 5.9",
  "6.0 - 6.9",
  "7.0 - 7.9",
  "8.0 - 8.9",
  "Over 9.0",
];
