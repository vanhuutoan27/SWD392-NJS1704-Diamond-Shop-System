function FeatureArea() {
  const features = [
    {
      img: "/icons/delivery_small.png",
      title: "Free Shipping",
      desc: "Product are free shipping",
    },
    {
      img: "/icons/technical-support_small.png",
      title: "Support 24/7",
      desc: "Support 24 hours a day",
    },
    {
      img: "/icons/padlock_small.png",
      title: "Secure Payment",
      desc: "We ensure secure payment",
    },
    {
      img: "/icons/money-back-guarantee_small.png",
      title: "100% Moneyback",
      desc: "Most product are free shipping",
    },
  ];

  return (
    <div className="container mb-10 grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4">
      {features.map((feature, index) => (
        <div
          key={index}
          className="flex items-center justify-center gap-4 px-5 py-6"
        >
          <img
            src={feature.img}
            alt={feature.title}
            className="h-[63px] w-[63px] cursor-pointer"
          />
          <div className="flex flex-col justify-center">
            <h4 className="mb-[6px] text-[18px] font-semibold">
              {feature.title}
            </h4>
            <p className="text-[#757575]">{feature.desc}</p>
          </div>
        </div>
      ))}
    </div>
  );
}

export default FeatureArea;
