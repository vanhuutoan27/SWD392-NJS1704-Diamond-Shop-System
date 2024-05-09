import PasswordInput from "@/components/molecules/PasswordInput";
import { validateEmail } from "@/lib/utils";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

function LoginPage() {
  const navigate = useNavigate();

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");

  const handleLogin = async (e) => {
    e.preventDefault();

    if (!validateEmail(email)) {
      setError("Please enter a valid email address");
      return;
    }

    if (!password) {
      setError("Please enter the password");
      return;
    }

    // Login API call
    console.log(JSON.stringify({ email, password }, null, 2));
  };

  return (
    <div className="flex w-full items-center justify-center">
      <div className="w-96 rounded-xl border bg-white px-7 py-10 shadow-md">
        <form onSubmit={handleLogin}>
          <h4 className="mb-7 text-2xl font-semibold">Login</h4>

          <input
            type="text"
            placeholder="Email"
            className="mb-4 w-full rounded-md border-[1.5px] bg-transparent px-5 py-3 text-sm outline-none"
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
            Login
          </button>

          <p className="mt-4 text-center text-sm">
            Not registered yet?{" "}
            <Link
              to="/register"
              className="font-semibold text-primary underline"
            >
              Create a new account
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
}

export default LoginPage;
