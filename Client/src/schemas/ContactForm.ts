import { z } from "zod"

export const contactSchema = z.object({
  name: z.string().nonempty({ message: "Name is required" }),
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email address" }),
  subject: z.string().nonempty({ message: "Subject is required" }),
  content: z.string().nonempty({ message: "Message is required" })
})
