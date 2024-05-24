import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import { Loader } from "@/components/global/atoms/Loader";
import DiamondQualityCommitment from "@/components/local/Guest/Diamond/DiamondQualityCommitment";
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide";
import RelatedProducts from "@/components/local/Guest/Diamond/RelatedDiamonds";
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner";
import DiamondDetails from "@/components/local/Guest/Diamond/DiamondDetails";
import { diamondData } from "@/constants/diamond";
import { useGetDiamondById } from "@/api/diamondApi";
import { toast } from "sonner";

function DiamondDetailPage() {
  const { diamondId } = useParams<{ diamondId: string }>();
  const {
    data: diamondDetails,
    error,
    isLoading,
  } = useGetDiamondById(diamondId || "");

  if (isLoading || !diamondDetails) {
    return <Loader />;
  }

  if (error) {
    toast.error("Failed to fetch diamond details data");
  }

  const relatedProducts = diamondData.filter(
    (diamond) => diamond.diamondId !== diamondId,
  );

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
