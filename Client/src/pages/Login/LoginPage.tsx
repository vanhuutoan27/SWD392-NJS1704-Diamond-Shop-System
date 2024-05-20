import { useState } from "react";
import { useForm } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import { Link, useNavigate } from "react-router-dom";
import { IUser } from "@/types/user.interface";
import { Button } from "@/components/atoms/button";
import PasswordInput from "@/components/molecules/PasswordInput";
import { loginSchema } from "@/schemas/LoginForm";
import axios from "axios";
import { toast } from "sonner";
import { useAuthContext } from "@/contexts/AuthContext";

function LoginPage() {
  const navigate = useNavigate();
  const { login } = useAuthContext();
  const [isLoading, setIsLoading] = useState(false);

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<IUser>({
    resolver: zodResolver(loginSchema),
  });

  const onSubmit = async (data: IUser) => {
    try {
      setIsLoading(true);
      const response = await axios.post(
        `http://localhost:5084/login?Email=${data.email}&Password=${data.password}`,
      );
      const { accessToken, refreshToken } = response.data.data;
      if (accessToken && refreshToken) {
        login(accessToken, refreshToken);
        toast.success("Login successfully");
        navigate("/");
      } else {
        console.error("Tokens are missing in the response");
      }
    } catch (error) {
      toast.error("Email or password is incorrect");
      console.error("Login failed:", error);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded-xl border bg-white px-7 py-16 shadow-md">
        <form onSubmit={handleSubmit(onSubmit)}>
          <h2 className="mb-7 text-center text-2xl font-semibold text-primary">
            Login
          </h2>
          <input
            type="text"
            placeholder="Email"
            {...register("email")}
            className="mb-1 w-full rounded-md border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
          />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.email?.message}
          </p>

          <PasswordInput register={register} placeholder="Password" />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.password?.message}
          </p>
          <Button type="submit" className="mt-3 w-full py-6">
            {isLoading ? "Login" : "Login"}
          </Button>
          <p className="mt-4 text-center text-sm">
            Not registered yet?{" "}
            <Link to="/register" className="font-medium text-primary underline">
              Create a new account
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
}

export default LoginPage;
