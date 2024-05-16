import {
  Breadcrumb,
  BreadcrumbItem,
  BreadcrumbLink,
  BreadcrumbList,
  BreadcrumbPage,
  BreadcrumbSeparator,
} from "@/components/atoms/breadcrumb";
import { Slash } from "lucide-react";

type BreadcrumbComponentProps = {
  lastPage: string;
  lastPageUrl: string;
  currentPage: string;
  currentPageUrl?: string;
  currentDetailPage?: string;
};

function BreadcrumbComponent({
  lastPage,
  lastPageUrl,
  currentPage,
  currentPageUrl,
  currentDetailPage,
}: BreadcrumbComponentProps) {
  return (
    <div className="flex py-3">
      <Breadcrumb>
        <BreadcrumbList>
          <BreadcrumbItem>
            <BreadcrumbLink
              href={lastPageUrl}
              className="text-gray-800 transition-all duration-300 hover:text-[#888]"
            >
              {lastPage}
            </BreadcrumbLink>
          </BreadcrumbItem>
          <BreadcrumbSeparator>
            <Slash />
          </BreadcrumbSeparator>
          {currentDetailPage ? (
            <>
              <BreadcrumbItem>
                <BreadcrumbLink
                  href={currentPageUrl}
                  className={`text-primary ${currentDetailPage ? "cursor-pointer text-gray-800 transition-all duration-300 hover:text-[#888]" : ""}`}
                >
                  {currentPage}
                </BreadcrumbLink>
              </BreadcrumbItem>
              <BreadcrumbSeparator>
                <Slash />
              </BreadcrumbSeparator>
              <BreadcrumbItem>
                <BreadcrumbPage className="font-semibold text-primary">
                  {currentDetailPage}
                </BreadcrumbPage>
              </BreadcrumbItem>
            </>
          ) : (
            <BreadcrumbItem>
              <BreadcrumbPage className="font-semibold text-primary">
                {currentPage}
              </BreadcrumbPage>
            </BreadcrumbItem>
          )}
        </BreadcrumbList>
      </Breadcrumb>
    </div>
  );
}

export default BreadcrumbComponent;
