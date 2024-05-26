import { useQuery } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";

const getAllJewelry = async () => {
  const response = await diamoonAPI.get("/Jewelry/All");
  return response.data;
};

const getJewelryById = async (id: string) => {
  const response = await diamoonAPI.get(`/Jewelry/Detail/Id`, {
    params: { id },
  });
  return response.data;
};

export const useGetAllJewelry = () => {
  return useQuery("jewelries", getAllJewelry);
};

export const useGetJewelryById = (id: string) => {
  return useQuery(["jewelry", id], () => getJewelryById(id), {
    enabled: !!id,
  });
};
