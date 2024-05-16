import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import { jewelryData } from "../../constants/jewelry";
import { Loader } from "@/components/atoms/Loader";
import JewelryDetail from "@/components/molecules/JewelryDetail";
import QualityCommitment from "@/components/specific/Diamond/QualityCommitment";
import BuyingGuide from "@/components/specific/Diamond/BuyingGuide";
import DiamondBanner from "@/components/specific/Diamond/DiamondBanner";
import RelatedProductsJewerly from "@/components/specific/Jewerly/RelatedProductsJewelry";

function JewelryDetailPage() {
  const { jewelryId } = useParams<{ jewelryId: string }>();

  const jewelryDetails = jewelryData.find(
    (jewelry) => jewelry.jewelryId === jewelryId,
  );

  const relatedProductsJewerly = jewelryData;

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

      <RelatedProductsJewerly relatedProductsJewerly={relatedProductsJewerly} />
    </div>
  );
}

export default JewelryDetailPage;
