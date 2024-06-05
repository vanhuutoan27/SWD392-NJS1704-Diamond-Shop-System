import { useQuery } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";
import { IJewelry } from "./../types/jewelry.interface";

export const useGetAllJewelries = () => {
  return useQuery<IJewelry[]>({
    queryKey: ["jewelries"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Jewelry");
      return data.data;
    },
  });
};

export const useGetJewelryById = (id: string) => {
  return useQuery<IJewelry>({
    queryKey: ["jewelry", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Jewelry/Id`, {
        params: { id },
      });
      return data;
    },
  });
};
