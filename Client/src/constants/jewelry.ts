import { ICartType } from "@/types/cart.interface";
import { IJewelry, IJewelryStatus } from "@/types/jewelry.interface";

export const jewelryData: IJewelry[] = [
  {
    productType: ICartType.Jewelry,
    jewelryId: "J002",
    jewelryCategory: "Earrings",
    jewelryName: "18K DIAMOND EARRINGS",
    image: "https://jemmia.vn/wp-content/uploads/2024/04/1-copy-8.jpg",
    image2: "https://jemmia.vn/wp-content/uploads/2024/04/1-copy-8.jpg",
    mainStoneSize: "Round 5ly",
    sideStoneType: "Diamond",
    sideStoneQuantity: 36,
    sideStoneWeight: 0.18,
    goldType: "White gold",
    goldKarat: "18K",
    goldWeight: "0.86",
    price: 20210400,
    status: IJewelryStatus.Available,
  },
];
