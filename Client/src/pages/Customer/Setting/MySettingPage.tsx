import { useAuthContext } from "@/contexts/AuthContext"
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"
import { useParams } from "react-router-dom"

import { useGetUserById } from "@/apis/userApi"

import { cn, useIsAdminRoute } from "@/lib/utils"

import { Loader } from "@/components/global/atoms/Loader"
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent"
import Section from "@/components/global/organisms/Section"
import SettingChangeAvatar from "@/components/local/Customer/Setting/SettingChangeAvatar"
import SettingForm from "@/components/local/Customer/Setting/SettingForm"

function MySettingPage() {
  const { user } = useAuthContext()
  const isAdminRoute = useIsAdminRoute()
  const { userId } = useParams<{ userId: string }>()

  const { data: userDetails, isLoading, error } = useGetUserById(userId || "")

  if (!userDetails || isLoading) {
    return <Loader />
  }

  if (!user || error) {
    return <NotFoundPage />
  }

  return (
    <div className={cn("", isAdminRoute ? "p-10" : "container")}>
      {!isAdminRoute && (
        <BreadcrumbComponent
          lastPage={"Home"}
          lastPageUrl="/"
          currentPage="User"
          currentDetailPage="My Settings"
        />
      )}

      <Section pageName="Diamoon Settings" />

      <div className="flex w-full flex-col gap-8 md:flex-row">
        <div className="w-2/3">
          <SettingForm user={userDetails} />
        </div>
        <div className="w-1/3">
          <SettingChangeAvatar user={userDetails} />
        </div>
      </div>
    </div>
  )
}

export default MySettingPage
