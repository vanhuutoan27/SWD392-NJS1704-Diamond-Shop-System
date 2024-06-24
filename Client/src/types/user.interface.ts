export interface IUser {
  id: string
  fullName: string
  email: string
  password: string
  avatar: string
  phoneNumber: string
  address: string
  createdOn: string
  roles: string[]
  isActive: boolean
}

export interface IUserNew {
  roles: string
  email: string
  fullName: string
  password: string
  phone: string
  address: string
}

export interface IUserUpdate {
  id: string
  email: string
  fullName: string
  phone: string
  address: string
  avatar: string
  role: string
}

export interface IJwtPayload {
  id: string
  email: string
  fullname: string
  roles: string
  avatar: string
}

export interface IUserAdmin {
  id: string
  email: string
  fullName: string
  avatar: string
  phoneNumber: string
  roles: string[]
  isActive: boolean
}

export interface IUserRoleConfigItem {
  userId: string
  permissionId: string
  permissionName: string
  diamond: IUserPermission
  jewelry: IUserPermission
  user: IUserPermission
  order: IUserPermission
  invoice: IUserPermission
}

export type IUserRoleConfig = IUserRoleConfigItem[]

export enum IUserPermission {
  AccessDenied = 0,
  View = 1,
  Modify = 2,
  Create = 3,
  FullAccess = 4
}
