import { Button } from "@/components/atoms/button";
import PasswordInput from "@/components/molecules/PasswordInput";
import { registerSchema } from "@/schemas/RegisterForm";
import { IUser } from "@/types/user.interface";
import { zodResolver } from "@hookform/resolvers/zod";
import { useForm } from "react-hook-form";
import { Link, useNavigate } from "react-router-dom";

function RegisterPage() {
  const navigate = useNavigate();

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<IUser>({
    resolver: zodResolver(registerSchema),
  });

  const onSubmit = async (data: IUser) => {
    console.log(JSON.stringify(data, null, 2));
    navigate("/");
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded border bg-white px-7 py-10 shadow-md">
        <form onSubmit={handleSubmit(onSubmit)}>
          <h2 className="mb-7 text-center text-2xl font-semibold text-gray-800">
            Register
          </h2>

          <input
            type="text"
            placeholder="Full name"
            {...register("name")}
            className="mb-1 w-full rounded border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
          />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.name?.message}
          </p>

          <input
            type="text"
            placeholder="Email"
            {...register("email")}
            className="mb-1 w-full rounded border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
          />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.email?.message}
          </p>

          <PasswordInput register={register} placeholder="Password" />
          <p className="ml-2 pb-2 text-xs text-red-500">
            {errors.password?.message}
          </p>

          <Button type="button" className="w-full py-6">
            Register
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
