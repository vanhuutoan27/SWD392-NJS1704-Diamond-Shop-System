interface ProgressBarProps {
  currentStep: number;
}

function ProgressBar({ currentStep }: ProgressBarProps) {
  const items = [
    { title: "Information", color: "bg-primary" },
    { title: "Shipping", color: "bg-primary" },
    { title: "Payment", color: "bg-primary" },
    { title: "Done", color: "bg-primary" },
  ];

  return (
    <div className="mb-8 flex w-full items-center">
      {items.map((item, index) => (
        <>
          <div
            key={index}
            className={`slow h-4 flex-1 ${
              currentStep >= index + 1
                ? items[currentStep - 1].color
                : "bg-slate-300"
            } ${
              (index === 0 && "rounded-l-full") ||
              (index === items.length - 1 && "rounded-r-full")
            }`}
          ></div>
          <div className="relative flex items-center bg-primary">
            <div
              className={`slow absolute cursor-pointer ${index !== items.length - 1 ? "-left-2" : "right-0"} h-4 w-4 rounded-full border-2 ${
                currentStep === index + 1
                  ? "border-primary bg-white"
                  : "border-none bg-none"
              }`}
            ></div>

            <div
              className={`absolute top-0 mt-4 w-32 text-center font-medium text-primary ${index !== items.length - 1 ? "-ml-16" : "-ml-20"}`}
            >
              {item.title}
            </div>
          </div>
        </>
      ))}
    </div>
  );
}

export default ProgressBar;
