import { z } from "zod";

export const informationSchema = z.object({
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email" }),
  fullName: z.string().nonempty({ message: "Full name is required" }),
  phoneNumber: z
    .string()
    .nonempty({ message: "Phone number is required" })
    .regex(/^[0-9]+$/, { message: "Invalid phone number" }),
  address: z.string().nonempty({ message: "Address is required" }),
  province: z.string().nonempty({ message: "Province is required" }),
  district: z.string().nonempty({ message: "District is required" }),
  ward: z.string().nonempty({ message: "Ward is required" }),
});
