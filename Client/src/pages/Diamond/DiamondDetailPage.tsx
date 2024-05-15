import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondDetail from "@/components/molecules/DiamondDetail";
import QualityCommitments from "@/components/molecules/QualityCommitments";
import { diamondData } from "../../constants/diamond";

function DiamondDetailPage() {
  const { diamondId } = useParams();

  const diamondDetails = diamondData.find(
    (diamond) => diamond.diamondId === diamondId,
  );

  if (!diamondDetails) {
    return <div>Diamond not found!</div>;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />
      <DiamondDetail diamondDetails={diamondDetails} />
      <QualityCommitments />
    </div>
  );
}

export default DiamondDetailPage;
