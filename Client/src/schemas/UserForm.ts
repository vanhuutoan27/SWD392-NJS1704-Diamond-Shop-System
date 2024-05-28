import { z } from "zod";

export const userSchema = z.object({
  name: z.string().nonempty({ message: "Name is required" }),
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
  phone: z
    .string()
    .nonempty({ message: "Phone is required" })
    .regex(/^\d+$/, { message: "Phone number must only contain digits" })
    .min(10, { message: "Phone must be at least 10 characters long" })
    .refine((val) => val.startsWith("0") || val.startsWith("84"), {
      message: "Phone number must start with 0 or 84",
    }),
  address: z
    .string()
    .nonempty({ message: "Address is required" })
    .min(20, { message: "Address must be at least 20 characters long" }),
  role: z.string().nonempty({ message: "Role is required" }),
});
