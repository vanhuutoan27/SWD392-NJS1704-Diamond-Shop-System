
import { Button } from "@/components/global/atoms/button";
import PasswordInput from "@/components/global/molecules/PasswordInput";
import diamoonAPI from "@/lib/diamoonAPI";
import { registerSchema } from "@/schemas/RegisterForm";
import { IUser } from "@/types/user.interface";
import { zodResolver } from "@hookform/resolvers/zod";
import { useState } from "react";
import { useForm } from "react-hook-form";
import { Link, useNavigate } from "react-router-dom";
import { toast } from "sonner";

function RegisterPage() {
  const navigate = useNavigate();
  const [isLoading, setIsLoading] = useState(false);

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<IUser>({
    resolver: zodResolver(registerSchema),
  });

  const onSubmit = async (data: IUser) => {
    try {
      setIsLoading(true);
      await diamoonAPI.post("/Auth/register", {
        fullName: data.name,
        email: data.email,
        password: data.password,
      });
      toast.success("Registration successful. Please login");
      navigate("/login");
    } catch (error) {
      toast.error("Registration failed. Please try again");
      console.error("Registration failed:", error);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded border-2 border-input bg-white px-7 py-16 shadow-md">
        <form onSubmit={handleSubmit(onSubmit)}>
          <h2 className="mb-7 text-center text-2xl font-semibold text-gray-800">
            Register
          </h2>

          <input
            type="text"
            placeholder="Full name"
            {...register("name")}
            className="input-field"
          />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.name?.message}
          </p>

          <input
            type="email"
            placeholder="Email"
            {...register("email")}
            className="input-field"
          />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.email?.message}
          </p>

          <PasswordInput register={register} placeholder="Password" />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.password?.message}
          </p>

          <Button type="submit" className="mt-3 w-full py-6">
            {isLoading ? "Register" : "Register"}
          </Button>

          <p className="mt-4 text-center text-sm">
            Already have an account?{" "}
            <Link to="/login" className="font-medium text-primary underline">
              Login
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
}

export default RegisterPage;
