import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import { jewelryData } from "../../constants/jewelry";
import { Loader } from "@/components/atoms/Loader";
import QualityCommitment from "@/components/specific/Diamond/QualityCommitment";
import BuyingGuide from "@/components/specific/Diamond/BuyingGuide";
import DiamondBanner from "@/components/specific/Diamond/DiamondBanner";
import RelatedJewelry from "@/components/specific/Jewerly/RelatedJewelry";
import JewelryDetail from "@/components/specific/Jewerly/JewelryDetail";

function JewelryDetailPage() {
  const { jewelryId } = useParams<{ jewelryId: string }>();

  const jewelryDetails = jewelryData.find(
    (jewelry) => jewelry.jewelryId === jewelryId,
  );

  const relatedProducts = jewelryData;

  if (!jewelryDetails) {
    return <Loader />;
  }
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Jewelry"
        currentDetailPage={jewelryDetails.jewelryId}
      />
      <JewelryDetail jewelryDetails={jewelryDetails} />

      <QualityCommitment />

      <BuyingGuide />

      <DiamondBanner />

      <RelatedJewelry relatedJewelry={relatedProducts} />
    </div>
  );
}

export default JewelryDetailPage;
