import { z } from "zod"

export const jewelrySchema = z.object({
  images: z.string().optional(),
  jewelryCategory: z.string().min(1, { message: "Category is required" }),
  mainStoneSize: z.string().min(1, { message: "Stone size is required" }),
  sideStoneType: z.string().min(1, { message: "Stone type is required" }),
  sideStoneQuantity: z
    .number()
    .positive({ message: "Stone quantity must be a positive number" }),
  stoneWeight: z
    .number()
    .positive({ message: "Stone weight must be a positive number" }),
  goldType: z.string().min(1, { message: "Gold type is required" }),
  goldKarat: z.string().min(1, { message: "Gold karat is required" }),
  goldWeight: z
    .number()
    .positive({ message: "Weight must be a positive number" }),
  price: z.number().positive({ message: "Price must be a positive number" })
})
