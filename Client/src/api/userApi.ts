import { useMutation, useQuery, useQueryClient } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";
import { INewUser, IUser } from "@/types/user.interface";

export const useGetAllUsers = () => {
  return useQuery<IUser[]>({
    queryKey: ["users"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/User");
      return data.data;
    },
  });
};

export const useGetUserById = (id: string) => {
  return useQuery<IUser>({
    queryKey: ["user", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/User/${id}`);
      return data.data;
    },
  });
};

export const usePostUser = () => {
  const queryClient = useQueryClient();

  return useMutation(
    async (newUserData: INewUser) => {
      const { data } = await diamoonAPI.post("/User/create", newUserData);
      return data;
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("users");
      },
    },
  );
};
