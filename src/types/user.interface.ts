export interface IUser {
  userId: string;
  name: string;
  email: string;
  password: string;
  createdOn: string;
  role: IUserRole;
  status: IUserStatus;
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
