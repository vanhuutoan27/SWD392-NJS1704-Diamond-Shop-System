export interface IUser {
  userId: string;
  name: string;
  email: string;
  password: string;
  username: string;
  avatar: string;
  phone: string;
  address: string;
  createdOn: string;
  role: IUserRole;
  status: IUserStatus;
}

export interface IJwtPayload {
  sid: string;
  email: string;
  name: string;
  role: IUserRole;
}

export enum IUserRole {
  Customer = 0,
  SalesStaff = 1,
  DeliveryStaff = 2,
  Manager = 3,
  Admin = 4,
}

export enum IUserStatus {
  Active = 0,
  Inactive = 1,
  Suspended = 2,
}
