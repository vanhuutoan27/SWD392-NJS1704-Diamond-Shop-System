import { Button } from "@/components/atoms/button";
import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";
import DiamondClarifyFilter from "@/components/molecules/DiamondClarifyFilter";
import DiamondColorFilter from "@/components/molecules/DiamondColorFilter";
import DiamondPriceFilter from "@/components/molecules/DiamondPriceFilter";
import DiamondShapeFilter from "@/components/molecules/DiamondShapeFilter";
import DiamondSizeFilter from "@/components/molecules/DiamondSizeFilter";
import DiamondWeightFilter from "@/components/molecules/DiamondWeightFilter";

function DiamondPage() {
  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage="Home"
        lastPageUrl="/"
        currentPage="Diamond"
      />
      <div className="">
        <div className="relative">
          <h3 className="mb-3 w-fit border-b-4 border-primary text-xl font-semibold uppercase leading-[60px]">
            Diamond
          </h3>
          <div className="absolute inset-x-0 bottom-0 h-[2px] bg-primary" />
        </div>
        <div className="flex flex-col gap-8">
          <div className="flex w-full justify-between gap-10">
            <div className="flex w-1/4 flex-col gap-4">
              <DiamondShapeFilter />
              <DiamondPriceFilter />
            </div>
            <div className="flex w-3/4 flex-col gap-2">
              <DiamondWeightFilter />
              <DiamondSizeFilter />
              <DiamondColorFilter />
              <DiamondClarifyFilter />
            </div>
          </div>
          <div className="flex justify-end gap-4">
            <Button variant={"secondary"}>Reset</Button>
            <Button>Filter</Button>
          </div>
        </div>
      </div>

      <div className="">
        <div className="relative">
          <h3 className="mb-3 w-fit border-b-4 border-primary text-xl font-semibold uppercase leading-[60px]">
            Suggested Products
          </h3>
          <div className="absolute inset-x-0 bottom-0 h-[2px] bg-primary" />
        </div>
      </div>
    </div>
  );
}

export default DiamondPage;
