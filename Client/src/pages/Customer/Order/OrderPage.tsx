import { useEffect, useState } from "react";
import ProgressBar from "@/components/global/molecules/ProgressBar";
import Section from "@/components/global/organisms/Section";
import InformationForm from "@/components/local/Customer/Order/InformationForm";
import PaymentForm from "@/components/local/Customer/Order/PaymentForm";
import ConfirmOrder from "@/components/local/Customer/Order/ConfirmOrder";
import OrderSummary from "@/components/local/Customer/Order/OrderSummary";
import { Button } from "@/components/global/atoms/button";
import { scrollToTop } from "@/lib/utils";
import { useLocation } from "react-router-dom";
import { FormData, Province, District, Ward } from "@/types/order.interface";
import { informationSchema } from "@/schemas/OrderForm";

function OrderPage() {
  const location = useLocation();
  const { state } = location;
  const { cartItems } = state || { cartItems: [] };

  const [tab, setTab] = useState(0);
  const [isSticky, setIsSticky] = useState(false);
  const [formData, setFormData] = useState<FormData>({
    email: "",
    fullName: "",
    phoneNumber: "",
    address: "",
    province: "",
    district: "",
    ward: "",
  });

  const [provinces, setProvinces] = useState<Province[]>([]);
  const [districts, setDistricts] = useState<District[]>([]);
  const [wards, setWards] = useState<Ward[]>([]);
  const [errors, setErrors] = useState<any>({});
  const [selectedPaymentMethod, setSelectedPaymentMethod] = useState("");
  const [paymentError, setPaymentError] = useState("");

  const headerHeight = 200;

  useEffect(() => {
    const handleScroll = () => {
      if (window.scrollY > headerHeight) {
        setIsSticky(true);
      } else {
        setIsSticky(false);
      }
    };

    window.addEventListener("scroll", handleScroll);

    return () => {
      window.removeEventListener("scroll", handleScroll);
    };
  }, [headerHeight]);

  const nextStep = async () => {
    let output = true;

    // Validate form data based on the current tab
    if (tab === 0) {
      const validation = informationSchema.safeParse(formData);
      if (!validation.success) {
        setErrors(validation.error.format());
        output = false;
      } else {
        setErrors({});
      }
    }

    // Validate payment method selection
    if (tab === 1 && !selectedPaymentMethod) {
      setPaymentError("Please select a payment method.");
      output = false;
    } else {
      setPaymentError("");
    }

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

  const getButtonText = (tab: number) => {
    switch (tab) {
      case 0:
        return "Continue To Choose Payment Method";
      default:
        return "Complete Order";
    }
  };

  const tabs = [
    { component: InformationForm, label: "Information" },
    { component: PaymentForm, label: "Payment" },
    { component: ConfirmOrder, label: "Done" },
  ];

  const CurrentForm = tabs[tab].component;

  return (
    <div className="container">
      <Section pageName={"Check Out"} />

      <div className="w-3/5 pr-8">
        <ProgressBar currentStep={tab + 1} />
      </div>

      <div className="mt-16 flex w-full gap-8">
        <div className="w-3/5 rounded-md border-2 border-input bg-white p-5 shadow-md">
          <CurrentForm
            formData={formData}
            setFormData={setFormData}
            provinces={provinces}
            setProvinces={setProvinces}
            districts={districts}
            setDistricts={setDistricts}
            wards={wards}
            setWards={setWards}
            errors={errors}
            setErrors={setErrors}
            selectedPaymentMethod={selectedPaymentMethod}
            setSelectedPaymentMethod={setSelectedPaymentMethod}
            paymentError={paymentError}
            setTab={setTab}
          />
        </div>
        <div
          className={`${
            isSticky ? "top-28" : "top-0"
          } sticky h-fit w-2/5 rounded-md border-2 border-input bg-white p-5 shadow-md`}
        >
          <OrderSummary cartItems={cartItems} />
        </div>
      </div>

      <div className="mt-10 flex justify-between">
        <Button disabled={tab === 0} onClick={prevStep}>
          Back
        </Button>
        <Button disabled={tab === tabs.length - 1} onClick={nextStep}>
          {getButtonText(tab)}
        </Button>
      </div>
    </div>
  );
}

export default OrderPage;
