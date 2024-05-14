import { useParams } from "react-router-dom";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondDetail from "@/components/molecules/DiamondDetail";
import { diamondData } from "../../constants/diamond";

function DiamondDetailPage() {
  const { diamondId } = useParams();

  const diamond = diamondData.find(
    (diamond) => diamond.diamondId === diamondId,
  );

  if (!diamond) {
    return <div>Diamond not found!</div>;
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />
      <DiamondDetail diamond={diamond} />
    </div>
  );
}

export default DiamondDetailPage;
