import { TabsContent } from "@/pages/Cart/tabs";
import { cartColumns } from "@/components/local/Customer/Cart/CartColumns";
import { cartJewelryColumns } from "@/components/local/Customer/Cart/CartJewelryColumns";
import { cartDiamondColumns } from "@/components/local/Customer/Cart/CartDiamondColumns";
import { DataTable } from "@/components/local/Customer/Cart/CartDataTable";
import { ICart, ICartType } from "@/types/cart.interface";
import { Button } from "@/components/global/atoms/button";
import { Link } from "react-router-dom";
import { calculateCartTotal, formatCurrency, scrollToTop } from "@/lib/utils";
import { ScrollArea, ScrollBar } from "@/components/global/atoms/scroll-area";
import { useEffect, useState } from "react";
import { diamondData } from "@/constants/diamond";
import { jewelryData } from "@/constants/jewelry";

interface renderTabContentProps {
  type: string;
  title: string;
  columns: any[];
  data: any[];
  subTotal: number;
}

function CartTable() {
  const [cartItems, setCartItems] = useState<ICart[]>([]);

  useEffect(() => {
    const storedCartItems = localStorage.getItem("cartItems");
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems));
    }
  }, []);

  const getProductDetails = (productId: string, type: ICartType) => {
    if (type === ICartType.Diamond) {
      return diamondData.find((diamond) => diamond.diamondId === productId);
    } else if (type === ICartType.Jewelry) {
      return jewelryData.find((jewelry) => jewelry.jewelryId === productId);
    }
  };

  const enrichCartItems = (items: ICart[]) => {
    return items.map((item) => {
      const productDetails = getProductDetails(
        item.productId,
        item.productType,
      );
      return { ...item, ...productDetails };
    });
  };

  const allItemsInCart = cartItems.filter((item) => item.quantity > 0);
  const diamondsInCart = enrichCartItems(
    allItemsInCart.filter((item) => item.productType === ICartType.Diamond),
  );
  const jewelriesInCart = enrichCartItems(
    allItemsInCart.filter((item) => item.productType === ICartType.Jewelry),
  );

  const vatPercentage = 0.1;

  const tabData = [
    {
      type: "all",
      title: `All products in the cart (${allItemsInCart.length})`,
      columns: cartColumns,
      data: allItemsInCart,
      subTotal: calculateCartTotal(allItemsInCart),
    },
    {
      type: "jewelry",
      title: `All Jewelries in the cart (${jewelriesInCart.length})`,
      columns: cartJewelryColumns,
      data: jewelriesInCart,
      subTotal: calculateCartTotal(jewelriesInCart),
    },
    {
      type: "diamond",
      title: `All Diamonds in the cart (${diamondsInCart.length})`,
      columns: cartDiamondColumns,
      data: diamondsInCart,
      subTotal: calculateCartTotal(diamondsInCart),
    },
  ];

  const renderTabContent = ({
    type,
    title,
    columns,
    data,
    subTotal,
  }: renderTabContentProps) => {
    const vatAmount = subTotal * vatPercentage;
    const total = subTotal + vatAmount;

    return (
      <TabsContent value={type} key={type}>
        <h3 className="mb-4 ml-4 text-xl font-semibold uppercase">{title}</h3>

        <ScrollArea className="rounded-md border shadow-md">
          <DataTable columns={columns} data={data} />
          <ScrollBar orientation="horizontal" />
        </ScrollArea>

        <div className="text-md mt-8 flex w-full flex-col gap-4 pl-2 font-medium">
          <div className="flex justify-between">
            <span>Sub-Total:</span>
            <span>{formatCurrency(subTotal)}</span>
          </div>
          <div className="flex justify-between">
            <span>VAT ({vatPercentage * 100}%):</span>
            <span>{formatCurrency(vatAmount)}</span>
          </div>
          <div className="flex justify-between">
            <span>Total:</span>
            <span>{formatCurrency(total)}</span>
          </div>
        </div>
      </TabsContent>
    );
  };

  return (
    <div className="flex flex-col gap-8">
      {tabData.map(renderTabContent)}

      <div className="flex w-full justify-end gap-4">
        <Link to="/jewelry" onClick={scrollToTop}>
          <Button type="button" variant={"secondary"}>
            Continue Shopping
          </Button>
        </Link>
        <Link to="/checkout" onClick={scrollToTop}>
          <Button type="button">Checkout</Button>
        </Link>
      </div>
    </div>
  );
}

export default CartTable;
