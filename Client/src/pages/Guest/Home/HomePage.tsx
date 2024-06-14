import { toast } from "sonner"

import { useGetAllDiamonds } from "@/apis/diamondApi"
import { useGetAllJewelries } from "@/apis/jewelryApi"

import { Loader } from "@/components/global/atoms/Loader"
import RelatedDiamonds from "@/components/local/Guest/Diamond/RelatedDiamonds"
import CarouselSlider from "@/components/local/Guest/Home/CarouselSlider"
import RelatedJewelry from "@/components/local/Guest/Jewelry/RelatedJewelry"

function HomePage() {
  const {
    data: allDiamonds,
    error: diamondsError,
    isLoading: isDiamondsLoading
  } = useGetAllDiamonds()

  const {
    data: allJewelries,
    error: jewelriesError,
    isLoading: isJewelriesLoading
  } = useGetAllJewelries()

  if (isDiamondsLoading || isJewelriesLoading) {
    return <Loader />
  }

  if (diamondsError || jewelriesError) {
    toast.error("Failed to fetch data")
  }

  return (
    <div className="container flex w-full flex-col">
      <CarouselSlider />

      <RelatedJewelry
        pageName={"Natural Diamond Jewelry"}
        relatedJewelries={allJewelries || []}
      />

      <RelatedDiamonds
        pageName={"Natural Diamond"}
        relatedDiamonds={allDiamonds || []}
      />
    </div>
  )
}

export default HomePage
