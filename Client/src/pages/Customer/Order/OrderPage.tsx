import { useState } from "react";
import ProgressBar from "@/components/global/molecules/ProgressBar";
import Section from "@/components/global/organisms/Section";
import InformationForm from "@/components/local/Customer/Order/InformationForm";
import ShippingForm from "@/components/local/Customer/Order/ShippingForm";
import PaymentForm from "@/components/local/Customer/Order/PaymentForm";
import ConfirmOrderPage from "@/components/local/Customer/Order/ConfirmOrderPage";
import OrderSummary from "@/components/local/Customer/Order/OrderSummary";
import { Button } from "@/components/global/atoms/button";
import { scrollToTop } from "@/lib/utils";
import { useLocation } from "react-router-dom";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";
import { ICart, ICartType } from "@/types/cart.interface";

function OrderPage() {
  const location = useLocation();
  const { state } = location;
  const { cartItems } = state || { cartItems: [] };

  const getProductDetails = (productId: string, type: ICartType) => {
    if (type === ICartType.Diamond) {
      return diamondData.find((diamond) => diamond.diamondId === productId);
    } else if (type === ICartType.Jewelry) {
      return jewelryData.find((jewelry) => jewelry.jewelryId === productId);
    }
  };

  const enrichedCartItems = cartItems.map((item: ICart) => ({
    ...item,
    ...getProductDetails(item.productId, item.productType),
  }));

  console.log(enrichedCartItems);

  const tabs = [
    { component: InformationForm, label: "Information" },
    { component: ShippingForm, label: "Shipping" },
    { component: PaymentForm, label: "Payment" },
    { component: ConfirmOrderPage, label: "Done" },
  ];
  const [tab, setTab] = useState(0);

  const nextStep = async () => {
    let output = true;

    if (!output) return;
    if (tab < tabs.length - 1) {
      setTab(tab + 1);
      scrollToTop();
    }
  };

  const prevStep = () => {
    if (tab > 0) {
      setTab(tab - 1);
      scrollToTop();
    }
  };

  const CurrentForm = tabs[tab].component;

  return (
    <div className="container">
      <Section pageName={"Check Out"} />

      <div className="w-2/3 pr-8">
        <ProgressBar currentStep={tab + 1} />
      </div>

      <div className="mt-20 flex w-full gap-8">
        <div className="w-2/3">
          <CurrentForm />
        </div>
        <div className="w-1/3">
          <OrderSummary cartItems={cartItems} />
        </div>
      </div>

      <div className="mt-10 flex justify-between">
        <Button disabled={tab === 0} onClick={prevStep}>
          Back
        </Button>
        <Button disabled={tab === tabs.length - 1} onClick={nextStep}>
          Next
        </Button>
      </div>
    </div>
  );
}

export default OrderPage;
