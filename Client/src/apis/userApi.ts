import { useMutation, useQuery, useQueryClient } from "react-query"
import { toast } from "sonner"

import { INewUser, IUpdateUser, IUser } from "@/types/user.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetAllUsers = () => {
  return useQuery<IUser[]>({
    queryKey: ["users"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/User")
      return data.data
    }
  })
}

export const useGetUserById = (id: string) => {
  return useQuery<IUser>({
    queryKey: ["user", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/User/${id}`)
      return data.data
    }
  })
}

export const usePostUser = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (newUserData: INewUser) => {
      const { data } = await diamoonAPI.post("/User/create", newUserData)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("users")
      }
    }
  )
}

export const usePutUser = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (newUserData: IUpdateUser) => {
      const { id, ...data } = newUserData
      const response = await diamoonAPI.put(`/User/${id}`, data)
      return response.data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("users")
        toast.success("Profile updated successfully")
      },
      onError: () => {
        toast.error("Failed to update profile")
      }
    }
  )
}

export const useChangeUserStatus = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (id: string) => {
      const { data } = await diamoonAPI.put(`/User/change-status/${id}`)
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("users")
        toast.success("User status changed successfully")
      },
      onError: () => {
        toast.error("Failed to change user status")
      }
    }
  )
}
