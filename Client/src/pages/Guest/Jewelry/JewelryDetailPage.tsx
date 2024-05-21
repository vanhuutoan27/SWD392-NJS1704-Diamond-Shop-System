import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/global/atoms/BreadcrumbComponent";
import { jewelryData } from "../../constants/jewelry";
import { Loader } from "@/components/global/atoms/Loader";
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide";
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner";
import JewelryDetails from "@/components/local/Guest/Jewelry/JewelryDetails";
import RelatedJewelry from "@/components/local/Guest/Jewelry/RelatedJewelry";
import JewelryFaqs from "@/components/local/Guest/Jewelry/JewelryFaqs";
import JewelryQualityCommitment from "@/components/local/Guest/Jewelry/JewelryQualityCommitment";

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
