import { z } from "zod"

export const diamondSchema = z.object({
  images: z.string().optional(),
  shape: z.string().min(1, { message: "Shape is required" }),
  weight: z.number().positive({ message: "Weight must be a positive number" }),
  colorLevel: z.string().min(1, { message: "Color Level is required" }),
  clarity: z.string().min(1, { message: "Clarity is required" }),
  certification: z.string().min(1, { message: "Certification is required" }),
  size: z.number().positive({ message: "Size must be a positive number" }),
  fluorescence: z.string().min(1, { message: "Fluorescence is required" }),
  qualityOfCut: z.string().min(1, { message: "Quality of Cut is required" }),
  price: z.number().positive({ message: "Price must be a positive number" })
})
