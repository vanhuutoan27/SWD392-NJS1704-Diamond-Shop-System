import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import { jewelryData } from "../../constants/jewelry";
import { Loader } from "@/components/atoms/Loader";
import BuyingGuide from "@/components/specific/Diamond/BuyingGuide";
import DiamondBanner from "@/components/specific/Diamond/DiamondBanner";
import JewelryDetails from "@/components/specific/Jewelry/JewelryDetails";
import RelatedJewelry from "@/components/specific/Jewelry/RelatedJewelry";
import JewelryFaqs from "@/components/specific/Jewelry/JewelryFaqs";
import JewelryQualityCommitment from "@/components/specific/Jewelry/JewelryQualityCommitment";

function JewelryDetailPage() {
  const { jewelryId } = useParams<{ jewelryId: string }>();

  const jewelryDetails = jewelryData.find(
    (jewelry) => jewelry.jewelryId === jewelryId,
  );

  const relatedProducts = jewelryData.filter(
    (jewelry) => jewelry.jewelryId !== jewelryId,
  );

  if (!jewelryDetails) {
    return <Loader />;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Jewelry"
        currentPageUrl="/jewelry"
        currentDetailPage={jewelryDetails.jewelryId}
      />

      <JewelryDetails jewelryDetails={jewelryDetails} />

      <JewelryQualityCommitment />

      <BuyingGuide />

      <JewelryFaqs />

      <DiamondBanner />

      <RelatedJewelry relatedJewelries={relatedProducts} />
    </div>
  );
}

export default JewelryDetailPage;
