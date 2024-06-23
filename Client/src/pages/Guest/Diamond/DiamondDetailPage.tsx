import { useParams } from "react-router-dom"

import { IDiamond } from "@/types/diamond.interface"

import { useGetAllDiamonds, useGetDiamondById } from "@/apis/diamondApi"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide"
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner"
import DiamondDetails from "@/components/local/Guest/Diamond/DiamondDetails"
import DiamondQualityCommitment from "@/components/local/Guest/Diamond/DiamondQualityCommitment"
import RelatedDiamonds from "@/components/local/Guest/Diamond/RelatedDiamonds"

import NotFoundPage from "../HTTP/NotFoundPage"

function DiamondDetailPage() {
  const { diamondId } = useParams<{ diamondId: string }>()

  const {
    data: diamondDetails,
    error: diamondDetailsError,
    isLoading: isDiamondDetailsLoading
  } = useGetDiamondById(diamondId || "")

  const {
    data: diamondData,
    error: allDiamondsError,
    isLoading: isAllDiamondsLoading
  } = useGetAllDiamonds()

  if (!diamondDetails || isDiamondDetailsLoading || isAllDiamondsLoading) {
    return <Loader />
  }

  if (diamondDetailsError || allDiamondsError || diamondDetails.status === 0) {
    return <NotFoundPage />
  }

  const relatedProducts =
    diamondData?.filter(
      (diamond: IDiamond) =>
        diamond.diamondId !== diamondId && diamond.status === 1
    ) || []

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
        currentDetailPage={diamondDetails.skuID}
      />

      {diamondDetails && <DiamondDetails diamondDetails={diamondDetails} />}

      <DiamondQualityCommitment />

      <BuyingGuide />

      <DiamondBanner />

      <RelatedDiamonds relatedDiamonds={relatedProducts} />
    </div>
  )
}

export default DiamondDetailPage
