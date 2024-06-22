import { useState } from "react"

import { Eye, EyeOff } from "lucide-react"
import { UseFormRegister } from "react-hook-form"

interface PasswordInputProps {
  register: UseFormRegister<any>
  placeholder: string
}

function PasswordInput({ register, placeholder }: PasswordInputProps) {
  const [isShowPassword, setIsShowPassword] = useState(false)

  const toggleShowPassword = () => {
    setIsShowPassword(!isShowPassword)
  }

  return (
    <div className="mb-1 flex items-center rounded-md border-[1.5px] bg-transparent px-5">
      <input
        type={isShowPassword ? "text" : "password"}
        {...register("password")}
        placeholder={placeholder || "Password"}
        className="mr-3 w-full rounded-md bg-transparent py-3 text-sm outline-none"
      />

      {isShowPassword ? (
        <Eye
          size={20}
          className="cursor-pointer select-none text-primary"
          onClick={() => toggleShowPassword()}
        />
      ) : (
        <EyeOff
          size={20}
          className="cursor-pointer select-none text-slate-400"
          onClick={() => toggleShowPassword()}
        />
      )}
    </div>
  )
}

export default PasswordInput
