import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import { diamondData } from "../../constants/diamond";
import { Loader } from "@/components/atoms/Loader";
import DiamondQualityCommitment from "@/components/specific/Diamond/DiamondQualityCommitment";
import BuyingGuide from "@/components/specific/Diamond/BuyingGuide";
import RelatedProducts from "@/components/specific/Diamond/RelatedDiamonds";
import DiamondBanner from "@/components/specific/Diamond/DiamondBanner";
import DiamondDetails from "@/components/specific/Diamond/DiamondDetails";

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
