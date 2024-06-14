import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

import { useGetAllDiamonds } from "@/apis/diamondApi"

import { Loader } from "@/components/global/atoms/Loader"
import { columns } from "@/components/local/Manager/Diamond/DiamondListColumns"
import { DataTable } from "@/components/local/Manager/Diamond/DiamondListDataTable"

function DiamondListPage() {
  const { data: diamondData, error, isLoading } = useGetAllDiamonds()

  if (isLoading) {
    return <Loader />
  }

  if (error) {
    return <NotFoundPage />
  }

  return (
    <div className="p-5">
      <DataTable columns={columns} data={diamondData ?? []} />
    </div>
  )
}

export default DiamondListPage
