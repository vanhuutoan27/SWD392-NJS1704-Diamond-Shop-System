import { useGetDiamondById } from "@/api/diamondApi";
import NotFoundPage from "@/pages/Guest/HTTP/NotFoundPage";
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle,
} from "@/components/global/atoms/dialog";
import { Button } from "@/components/global/atoms/button";
import { diamondImage } from "@/lib/constants";

function ViewDiamondDialog({
  diamondId,
  onClose,
}: {
  diamondId: string;
  onClose: () => void;
}) {
  const {
    data: diamondDetails,
    isLoading,
    error,
  } = useGetDiamondById(diamondId);

  if (isLoading || error) {
    return <NotFoundPage />;
  }

  return (
    <Dialog onOpenChange={onClose} open>
      <DialogContent className="min-w-[800px]">
        <DialogHeader>
          <DialogTitle className="text-center text-xl font-semibold">
            View Diamond Details - {diamondDetails?.diamondId}
          </DialogTitle>
        </DialogHeader>
        <div className="mt-4 flex justify-between gap-8">
          <div>
            <div className="flex min-h-[200px] min-w-[200px] items-center justify-center rounded-md">
              <img
                src={diamondDetails?.image || diamondImage}
                alt="Diamond"
                className="h-[200px] w-[200px] rounded-md border-2 border-gray-800 object-cover"
              />
            </div>
          </div>

          <div className="grid grid-cols-2 gap-4">
            <div>
              <span className="ml-1 text-sm font-medium">Shape</span>
              <input
                type="text"
                value={diamondDetails?.shape}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Color</span>
              <input
                type="text"
                value={diamondDetails?.colorLevel}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Clarity</span>
              <input
                type="text"
                value={diamondDetails?.clarity}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Certification</span>
              <input
                type="text"
                value={diamondDetails?.certification}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Fluorescence</span>
              <input
                type="text"
                value={diamondDetails?.fluorescence}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Quality of Cut</span>
              <input
                type="text"
                value={diamondDetails?.qualityOfCut}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Weight (carats)</span>
              <input
                type="text"
                value={diamondDetails?.weight}
                readOnly
                className="input-field mt-1"
              />
            </div>
            <div>
              <span className="ml-1 text-sm font-medium">Size (mm)</span>
              <input
                type="text"
                value={diamondDetails?.size}
                readOnly
                className="input-field mt-1"
              />
            </div>

            <div className="col-span-2">
              <span className="ml-1 text-sm font-medium">Price (VND)</span>
              <input
                type="text"
                value={diamondDetails?.price}
                readOnly
                className="input-field mt-1"
              />
            </div>
          </div>
        </div>

        <div className="mt-4 flex justify-end">
          <Button type="button" onClick={onClose}>
            Close
          </Button>
        </div>
      </DialogContent>
    </Dialog>
  );
}

export default ViewDiamondDialog;
