import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import { Loader } from "@/components/global/atoms/Loader";
import DiamondQualityCommitment from "@/components/local/Guest/Diamond/DiamondQualityCommitment";
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide";
import RelatedProducts from "@/components/local/Guest/Diamond/RelatedDiamonds";
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner";
import DiamondDetails from "@/components/local/Guest/Diamond/DiamondDetails";
import { useGetAllDiamonds, useGetDiamondById } from "@/api/diamondApi";
import { IDiamond } from "@/types/diamond.interface";
import NotFoundPage from "../HTTP/NotFoundPage";

function DiamondDetailPage() {
  const { diamondId } = useParams<{ diamondId: string }>();

  const {
    data: diamondDetails,
    error: diamondDetailsError,
    isLoading: isDiamondDetailsLoading,
  } = useGetDiamondById(diamondId || "");

  const {
    data: diamondData,
    error: allDiamondsError,
    isLoading: isAllDiamondsLoading,
  } = useGetAllDiamonds();

  if (isDiamondDetailsLoading || isAllDiamondsLoading) {
    return <Loader />;
  }

  if (diamondDetailsError || allDiamondsError) {
    return <NotFoundPage />;
  }

  const relatedProducts =
    diamondData?.filter(
      (diamond: IDiamond) => diamond.diamondId !== diamondId,
    ) || [];

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
        currentDetailPage={diamondDetails?.diamondId}
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
