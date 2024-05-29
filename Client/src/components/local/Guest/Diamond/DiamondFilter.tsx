import { useEffect, useState } from "react";

interface DiamondFilterProps {
  options: string[];
  onSelection: (selection: string) => void;
  title: string;
  isResetting: boolean;
}

function DiamondFilter({
  options,
  onSelection,
  title,
  isResetting,
}: DiamondFilterProps) {
  const [selectedOption, setSelectedOption] = useState("");

  const handleSelection = (option: string) => {
    setSelectedOption(option);
    onSelection(option);
  };

  useEffect(() => {
    if (isResetting) {
      setSelectedOption("");
    }
  }, [isResetting]);

  return (
    <div className="flex flex-col">
      <h4 className="mb-2 text-sm font-semibold">{title}</h4>
      <div className="flex gap-3">
        <span
          className={`slow cursor-pointer rounded-md border-[1px] border-slate-700 px-7 py-1 text-sm ${
            selectedOption === ""
              ? "bg-primary text-white"
              : "bg-white text-primary"
          }`}
          onClick={() => handleSelection("")}
        >
          All
        </span>
        {options.map((option, index) => (
          <span
            key={index}
            className={`slow cursor-pointer rounded-md border-[1px] border-slate-700 px-6 py-1 text-sm hover:bg-primary hover:text-white ${
              selectedOption === option
                ? "bg-primary text-white"
                : "bg-white text-primary"
            }`}
            onClick={() => handleSelection(option)}
          >
            {option}
          </span>
        ))}
      </div>
    </div>
  );
}

export default DiamondFilter;
