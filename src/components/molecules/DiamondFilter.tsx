import { useState } from "react";
import { Loader } from "../atoms/Loader";

interface DiamondFilterProps {
  title: string;
  options: string[];
}

function DiamondFilter({ title, options }: DiamondFilterProps) {
  const [selectedOption, setSelectedOption] = useState("All");

  const handleOptionSelection = (option: string) => {
    setSelectedOption(option);
  };

  if (!options) {
    return <Loader />;
  }

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">{title}</h4>
      <div className="flex gap-3">
        <span
          className={`cursor-pointer rounded-md border-[1px] border-slate-700 px-7 py-1 text-sm transition-all duration-200 ${
            selectedOption === "All"
              ? "bg-primary text-white"
              : "bg-white text-primary"
          }`}
          onClick={() => handleOptionSelection("All")}
        >
          All
        </span>
        {options.map((option) => (
          <span
            key={option}
            className={`cursor-pointer rounded-md border-[1px] border-slate-700 px-6 py-1 text-sm transition-all duration-200 hover:bg-primary hover:text-white ${
              selectedOption === option
                ? "bg-primary text-white"
                : "bg-white text-primary"
            }`}
            onClick={() => handleOptionSelection(option)}
          >
            {option}
          </span>
        ))}
      </div>
    </div>
  );
}

export default DiamondFilter;
