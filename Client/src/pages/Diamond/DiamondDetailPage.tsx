import BreadcrumbComponent from "@/components/atoms/BreadcrumbComponent";

function DiamondDetailPage() {
  return (
    <div className="container"><BreadcrumbComponent
    lastPage="Home"
    lastPageUrl="/"
    currentPage="Contact"
  />
</div>
  )
}

export default DiamondDetailPage