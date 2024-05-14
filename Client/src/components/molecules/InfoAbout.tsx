import React from "react";
import { infoAboutData } from "../../constants/infoAbout";

const InfoAbout: React.FC = () => {
  const info = infoAboutData[0];

  return (
    <div className="flex flex-col items-center gap-8 lg:flex-row lg:items-start">
      <div className="flex justify-center lg:w-1/2">
        <img src={info.img} alt="Diamoon" />
      </div>
      <div className="text-left lg:w-1/2">
        <h1 className="mb-4 text-4xl font-medium">{info.mainTitle}</h1>
        <p className="mb-6 text-sm">{info.mainDescription}</p>
        <h2 className="mb-2 text-2xl font-normal">{info.title1}</h2>
        <p className="mb-6 text-sm">{info.description1}</p>
        <h2 className="mb-2 text-2xl font-normal">{info.title2}</h2>
        <p className="text-sm">{info.description2}</p>
      </div>
    </div>
  );
};

export default InfoAbout;
