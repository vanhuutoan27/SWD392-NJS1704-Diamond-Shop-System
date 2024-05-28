import { z } from "zod";

export const informationSchema = z.object({
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email" }),
  fullName: z.string().nonempty({ message: "Full name is required" }),
  streetAddress: z.string().nonempty({ message: "Street address is required" }),
  city: z.string().nonempty({ message: "City is required" }),
  country: z.string().nonempty({ message: "Country is required" }),
  state: z.string().nonempty({ message: "State is required" }),
  zipCode: z.string().nonempty({ message: "ZIP code is required" }),
});
