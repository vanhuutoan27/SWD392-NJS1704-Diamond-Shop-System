import SearchBar from "../molecules/SearchBar";
import UserProfile from "../molecules/UserProfile";

function Toolbar() {
  return (
    <div className="sticky left-72 right-0 top-0 flex h-16 w-full items-center justify-between bg-white px-5 shadow-sm">
      <SearchBar />

      <UserProfile />
    </div>
  );
}

export default Toolbar;
