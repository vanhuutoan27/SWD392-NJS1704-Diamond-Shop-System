import PasswordInput from "@/components/molecules/PasswordInput";
import { validateEmail } from "@/lib/utils";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

function RegisterPage() {
  const navigate = useNavigate();

  const [fullName, setFullName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");

  const handleRegister = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    if (!fullName) {
      setError("Please enter your full name");
      return;
    }

    if (!validateEmail(email)) {
      setError("Please enter a valid email address");
      return;
    }

    if (!password) {
      setError("Please enter the password");
      return;
    }

    // Register API call
    console.log(JSON.stringify({ fullName, email, password }, null, 2));
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded border bg-white px-7 py-10 shadow-md">
        <form onSubmit={handleRegister}>
          <h4 className="mb-7 text-2xl font-semibold">Register</h4>

          <input
            type="text"
            placeholder="Full name"
            className="mb-4 w-full rounded border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
            value={fullName}
            onChange={(e) => setFullName(e.target.value)}
          />

          <input
            type="text"
            placeholder="Email"
            className="mb-4 w-full rounded border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />

          <PasswordInput
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            placeholder="Password"
          />

          {error && <p className="pb-1 text-xs text-red-500">{error}</p>}

          <button
            type="submit"
            className="my-2 w-full select-none rounded-md bg-primary p-2 py-3 text-sm font-medium text-white transition-all duration-200 hover:bg-yellow-500"
          >
            Register
          </button>

          <p className="mt-4 text-center text-sm">
            Already have an account?{" "}
            <Link to="/login" className="font-semibold text-primary underline">
              Login
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
}

export default RegisterPage;
