import { Search } from "lucide-react"

function SearchBar() {
  return (
    <div className="flex w-[400px] items-center rounded-md border-[1.5px] border-input bg-transparent px-5">
      <Search />

      <input
        placeholder={"Type to search..."}
        className="ml-3 w-full rounded-md bg-transparent py-3 text-sm outline-none"
      />
    </div>
  )
}

export default SearchBar
