import { IUser, IUserRole, IUserStatus } from "@/types/user.interface";

export const userData: IUser[] = [
  {
    userId: "U001",
    name: "Van Huu Toan",
    email: "toanvhse171981@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://i.pinimg.com/originals/3f/ab/07/3fab077cc8865e75354d5fbf20b35488.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
  {
    userId: "U002",
    name: "Phan Van Khai",
    email: "khaipvse171817@fpt.edu.vn",
    password: "Khai123@",
    avatar:
      "https://i.pinimg.com/originals/3f/ab/07/3fab077cc8865e75354d5fbf20b35488.jpg",
    phone: "0987654321",
    address: "La Xuan Oai, Thu Duc, Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
  {
    userId: "U003",
    name: "Pham Hoai Duy",
    email: "duyphse160496@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://i.pinimg.com/originals/3f/ab/07/3fab077cc8865e75354d5fbf20b35488.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
  {
    userId: "U004",
    name: "Nguyen Quoc Dai",
    email: "dainqse160959@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://i.pinimg.com/originals/3f/ab/07/3fab077cc8865e75354d5fbf20b35488.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
  {
    userId: "U005",
    name: "Nguyen Pham Khanh",
    email: "khanhnpse160945@fpt.edu.vn",
    password: "123@",
    avatar:
      "https://i.pinimg.com/originals/3f/ab/07/3fab077cc8865e75354d5fbf20b35488.jpg",
    phone: "0987654321",
    address: "Ho Chi Minh City, Vietnam",
    createdOn: "07-05-2024",
    role: IUserRole.Admin,
    status: IUserStatus.Active,
  },
];
