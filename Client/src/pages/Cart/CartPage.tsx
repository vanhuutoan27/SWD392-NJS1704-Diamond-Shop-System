import { Tabs } from "@/components/atoms/tabs";
import Section from "@/components/organisms/Section";
import CartCategories from "@/components/specific/Cart/CartCategories";
import CartTable from "@/components/specific/Cart/CartTable";

function CartPage() {
  return (
    <div className="container">
      <Section pageName={"Diamond Cart"} />

      <Tabs
        defaultValue="all"
        className="mt-4 flex w-full justify-between gap-8"
      >
        <div className="w-1/4">
          <CartCategories />
        </div>

        <div className="w-3/4">
          <CartTable />
        </div>
      </Tabs>
    </div>
  );
}

export default CartPage;
