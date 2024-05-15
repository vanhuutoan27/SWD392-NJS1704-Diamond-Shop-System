import { TabsContent } from "@/components/atoms/tabs";
import { cartColumns } from "@/components/specific/Cart/CartColumns";
import { cartJewelryColumns } from "@/components/specific/Cart/CartJewelryColumns";
import { cartDiamondColumns } from "@/components/specific/Cart/CartDiamondColumns";
import { DataTable } from "@/components/specific/Cart/CartDataTable";
import { cartData } from "@/constants/cart";
import { ICartType } from "@/types/cart.interface";
import { Button } from "@/components/atoms/button";
import { Link } from "react-router-dom";
import { calculateCartTotal, formatCurrency } from "@/lib/utils";
import { ScrollArea, ScrollBar } from "@/components/atoms/scroll-area";

interface renderTabContentProps {
  type: string;
  title: string;
  columns: any[];
  data: any[];
  subTotal: number;
}

function CartTable() {
  const allItemsInCart = cartData.filter((item) => item.quantity > 0);
  const diamondsInCart = allItemsInCart.filter(
    (item) => item.productType === ICartType.Diamond,
  );
  const jewelriesInCart = allItemsInCart.filter(
    (item) => item.productType === ICartType.Jewelry,
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
        <Link to="/jewelry">
          <Button type="button" variant={"secondary"}>
            Continue Shopping
          </Button>
        </Link>
        <Link to="/checkout">
          <Button type="button">Checkout</Button>
        </Link>
      </div>
    </div>
  );
}

export default CartTable;
