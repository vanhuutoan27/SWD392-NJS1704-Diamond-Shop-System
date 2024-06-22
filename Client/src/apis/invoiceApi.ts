import { useQuery } from "react-query"

import { IInvoice } from "@/types/invoice.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetAllInvoices = () => {
  return useQuery<IInvoice[]>({
    queryKey: ["invoices"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Invoice")
      return data.data
    }
  })
}

export const useGetInvoiceById = (id: string) => {
  return useQuery<IInvoice>({
    queryKey: ["invoice", id],
    queryFn: async () => {
      const { data } = await diamoonAPI.get(`/Invoice/${id}`, {
        params: { id }
      })
      return data.data
    }
  })
}

export const useGetInvoiceByUserId = (userId: string) => {
  return useQuery<IInvoice[]>({
    queryKey: ["invoice", userId],
    queryFn: async () => {
      try {
        const { data } = await diamoonAPI.get(
          `/Invoice/by-customer/${userId}`,
          {
            params: { userId }
          }
        )
        return data.data ?? []
      } catch (error) {
        console.error("Error fetching invoices:", error)
        return []
      }
    }
  })
}
