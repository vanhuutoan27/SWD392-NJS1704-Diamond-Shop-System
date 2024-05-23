import { z } from "zod";

export const registerSchema = z.object({
  name: z.string().nonempty({ message: "Full name is required" }),
  email: z
    .string()
    .nonempty({ message: "Email is required" })
    .email({ message: "Invalid email address" }),
  password: z
    .string()
    .nonempty({ message: "Password is required" })
    .min(6, { message: "Password must be at least 6 characters long" })
    .refine((value) => /[A-Z]/.test(value), {
      message: "Password must contain at least one uppercase letter (A-Z)",
    })
    .refine((value) => /[a-z]/.test(value), {
      message: "Password must contain at least one lowercase letter (a-z)",
    })
    .refine((value) => /[0-9]/.test(value), {
      message: "Password must contain at least one number (0-9)",
    })
    .refine((value) => /[^a-zA-Z0-9]/.test(value), {
      message: "Password must contain at least one special character",
    }),
});
