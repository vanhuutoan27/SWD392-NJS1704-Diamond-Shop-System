import { z } from "zod";

export const registerSchema = z.object({
  fullName: z.string().nonempty({ message: "Full name is required" }),
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email address" }),
  password: z.string().nonempty({ message: "Password is required" }),
});
