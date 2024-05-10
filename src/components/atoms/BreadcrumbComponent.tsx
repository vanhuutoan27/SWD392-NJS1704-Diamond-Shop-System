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
};

function BreadcrumbComponent({
  lastPage,
  lastPageUrl,
  currentPage,
}: BreadcrumbComponentProps) {
  return (
    <div className="flex justify-center bg-secondary py-8">
      <Breadcrumb>
        <BreadcrumbList>
          <BreadcrumbItem>
            <BreadcrumbLink
              href={lastPageUrl}
              className="text-gray-900 transition-all duration-200 hover:text-yellow-500"
            >
              {lastPage}
            </BreadcrumbLink>
          </BreadcrumbItem>
          <BreadcrumbSeparator>
            <Slash />
          </BreadcrumbSeparator>
          <BreadcrumbItem>
            <BreadcrumbPage className="font-medium">
              {currentPage}
            </BreadcrumbPage>
          </BreadcrumbItem>
        </BreadcrumbList>
      </Breadcrumb>
    </div>
  );
}

export default BreadcrumbComponent;
