import { useQuery } from "react-query";
import diamoonAPI from "../lib/diamoonAPI";

const getAllDiamonds = async () => {
  const response = await diamoonAPI.get("/Diamond");
  return response.data;
};

const getDiamondById = async (id: string) => {
  const response = await diamoonAPI.get(`/Diamond/Detail/Id`, {
    params: { id },
  });
  return response.data;
};

export const useGetAllDiamonds = () => {
  return useQuery("diamonds", getAllDiamonds);
};

export const useGetDiamondById = (id: string) => {
  return useQuery(["diamond", id], () => getDiamondById(id), {
    enabled: !!id,
  });
};
