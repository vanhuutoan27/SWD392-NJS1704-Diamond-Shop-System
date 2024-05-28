import * as React from "react";
import { Slot } from "@radix-ui/react-slot";
import { cva, type VariantProps } from "class-variance-authority";

import { cn } from "@/lib/utils";

const buttonVariants = cva(
  "inline-flex items-center justify-center whitespace-nowrap rounded-md text-sm font-medium ring-offset-background transition-colors focus-visible:outline-none focus-visible:ring-2 focus-visible:ring-ring focus-visible:ring-offset-2 disabled:pointer-events-none disabled:opacity-50",
  {
    variants: {
      variant: {
        default:
          "bg-primary slow text-primary-foreground hover:bg-gray-800",
        destructive:
          "bg-destructive slow text-destructive-foreground hover:bg-destructive/90",
        outline:
          "border border-slate-700 slow bg-background hover:bg-accent hover:text-accent-foreground",
        secondary:
          "border-2 border-primary slow bg-white text-primary hover:bg-primary hover:text-white",
        ghost:
          "hover:bg-accent slow hover:text-accent-foreground",
        link: "text-primary slow underline-offset-4 hover:underline",
      },
      size: {
        default: "h-10 px-7 rounded-md py-2",
        sm: "h-9 rounded-md px-6",
        lg: "h-11 rounded-md px-11",
        icon: "h-10 w-10",
      },
    },
    defaultVariants: {
      variant: "default",
      size: "default",
    },
  },
);

export interface ButtonProps
  extends React.ButtonHTMLAttributes<HTMLButtonElement>,
    VariantProps<typeof buttonVariants> {
  asChild?: boolean;
}

const Button = React.forwardRef<HTMLButtonElement, ButtonProps>(
  ({ className, variant, size, asChild = false, ...props }, ref) => {
    const Comp = asChild ? Slot : "button";
    return (
      <Comp
        className={cn(buttonVariants({ variant, size, className }))}
        ref={ref}
        {...props}
      />
    );
  },
);
Button.displayName = "Button";

export { Button, buttonVariants };
