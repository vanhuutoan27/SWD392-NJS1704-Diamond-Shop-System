import { useMutation, useQuery, useQueryClient } from "react-query"
import { toast } from "sonner"

import { IJewelry, IJewelryPost } from "@/types/jewelry.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetAllJewelries = () => {
  return useQuery<IJewelry[]>({
    queryKey: ["jewelries"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Jewelry")
      return data.data
    }
  })
}

export const useGetJewelryById = (id: string) => {
  return useQuery<IJewelry>({
    queryKey: ["jewelry", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Jewelry/${id}`)
      return data.data
    }
  })
}

export const usePostJewelry = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (jewelry: IJewelryPost) => {
      const { data } = await diamoonAPI.post("/Jewelry", jewelry)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("jewelries")
        toast.success("Jewelry added successfully")
      },
      onError: (error) => {
        console.error("Error posting jewelry data:", error)
        toast.error("Failed to add jewelry")
      }
    }
  )
}

export const useUpdateJewelry = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (jewelry: IJewelry) => {
      const { data } = await diamoonAPI.put(
        `/Jewelry/${jewelry.jewelryId}`,
        jewelry
      )
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("jewelries")
        toast.success("Jewelry updated successfully")
      },
      onError: (error) => {
        console.error("Error updating jewelry data:", error)
        toast.error("Failed to update jewelry")
      }
    }
  )
}

export const useChangeJewelryStatus = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (id: string) => {
      const { data } = await diamoonAPI.put(`/Jewelry/change-status/${id}`)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("jewelries")
        toast.success("Jewelry status changed successfully")
      },
      onError: () => {
        toast.error("Failed to change jewelry status")
      }
    }
  )
}
