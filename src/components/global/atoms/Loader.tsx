import { ClipLoader } from "react-spinners";

export function Loader()  {
  return (
    <div className="mx-auto flex min-h-screen w-full items-center justify-center">
      <ClipLoader color="#00000" size={70} />
    </div>
  );
};
