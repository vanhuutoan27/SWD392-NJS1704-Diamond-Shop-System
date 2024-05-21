import { useState, useEffect, useMemo } from "react";
import { projectName } from "@/lib/constants";
import { jewelryData } from "@/constants/jewelry";
import { IJewelryStatus } from "@/types/jewelry.interface";
import JewelryList from "@/components/local/Guest/Jewelry/JewelryList";
import JewelryCategory from "@/components/local/Guest/Jewelry/JewelryCategory";
import Section from "@/components/global/organisms/Section";

function JewelryPage() {
  const [category, setCategory] = useState("");
  const [priceRange, setPriceRange] = useState("");
  const [sortOrder, setSortOrder] = useState("");
  const [currentPage, setCurrentPage] = useState(1);
  const itemsPerPage = 4;

  const filteredJewelry = useMemo(() => {
    let filtered = jewelryData.filter(
      (jewelry) => jewelry.status === IJewelryStatus.Available,
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
      // else if (sortOrder === "new") {
      //   filtered.sort((a, b) => new Date(b.createdOn) - new Date(a.createdOn));
      // }
    }

    return filtered;
  }, [category, priceRange, sortOrder]);

  const totalItems = filteredJewelry.length;
  const totalPages = Math.ceil(totalItems / itemsPerPage);

  const currentItems = filteredJewelry.slice(
    (currentPage - 1) * itemsPerPage,
    currentPage * itemsPerPage,
  );

  useEffect(() => {
    setCurrentPage(1);
  }, [category, priceRange, sortOrder]);

  return (
    <div className="container">
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
