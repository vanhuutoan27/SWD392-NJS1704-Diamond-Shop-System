import { IUser } from "@/types/user.interface"

import SettingInformationForm from "./SettingInformationForm"
import SettingPasswordForm from "./SettingPasswordForm"
import { Tabs, TabsContent, TabsList, TabsTrigger } from "./SettingTabs"

interface SettingFormProps {
  user: IUser
}

function SettingForm({ user }: SettingFormProps) {
  return (
    <Tabs defaultValue="account">
      <TabsList className="grid w-full grid-cols-2">
        <TabsTrigger value="account">Account</TabsTrigger>
        <TabsTrigger value="password">Password</TabsTrigger>
      </TabsList>
      <TabsContent value="account">
        <SettingInformationForm user={user} />
      </TabsContent>
      <TabsContent value="password">
        <SettingPasswordForm user={user} />
      </TabsContent>
    </Tabs>
  )
}

export default SettingForm
