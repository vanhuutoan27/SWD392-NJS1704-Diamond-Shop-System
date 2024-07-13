import { useMutation, useQuery, useQueryClient } from "react-query"
import { toast } from "sonner"

import { IOrder, IOrderPost } from "@/types/order.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetAllOrders = () => {
  return useQuery<IOrder[]>({
    queryKey: ["orders"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Order")
      return data.data
    }
  })
}

export const useGetOrderById = (id: string) => {
  return useQuery<IOrder>({
    queryKey: ["order", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Order/${id}`, {
        params: { id }
      })
      return data.data
    }
  })
}

export const usePostOrder = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async (order: IOrderPost) => {
      const { data } = await diamoonAPI.post("/Order", order)
      return data
    },
    {
      onSuccess: (_, variables) => {
        queryClient.invalidateQueries("orders")
        toast.success("Order successful, we are processing the order")

        const productIds = variables.items.map((product) => product.productId)
        const storedCart = JSON.parse(localStorage.getItem("cartItems") || "[]")
        const updatedCart = storedCart.filter(
          (item: any) => !productIds.includes(item.productId)
        )
        localStorage.setItem("cartItems", JSON.stringify(updatedCart))
      },
      onError: (error) => {
        console.error("Error posting order data:", error)
        toast.error("Order failed")
      }
    }
  )
}

export const useGetOrderByUserId = (userId: string) => {
  return useQuery<IOrder[]>({
    queryKey: ["order", userId],
    queryFn: async () => {
      try {
        const { data } = await diamoonAPI.get(`/Order/user/${userId}`, {
          params: { userId }
        })
        return data.data ?? []
      } catch (error) {
        console.error("Error fetching orders:", error)
        return []
      }
    }
  })
}

export const useUpdateOrderStatus = () => {
  const queryClient = useQueryClient()

  return useMutation(
    async ({
      orderId,
      orderStatus
    }: {
      orderId: string
      orderStatus: string
    }) => {
      const { data } = await diamoonAPI.put(`/Order/change-status/${orderId}`, {
        status: orderStatus
      })
      return data
    },
    {
      onSuccess: () => {
        queryClient.invalidateQueries("orders")
        toast.success("Order status updated successfully")
      },
      onError: (error) => {
        console.error("Error updating order status:", error)
        toast.error("Failed to update order status")
      }
    }
  )
}
