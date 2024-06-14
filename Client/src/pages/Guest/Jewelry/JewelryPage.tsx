import { useState, useEffect, useMemo } from "react";
import { projectName } from "@/lib/constants";
import JewelryList from "@/components/local/Guest/Jewelry/JewelryList";
import JewelryCategory from "@/components/local/Guest/Jewelry/JewelryCategory";
import Section from "@/components/global/organisms/Section";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import { useGetAllJewelries } from "@/apis/jewelryApi";
import { Loader } from "@/components/global/atoms/Loader";
import { toast } from "sonner";

function JewelryPage() {
  const [category, setCategory] = useState("");
  const [priceRange, setPriceRange] = useState("");
  const [sortOrder, setSortOrder] = useState("");
  const [currentPage, setCurrentPage] = useState(1);
  const itemsPerPage = 8;

  const { data: allJewelries, error, isLoading } = useGetAllJewelries();

  useEffect(() => {
    setCurrentPage(1);
  }, [category, priceRange, sortOrder]);

  const filteredJewelry = useMemo(() => {
    if (!allJewelries) return [];

    let filtered = allJewelries.filter(
      (jewelry) => jewelry.status === "Active",
    );

    if (category && category !== "all") {
      filtered = filtered.filter(
        (jewelry) =>
          jewelry.jewelryCategory.toLowerCase() === category.toLowerCase(),
      );
    }

    if (priceRange && priceRange !== "all") {
      filtered = filtered.filter((jewelry) => {
        const price = jewelry.price;
        if (priceRange === "Under 50") return price < 50000000;
        if (priceRange === "50-100")
          return price >= 50000000 && price <= 100000000;
        if (priceRange === "100-200")
          return price >= 100000000 && price <= 200000000;
        if (priceRange === "Over 200") return price > 200000000;
        return true;
      });
    }

    if (sortOrder && sortOrder !== "all") {
      if (sortOrder === "high-low") {
        filtered.sort((a, b) => b.price - a.price);
      } else if (sortOrder === "low-high") {
        filtered.sort((a, b) => a.price - b.price);
      }
    }

    return filtered;
  }, [allJewelries, category, priceRange, sortOrder]);

  const totalItems = filteredJewelry.length;
  const totalPages = Math.ceil(totalItems / itemsPerPage);

  const currentItems = useMemo(() => {
    return filteredJewelry.slice(
      (currentPage - 1) * itemsPerPage,
      currentPage * itemsPerPage,
    );
  }, [filteredJewelry, currentPage, itemsPerPage]);

  if (isLoading) {
    return <Loader />;
  }

  if (error) {
    toast.error("Failed to fetch jewelry");
    return null;
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
  );
}

export default JewelryPage;
