import { Skeleton } from "@/components/global/atoms/skeleton"
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

      <div className="flex gap-8 justify-between">
        <div className="w-full">
          <PromotionInfo />
        </div>

        <div className="w-[350px] shadow-md border-2 border-input rounded-md">
          <Skeleton className="w-full h-full rounded animate-pulse" />
        </div>
      </div>
    </div>
  )
}
export default PromotionPage
