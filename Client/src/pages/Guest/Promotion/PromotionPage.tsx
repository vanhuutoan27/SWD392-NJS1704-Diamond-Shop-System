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
          <img
            src="https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Test%2FdiamondSaleBanner.png?alt=media&token=f75da601-b668-4e56-8d1c-88af5c498eca"
            alt="Diamoon Promotion"
            className="w-full rounded-md"
          />
        </div>
      </div>
    </div>
  )
}
export default PromotionPage
