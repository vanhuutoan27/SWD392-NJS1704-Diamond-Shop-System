import { TabsList, TabsTrigger } from "./CartTabs";

function CartCategories() {
  return (
    <div>
      <h3 className="mb-4 ml-4 text-xl font-semibold uppercase">Categories</h3>
      <TabsList className="flex w-full flex-col gap-2">
        <TabsTrigger value="all">All Cart</TabsTrigger>
        <TabsTrigger value="jewelry">Jewelry</TabsTrigger>
        <TabsTrigger value="diamond">Diamond</TabsTrigger>
      </TabsList>
    </div>
  );
}

export default CartCategories;
