export interface IUser {
  userId: string;
  fullName: string;
  email: string;
  password: string;
  createdOn: string;
  status: IUserStatus;
}

export enum IUserStatus {
  Active = 0,
  Inactive = 1,
  Suspended = 2,
}
