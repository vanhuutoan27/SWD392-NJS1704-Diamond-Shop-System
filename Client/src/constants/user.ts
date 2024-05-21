import { IUser, IUserRole, IUserStatus } from "@/types/user.interface";

export const userData: IUser[] = [
  {
    userId: "U001",
    name: "Van Huu Toan",
    email: "toanvhse171981@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://images.unsplash.com/photo-1560250097-0b93528c311a?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
    username: "Toan Ne",
  },
  {
    userId: "U002",
    name: "Phan Van Khai",
    email: "PhanKhai0963122758@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://i.pinimg.com/736x/94/c3/d8/94c3d8b831f03f3292a6ac5ef13cb73b.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
    username: "Khai Toi",
  },
  {
    userId: "U003",
    name: "Pham Hoai Duy",
    email: "",
    password: "123@",
    avatar:
      "https://images.unsplash.com/photo-1560250097-0b93528c311a?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
    username: "Khai Toi",
  },
  {
    userId: "U004",
    name: "Nguyen Quoc Dai",
    email: "",
    password: "123@",
    avatar:
      "https://images.unsplash.com/photo-1560250097-0b93528c311a?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
    username: "Khai Toi",
  },
  {
    userId: "U005",
    name: "Nguyen Pham Khanh",
    email: "",
    password: "123@",
    avatar:
      "https://images.unsplash.com/photo-1560250097-0b93528c311a?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
    username: "Khai Toi",
  },
];
