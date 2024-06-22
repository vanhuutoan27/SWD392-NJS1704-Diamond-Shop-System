import { useParams } from "react-router-dom"

import { IJewelry } from "@/types/jewelry.interface"

import { useGetAllJewelries, useGetJewelryById } from "@/apis/jewelryApi"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import BuyingGuide from "@/components/local/Guest/Diamond/BuyingGuide"
import DiamondBanner from "@/components/local/Guest/Diamond/DiamondBanner"
import JewelryDetails from "@/components/local/Guest/Jewelry/JewelryDetails"
import JewelryFaqs from "@/components/local/Guest/Jewelry/JewelryFaqs"
import JewelryQualityCommitment from "@/components/local/Guest/Jewelry/JewelryQualityCommitment"
import RelatedJewelry from "@/components/local/Guest/Jewelry/RelatedJewelry"

import NotFoundPage from "../HTTP/NotFoundPage"

function JewelryDetailPage() {
  const { jewelryId } = useParams<{ jewelryId: string }>()

  const {
    data: jewelryDetails,
    error: jewelryDetailsError,
    isLoading: isJewelryDetailsLoading
  } = useGetJewelryById(jewelryId || "")

  const {
    data: jewelryData,
    error: allJewelriesError,
    isLoading: isAllJewelriesLoading
  } = useGetAllJewelries()

  if (!jewelryDetails || isJewelryDetailsLoading || isAllJewelriesLoading) {
    return <Loader />
  }

  if (jewelryDetailsError || allJewelriesError || jewelryDetails.status === 0) {
    return <NotFoundPage />
  }

  const relatedProducts =
    jewelryData?.filter(
      (jewelry: IJewelry) =>
        jewelry.jewelryId !== jewelryId && jewelry.status === 1
    ) || []

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Jewelry"
        currentPageUrl="/jewelry"
        currentDetailPage={jewelryDetails.skuID}
      />

      <JewelryDetails jewelryDetails={jewelryDetails} />

      <JewelryQualityCommitment />

      <BuyingGuide />

      <JewelryFaqs />

      <DiamondBanner />

      <RelatedJewelry relatedJewelries={relatedProducts} />
    </div>
  )
}

export default JewelryDetailPage
