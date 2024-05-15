import { IUser, IUserRole, IUserStatus } from "@/types/user.interface";

export const userData: IUser[] = [
  {
    userId: "U001",
    name: "Van Huu Toan",
    email: "vanhuutoan.it.work@gmail.com",
    password: "123@",
    avatar: "https://i.imgur.com/7bIqJf3.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
];
