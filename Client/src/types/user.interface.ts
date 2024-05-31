export interface IUser {
  id: string;
  fullName: string;
  email: string;
  password: string;
  avatar: string;
  phoneNumber: string;
  address: string;
  createdOn: string;
  role: IUserRole;
  isActive: boolean;
}

export interface INewUser {
  role?: string;
  email: string;
  fullName: string;
  password: string;
  phone: string;
  address: string;
}

export interface IJwtPayload {
  id: string;
  email: string;
  fullname: string;
  roles: string;

  avatar: string;
}

export enum IUserRole {
  Customer = 0,
  SalesStaff = 1,
  DeliveryStaff = 2,
  Manager = 3,
  Admin = 4,
}
