import { Link, useNavigate } from "react-router-dom";
import Navigation from "./Navigation";
import { Button } from "../atoms/button";
import { projectName } from "@/lib/constants";
import UserProfile from "../molecules/UserProfile";
import { useCookies } from "react-cookie";
import { jwtDecode } from "jwt-decode";
import { IJwtPayload } from "@/types/user.interface";

function Header() {
  const navigate = useNavigate();
  const [cookies, removeCookie] = useCookies(["accessToken", "refreshToken"]);
  const accessToken = cookies.accessToken;

  let user: IJwtPayload | null = null;
  if (accessToken) {
    try {
      user = jwtDecode<IJwtPayload>(accessToken);
    } catch (error) {
      console.error("Invalid token:", error);
    }
  }

  const logout = () => {
    removeCookie("accessToken", { path: "/" });
    removeCookie("refreshToken", { path: "/" });
    navigate("/login");
  };

  return (
    <div className="container bg-white pt-8">
      <div className="flex items-center justify-center md:justify-between">
        <div className="uppercase">
          <h2 className="cursor-pointer select-none text-center text-4xl font-bold text-gray-800 md:text-left">
            <Link to="/">{projectName}</Link>
          </h2>
          <h4 className="select-none font-semibold tracking-widest">
            Diamond Shop System
          </h4>
        </div>

        <div className="hidden gap-4 md:flex">
          {user ? (
            <UserProfile userData={user} onLogout={logout} />
          ) : (
            <>
              <Link to="/register">
                <Button type="button" variant="secondary">
                  Register
                </Button>
              </Link>
              <Link to="/login">
                <Button type="button">Login</Button>
              </Link>
            </>
          )}
        </div>
      </div>

      <Navigation />
    </div>
  );
}

export default Header;
