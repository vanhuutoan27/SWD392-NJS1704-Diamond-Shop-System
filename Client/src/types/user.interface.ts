export interface IUser {
  id: string;
  fullName: string;
  email: string;
  password: string;
  avatar: string;
  phoneNumber: string;
  address: string;
  createdOn: string;
  roles: string[];
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