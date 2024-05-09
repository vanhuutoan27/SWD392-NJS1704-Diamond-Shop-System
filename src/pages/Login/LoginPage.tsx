import { useForm, Controller } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import PasswordInput from "@/components/molecules/PasswordInput";
import { Link, useNavigate } from "react-router-dom";
import { loginSchema } from "@/schemas/login";
import { IUser } from "@/types/user.interface";

function LoginPage() {
  const navigate = useNavigate();
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<IUser>({
    resolver: zodResolver(loginSchema),
  });

  const onSubmit = async (data: IUser) => {
    console.log(JSON.stringify(data, null, 2));
    navigate("/");
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded-xl border bg-white px-7 py-10 shadow-md">
        <form onSubmit={handleSubmit(onSubmit)}>
          <h4 className="mb-7 text-2xl font-semibold">Login</h4>
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
          <button
            type="submit"
            className="my-2 w-full select-none rounded-md bg-primary p-2 py-3 text-sm font-medium text-white transition-all duration-200 hover:bg-yellow-500"
          >
            Login
          </button>
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
