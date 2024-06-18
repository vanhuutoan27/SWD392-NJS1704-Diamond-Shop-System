import { useQuery } from "react-query"

import { IInvoiceItem } from "@/types/invoice.interface"

import diamoonAPI from "@/lib/diamoonAPI"

export const useGetInvoice = () => {
  return useQuery<IInvoiceItem[]>({
    queryKey: ["invoices"],
    queryFn: async () => {
      const { data } = await diamoonAPI.get("/Invoice")
      return data
    }
  })
}
