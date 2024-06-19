import { useEffect, useMemo, useState } from "react"

import { toast } from "sonner"

import { useGetAllJewelries } from "@/apis/jewelryApi"

import { projectName } from "@/lib/constants"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import JewelryCategory from "@/components/local/Guest/Jewelry/JewelryCategory"
import JewelryList from "@/components/local/Guest/Jewelry/JewelryList"

function JewelryPage() {
  const [category, setCategory] = useState("all")
  const [priceRange, setPriceRange] = useState("all")
  const [sortOrder, setSortOrder] = useState("all")
  const [currentPage, setCurrentPage] = useState(1)
  const itemsPerPage = 8

  const { data: allJewelries, error, isLoading } = useGetAllJewelries()

  useEffect(() => {
    setCurrentPage(1)
  }, [category, priceRange, sortOrder])

  const filteredJewelry = useMemo(() => {
    if (!allJewelries) return []

    let filtered = allJewelries.filter((jewelry) => jewelry.status === 1)

    if (category && category !== "all") {
      filtered = filtered.filter(
        (jewelry) =>
          jewelry.jewelryCategory.toLowerCase() === category.toLowerCase()
      )
      console.log("After category filter: ", filtered)
    }

    if (priceRange && priceRange !== "all") {
      filtered = filtered.filter((jewelry) => {
        const price = jewelry.price
        if (priceRange === "Under 50") return price < 50000000
        if (priceRange === "50-100")
          return price >= 50000000 && price <= 100000000
        if (priceRange === "100-200")
          return price >= 100000000 && price <= 200000000
        if (priceRange === "Over 200") return price > 200000000
        return true
      })
      console.log("After price filter: ", filtered)
    }

    if (sortOrder && sortOrder !== "all") {
      if (sortOrder === "high-low") {
        filtered.sort((a, b) => b.price - a.price)
      } else if (sortOrder === "low-high") {
        filtered.sort((a, b) => a.price - b.price)
      }
      console.log("After sort: ", filtered)
    }

    return filtered
  }, [allJewelries, category, priceRange, sortOrder])

  const totalItems = filteredJewelry.length
  const totalPages = Math.ceil(totalItems / itemsPerPage)

  const currentItems = useMemo(() => {
    return filteredJewelry.slice(
      (currentPage - 1) * itemsPerPage,
      currentPage * itemsPerPage
    )
  }, [filteredJewelry, currentPage, itemsPerPage])

  if (!allJewelries || isLoading) {
    return <Loader />
  }

  if (error) {
    toast.error("Failed to fetch jewelry")
    return null
  }

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="Jewelry"
      />

      <img
        src="../images/home_slider_1.jpg"
        alt={projectName}
        className="h-[350px] w-full object-cover"
      />

      <Section pageName={"Diamond Jewelry"} />

      <JewelryCategory
        setCategory={setCategory}
        setPriceRange={setPriceRange}
        setSortOrder={setSortOrder}
      />

      <JewelryList
        jewelryItems={currentItems}
        currentPage={currentPage}
        totalPages={totalPages}
        setCurrentPage={setCurrentPage}
      />
    </div>
  )
}

export default JewelryPage
