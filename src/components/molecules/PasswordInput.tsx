import { Eye, EyeOff } from "lucide-react";
import { useState } from "react";

interface PasswordInputProps {
  value: string;
  onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
  placeholder: string;
}

function PasswordInput({ value, onChange, placeholder }: PasswordInputProps) {
  const [isShowPassword, setIsShowPassword] = useState(false);

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword);
  };

  return (
    <div className="mb-3 flex items-center rounded-md border-[1.5px] bg-transparent px-5">
      <input
        type={isShowPassword ? "text" : "password"}
        value={value}
        onChange={onChange}
        placeholder={placeholder || "Password"}
        className="mr-3 w-full rounded-md bg-transparent py-3 text-sm outline-none"
      />

      {isShowPassword ? (
        <Eye
          size={20}
          className="cursor-pointer text-primary"
          onClick={() => toggleShowPassword()}
        />
      ) : (
        <EyeOff
          size={20}
          className="cursor-pointer text-slate-400"
          onClick={() => toggleShowPassword()}
        />
      )}
    </div>
  );
}

export default PasswordInput;
