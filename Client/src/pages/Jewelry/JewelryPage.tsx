import { projectName } from "@/lib/constants";
import JewelryEarrnings from "@/components/specific/Jewelry/JewelryEarrings";
import JewelryPendant from "@/components/specific/Jewelry/JewelryPendant";
import JewelryBracelet from "@/components/specific/Jewelry/JewelryBracelet";
import JewelryRing from "@/components/specific/Jewelry/JewelryRing";

function JewelryPage() {
  return (
    <div className="container">
      <img
        src="../images/home_slider_1.jpg"
        alt={projectName}
        className="h-[350px] w-full object-cover"
      />
      <JewelryEarrnings />

      <JewelryPendant />

      <JewelryBracelet />

      <JewelryRing />
    </div>
  );
}

export default JewelryPage;
