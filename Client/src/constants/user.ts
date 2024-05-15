import { IUser, IUserRole, IUserStatus } from "@/types/user.interface";

export const userData: IUser[] = [
  {
    userId: "U001",
    name: "Van Huu Toan",
    email: "vanhuutoan.it.work@gmail.com",
    password: "123@",
    avatar: "https://i.imgur.com/7bIqJf3.jpg",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
];
