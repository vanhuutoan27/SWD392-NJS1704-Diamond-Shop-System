import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/global/atoms/BreadcrumbComponent";
import { Loader } from "@/components/global/atoms/Loader";
import DiamondQualityCommitment from "@/components/local/Guest/Diamond/DiamondQualityCommitment";
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide";
import RelatedProducts from "@/components/local/Guest/Diamond/RelatedDiamonds";
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner";
import DiamondDetails from "@/components/local/Guest/Diamond/DiamondDetails";
import { diamondData } from "@/constants/diamond";

function DiamondDetailPage() {
  const { diamondId } = useParams<{ diamondId: string }>();

  const diamondDetails = diamondData.find(
    (diamond) => diamond.diamondId === diamondId,
  );

  const relatedProducts = diamondData.filter(
    (diamond) => diamond.diamondId !== diamondId,
  );

  if (!diamondDetails) {
    return <Loader />;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
        currentDetailPage={diamondDetails.diamondId}
      />

      <DiamondDetails diamondDetails={diamondDetails} />

      <DiamondQualityCommitment />

      <BuyingGuide />

      <DiamondBanner />

      <RelatedProducts relatedDiamonds={relatedProducts} />
    </div>
  );
}

export default DiamondDetailPage;
