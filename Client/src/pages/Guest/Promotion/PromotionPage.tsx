import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import PromotionInfo from "@/components/local/Guest/Promotion/PromotionInfo"

function PromotionPage() {
  return (
    <div className="container mx-auto">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Promotion"
      />

      <Section pageName={"Promotion"} />

      <PromotionInfo />
    </div>
  )
}
export default PromotionPage
