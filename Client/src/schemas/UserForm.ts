import { z } from "zod";

export const userSchema = z.object({
  name: z.string().nonempty("Name is required"),
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
    .min(10, "Phone must be at least 10 characters long")
    .nonempty({ message: "Phone is required" })
    .regex(/^\d+$/, "Phone number must only contain digits")
    .refine((val) => val.startsWith("0") || val.startsWith("84"), {
      message: "Phone number must start with 0 or 84",
    }),
  address: z
    .string()
    .min(20, "Address must be at least 20 characters long")
    .nonempty("Address is required"),
});
