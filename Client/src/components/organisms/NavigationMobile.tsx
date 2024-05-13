import NavigationMenu from "../molecules/NavigationMenu";

function NavigationMobile({ isMenuOpen }: { isMenuOpen: boolean }) {
  return (
    <div
      className={`${isMenuOpen ? "flex" : "hidden"} items-center justify-between`}
    >
      <div
        className={`${isMenuOpen ? "top-[100%]" : "-top-[100%]"} absolute left-0 z-10 flex min-h-[40vh] w-full items-center bg-white shadow-md duration-300 ease-in-out md:static md:min-h-fit md:w-auto md:shadow-none`}
      >
        <NavigationMenu />
      </div>
    </div>
  );
}

export default NavigationMobile;
