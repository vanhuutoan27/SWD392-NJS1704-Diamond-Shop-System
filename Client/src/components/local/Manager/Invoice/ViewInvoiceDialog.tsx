// import { useEffect, useRef, useState } from "react"

// import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage"

// import { IInvoiceItem } from "@/types/invoice.interface"

// import {  } from "@/apis/invoiceApi"

// import { diamondImage } from "@/lib/constants"
// import { formatCurrencyWithoutVND, formatDate } from "@/lib/utils"

// import { Loader } from "@/components/global/atoms/Loader"
// import { Button } from "@/components/global/atoms/button"
// import {
//   Dialog,
//   DialogContent,
//   DialogHeader,
//   DialogTitle
// } from "@/components/global/atoms/dialog"

// function ViewInvoiceDialog({
//   invoiceId
// }: {
//   invoiceId: string
//   onClose: () => void
// }) {
//   const {
//     data: diamondDetails,
//     isLoading,
//     error
//   } = useGetDiamondById(invoiceId)

//   const [formData, setFormData] = useState({
//     diamondId: "",
//     shape: "",
//     colorLevel: "",
//     clarity: "",
//     certification: "",
//     fluorescence: "",
//     qualityOfCut: "",
//     weight: 0,
//     size: 0,
//     price: 0,
//     image: diamondImage,
//     dateCreated: "",
//     dateModified: ""
//   })

//   const dialogRef = useRef<HTMLDivElement | null>(null)

//   useEffect(() => {
//     if (diamondDetails) {
//       setFormData({
//         diamondId: diamondDetails.diamondId || "",
//         shape: diamondDetails.shape || "",
//         colorLevel: diamondDetails.colorLevel || "",
//         clarity: diamondDetails.clarity || "",
//         certification: diamondDetails.certification || "",
//         fluorescence: diamondDetails.fluorescence.toUpperCase() || "",
//         qualityOfCut: diamondDetails.qualityOfCut || "",
//         weight: diamondDetails.weight || 0,
//         size: diamondDetails.size || 0,
//         price: diamondDetails.price || 0,
//         image: diamondDetails.images || diamondImage || "",
//         dateCreated: diamondDetails.dateCreated || "",
//         dateModified: diamondDetails.dateModified || ""
//       })
//     }
//   }, [diamondDetails])

//   if (!diamondDetails || isLoading) {
//     return <Loader />
//   }

//   if (error) {
//     return <NotFoundPage />
//   }

//   return (
//     <Dialog open>
//       <DialogContent ref={dialogRef} className="min-w-[800px]">
//         <DialogHeader>
//           <DialogTitle className="text-center text-xl font-semibold">
//             View InVoice Details
//           </DialogTitle>
//         </DialogHeader>
//         <div className="mb-4">
//           <span className="ml-1 text-sm font-medium">Jewelry ID</span>
//           <input
//             type="text"
//             name="jewelryId"
//             value={formData.jewelryId}
//             readOnly
//             className="input-field mt-1 w-full"
//             tabIndex={-1}
//           />
//         </div>
//       </DialogContent>
//     </Dialog>
//   )
// }

// export default ViewInvoiceDialog
