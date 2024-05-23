import { z } from "zod";

export const userSchema = z.object({
  name: z.string().nonempty("Name is required"),
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email address" }),
  password: z.string().nonempty("Password is required"),
  phone: z.string().nonempty("Phone number is required"),
  address: z
    .string()
    .length(20, "Address must be at least 20 characters")
    .nonempty("Address is required"),
});
