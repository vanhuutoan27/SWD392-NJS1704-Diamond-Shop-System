import { IUser } from "@/types/user.interface"

interface RecentUserProps {
  userData: IUser
  time: string
  isOnline: boolean
}

function RecentUser({ userData, time, isOnline }: RecentUserProps) {
  return (
    <div className="flex items-center gap-4 rounded-lg bg-white p-4 shadow-md">
      <div className="relative">
        <div className="h-12 w-12 overflow-hidden rounded-full">
          <img
            src={userData.avatar}
            alt={userData.fullName}
            className="h-full w-full cursor-pointer object-cover"
          />
        </div>
        {isOnline && (
          <span className="absolute bottom-0 right-0 h-3.5 w-3.5 rounded-full border-2 border-white bg-green-500"></span>
        )}
      </div>
      <div className="w-full">
        <div className="mb-1 flex items-center justify-between">
          <h3 className="text-md slow cursor-pointer font-medium text-gray-900 hover:text-secondary">
            {userData.fullName}
          </h3>
          <span className="ml-2 text-sm text-gray-500">{time}</span>
        </div>
        <p className="text-sm text-secondary">{userData.email}</p>
      </div>
    </div>
  )
}

export default RecentUser
