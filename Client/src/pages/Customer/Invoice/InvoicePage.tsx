import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/global/atoms/accordion";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";
import { formatInvoiceData } from "@/lib/utils";
import { ICart } from "@/types/cart.interface";
import { useParams } from "react-router-dom";
import { vatPercentage } from "@/lib/constants";
import InvoiceCard from "@/components/local/Customer/Invoice/InvoiceCard";
import InvoiceItem from "@/components/local/Customer/Invoice/InvoiceItem";
import { useGetAllDiamonds } from "@/apis/diamondApi";
import { useGetAllJewelries } from "@/apis/jewelryApi";
import { Loader } from "@/components/global/atoms/Loader";
import { toast } from "sonner";
import { useEffect } from "react";
import { useGetAllUsers } from "@/apis/userApi";

function InvoicePage() {
  const { userId } = useParams<{ userId: string }>();

  const {
    data: allDiamonds,
    error: diamondsError,
    isLoading: isDiamondsLoading,
  } = useGetAllDiamonds();

  const {
    data: allJewelries,
    error: jewelriesError,
    isLoading: isJewelriesLoading,
  } = useGetAllJewelries();

  const {
    data: allUsers,
    error: usersError,
    isLoading: isUsersLoading,
  } = useGetAllUsers();

  useEffect(() => {
    if (diamondsError || jewelriesError || usersError) {
      toast.error("Failed to fetch data");
    }
  }, [diamondsError, jewelriesError, usersError]);

  if (isDiamondsLoading || isJewelriesLoading || isUsersLoading) {
    return <Loader />;
  }

  if (!allUsers || !allDiamonds || !allJewelries) {
    return <Loader />;
  }

  function getProductData(cartItem: ICart) {
    switch (cartItem.productType) {
      case "Diamond":
        return allDiamonds?.find(
          (item) => item.diamondId === cartItem.productId,
        );
      case "Jewelry":
        return allJewelries?.find(
          (item) => item.jewelryId === cartItem.productId,
        );
      default:
        return null;
    }
  }

  const billingToUser = allUsers.find((u) => u.id === userId);

  if (!billingToUser) {
    return <div>User not found</div>;
  }

  const invoiceDataList = [
    {
      invoiceId: "DIAMOON27082003",
      dateCreated: "25 May 2024",
      paymentDate: "25 May 2024",
      billingTo: billingToUser,
      items: [
        {
          productType: "Diamond",
          productId: "d2c73200-1ae0-4066-9475-0bda2e220d57",
          skuID: "D001",
          quantity: 1,
        },
        {
          productType: "Jewelry",
          productId: "734aab01-8668-4e5c-8afb-473b05fc52c0",
          skuID: "J001",
          quantity: 3,
        },
        {
          productType: "Jewelry",
          productId: "1876fa93-1502-4d84-93ae-5ba6301d63cb",
          skuID: "J002",
          quantity: 1,
        },
      ],
    },
    {
      invoiceId: "DIAMOON27082004",
      dateCreated: "26 May 2024",
      paymentDate: "26 May 2024",
      billingTo: billingToUser,
      items: [
        {
          productType: "Diamond",
          productId: "d2c73200-1ae0-4066-9475-0bda2e220d57",
          skuID: "D001",
          quantity: 2,
        },
        {
          productType: "Jewelry",
          productId: "734aab01-8668-4e5c-8afb-473b05fc52c0",
          skuID: "J001",
          quantity: 1,
        },
        {
          productType: "Jewelry",
          productId: "1876fa93-1502-4d84-93ae-5ba6301d63cb",
          skuID: "J002",
          quantity: 4,
        },
      ],
    },
  ];

  const formattedInvoices = invoiceDataList.map((invoiceData) => {
    const mappedItems = invoiceData.items.map((item) => {
      const productData = getProductData(item as ICart);
      return {
        ...item,
        description: productData
          ? "jewelryName" in productData
            ? productData.jewelryName
            : `NATURAL DIAMOND x ${productData.size}MM`
          : "",
        price: productData?.price || 0,
        total: (productData?.price || 0) * item.quantity,
      };
    });

    return formatInvoiceData(
      { ...invoiceData, items: mappedItems },
      vatPercentage,
    );
  });

  console.log(formattedInvoices);

  return (
    <div className="container mx-auto px-4 py-8">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="Invoices"
      />

      <Section pageName="Invoices" />

      <Accordion
        type="single"
        collapsible
        className="flex w-full flex-col gap-4"
      >
        {formattedInvoices.map((formattedInvoiceData, index) => (
          <AccordionItem value={`item-${index}`} key={index}>
            <div className="rounded-md border-2 border-input px-10 py-2 shadow-md">
              <AccordionTrigger>
                <InvoiceCard formattedInvoiceData={formattedInvoiceData} />
              </AccordionTrigger>
            </div>
            <AccordionContent>
              <InvoiceItem
                formattedInvoiceData={formattedInvoiceData}
                billingToUser={billingToUser}
              />
            </AccordionContent>
          </AccordionItem>
        ))}
      </Accordion>
    </div>
  );
}

export default InvoicePage;
