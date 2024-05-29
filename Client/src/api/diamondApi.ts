import { useQuery } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";
import { IDiamond } from "@/types/diamond.interface";

export const useGetAllDiamonds = () => {
  return useQuery<IDiamond[]>({
    queryKey: ["diamonds"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Diamond");
      return data;
    },
  });
};

export const useGetDiamondById = (id: string) => {
  return useQuery<IDiamond>({
    queryKey: ["diamond", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Diamond/Detail/Id`, {
        params: { id },
      });
      return data;
    },
  });
};
