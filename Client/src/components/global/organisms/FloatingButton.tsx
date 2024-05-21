import { scrollToTop } from "@/lib/utils";
import { ChevronUp } from "lucide-react";

function FloatingButton() {
  return (
    <div
      className="fixed bottom-4 right-4 cursor-pointer rounded-full bg-primary p-3 text-white shadow-md transition-all hover:bg-[#908e9b]"
      onClick={scrollToTop}
    >
      <ChevronUp />
    </div>
  );
}

export default FloatingButton;
