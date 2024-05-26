import { useState } from "react";
import { useForm } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import { Link, useNavigate } from "react-router-dom";
import { IUser } from "@/types/user.interface";
import { Button } from "@/components/global/atoms/button";
import PasswordInput from "@/components/global/molecules/PasswordInput";
import { loginSchema } from "@/schemas/LoginForm";
import { toast } from "sonner";
import { useAuthContext } from "@/contexts/AuthContext";
import diamoonAPI from "@/lib/diamoonAPI";

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
      const response = await diamoonAPI.post("/Auth/login", {
        email: data.email,
        password: data.password,
      });

      const { token, refreshToken } = response.data;
      if (token && refreshToken) {
        login(token, refreshToken);
        toast.success("Login successfully");
        navigate("/redirect");
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
      <div className="w-96 rounded-xl border-2 border-input bg-white px-7 py-16 shadow-md">
        <form onSubmit={handleSubmit(onSubmit)}>
          <h2 className="mb-7 text-center text-2xl font-semibold text-primary">
            Login
          </h2>
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
