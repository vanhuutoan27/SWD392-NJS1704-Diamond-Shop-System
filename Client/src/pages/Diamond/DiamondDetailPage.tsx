import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondDetail from "@/components/molecules/DiamondDetail";
import { diamondData } from "../../constants/diamond";
import { Loader } from "@/components/atoms/Loader";
import QualityCommitment from "@/components/specific/Diamond/QualityCommitment";
import BuyingGuide from "@/components/specific/Diamond/BuyingGuide";
import RelatedProducts from "@/components/specific/Diamond/RelatedProducts";
import DiamondBanner from "@/components/specific/Diamond/DiamondBanner";

function DiamondDetailPage() {
  const { diamondId } = useParams<{ diamondId: string }>();

  const diamondDetails = diamondData.find(
    (diamond) => diamond.diamondId === diamondId,
  );

  const relatedProducts = diamondData;

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

      <DiamondDetail diamondDetails={diamondDetails} />

      <QualityCommitment />

      <BuyingGuide />

      <DiamondBanner />

      <RelatedProducts relatedProducts={relatedProducts} />
    </div>
  );
}

export default DiamondDetailPage;
