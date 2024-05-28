import { useQuery } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";

export const useUsers = async () => {
  const response = await diamoonAPI.get("/User/All");
  return response.data;
};

export const useGetAllUsers = () => {
  return useQuery("users", useUsers);
};
