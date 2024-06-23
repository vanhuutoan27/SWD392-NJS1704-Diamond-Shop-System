import { useMutation, useQuery, useQueryClient } from "react-query"
import { toast } from "sonner"

import { IDiamond, IDiamondPost } from "@/types/diamond.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetAllDiamonds = () => {
  return useQuery<IDiamond[]>({
    queryKey: ["diamonds"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Diamond")
      return data
    }
  })
}

export const useGetDiamondById = (id: string) => {
  return useQuery<IDiamond>({
    queryKey: ["diamond", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Diamond/Detail/Id`, {
        params: { id }
      })
      return data
    }
  })
}

export const usePostDiamond = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (diamond: IDiamondPost) => {
      const { data } = await diamoonAPI.post("/Diamond", diamond)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("diamonds")
        toast.success("Diamond added successfully")
      },
      onError: (error) => {
        console.error("Error posting diamond data:", error)
        toast.error("Failed to add diamond")
      }
    }
  )
}

export const useChangeDiamondStatus = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (id: string) => {
      const { data } = await diamoonAPI.put(`/Diamond/change-status/${id}`)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("diamonds")
        toast.success("Diamond status changed successfully")
        // window.location.reload()
      },
      onError: () => {
        toast.error("Failed to change diamond status")
      }
    }
  )
}
