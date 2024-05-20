import { useAuthContext } from "@/contexts/AuthContext";
import SearchBar from "../molecules/SearchBar";
import UserProfile from "../molecules/UserProfile";

function Toolbar() {
  const { user, logout } = useAuthContext();

  return (
    <div className="sticky left-72 right-0 top-0 flex h-16 w-full items-center justify-between bg-white px-5 shadow-sm">
      <SearchBar />

      <UserProfile userData={user} onLogout={logout} />
    </div>
  );
}

export default Toolbar;
