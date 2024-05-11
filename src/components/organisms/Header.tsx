import { Link } from "react-router-dom";
import Navigation from "./Navigation";
import { Button } from "../atoms/button";

function Header() {
  return (
    <div className="container bg-white pt-8">
      <div className="flex items-center justify-center md:justify-between">
        <div className="uppercase">
          <h2 className="cursor-pointer select-none text-center text-4xl font-bold text-gray-900 md:text-left">
            <Link to="/">Diamoon</Link>
          </h2>
          <h4 className="select-none font-semibold tracking-widest">
            Diamond Shop System
          </h4>
        </div>

        <div className="hidden gap-4 md:flex">
          <Link to="/register">
            <Button type="button" variant="secondary">
              Register
            </Button>
          </Link>
          <Link to="/login">
            <Button type="button">Login</Button>
          </Link>
        </div>
      </div>

      <Navigation />
    </div>
  );
}

export default Header;
