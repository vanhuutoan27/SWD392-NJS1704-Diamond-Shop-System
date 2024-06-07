import { useEffect, useState } from "react";
import { IJewelry } from "@/types/jewelry.interface";
import { addToCart, formatCurrency } from "@/lib/utils";
import { ICart, IJewelryCart } from "@/types/cart.interface";
import { toast } from "sonner";
import { Button } from "@/components/global/atoms/button";
import Section from "@/components/global/organisms/Section";
import { useAuthContext } from "@/contexts/AuthContext";

function JewelryDetails({ jewelryDetails }: { jewelryDetails: IJewelry }) {
  const { user } = useAuthContext();
  const [cartItems, setCartItems] = useState<ICart[]>([]);
  const [currentImageIndex, setCurrentImageIndex] = useState(0);

  const salePrice = 100000; // Placeholder for the sale price

  useEffect(() => {
    const storedCartItems = localStorage.getItem("cartItems");
    if (storedCartItems) {
      setCartItems(JSON.parse(storedCartItems));
    }
  }, []);

  const handleMouseMove = (event: React.MouseEvent<HTMLDivElement>) => {
    const container = event.currentTarget;
    const rect = container.getBoundingClientRect();
    const x = ((event.clientX - rect.left) / rect.width) * 100;
    const y = ((event.clientY - rect.top) / rect.height) * 100;
    container.style.setProperty("--x", `${x}%`);
    container.style.setProperty("--y", `${y}%`);
  };

  const selectImage = (index: number) => {
    setCurrentImageIndex(index);
  };

  const handleAddToCart = () => {
    if (!user) {
      toast.error("Please login to add to cart");
      return;
    } else {
      const newItem: IJewelryCart = {
        cartId: `C${jewelryDetails.jewelryId}`,
        productType: 'Jewelry',
        productId: jewelryDetails.jewelryId,
        quantity: 1,
        price: jewelryDetails.price,
        image: jewelryDetails.images ? jewelryDetails.images[0] : "",
        jewelryName: jewelryDetails.jewelryName,
      };
      const updatedCart = addToCart(cartItems, newItem);
      setCartItems(updatedCart);
      localStorage.setItem("cartItems", JSON.stringify(updatedCart));

      toast.success("Added to cart successfully");

      window.dispatchEvent(new CustomEvent("cartChanged"));
    }
  };

  return (
    <>
      <div className="flex w-full gap-10">
        <div className="w-1/2">
          <div
            className="image-container h-[500px] rounded-md border-2 border-input"
            onMouseMove={handleMouseMove}
          >
            <img
              src={
                jewelryDetails.images && jewelryDetails.images.length > 0
                  ? jewelryDetails.images[currentImageIndex]
                  : ""
              }
              alt="Jewelry"
              className="w-full cursor-pointer"
            />
          </div>

          <div className="mt-4 flex w-full">
            {jewelryDetails.images &&
              jewelryDetails.images.map((image, index) => (
                <img
                  key={index}
                  src={image}
                  alt={`Thumbnail ${index}`}
                  className={`slow h-auto w-28 cursor-pointer border-2 ${
                    currentImageIndex === index
                      ? "border-3 border-primary duration-300"
                      : "opacity-30 hover:border-primary"
                  }`}
                  onClick={() => selectImage(index)}
                />
              ))}
          </div>
        </div>

        <div className="mt-5 flex w-1/2 flex-col gap-4">
          <h2 className="text-xl uppercase">{jewelryDetails.jewelryName}</h2>

          {salePrice ? (
            <span className="flex">
              <span className="mr-2 text-base font-semibold">
                {formatCurrency(salePrice)}
              </span>
              <span className=" font-medium text-[#bababa] line-through">
                {formatCurrency(jewelryDetails.price)}
              </span>
            </span>
          ) : (
            <span className="mr-2 text-base font-semibold">
              {formatCurrency(jewelryDetails.price)}
            </span>
          )}

          <p className="text-sm text-[#555]">
            Price may vary depending on actual product size and weight. <br />
            Please call{" "}
            <span className="font-semibold text-primary">
              (84) 098 765 321
            </span>{" "}
            for support.
          </p>

          <div className="mt-8 flex w-full gap-4">
            <Button type="button" variant={"secondary"}>
              Message
            </Button>
            <Button type="button" onClick={handleAddToCart}>
              Add To Cart
            </Button>
          </div>
        </div>
      </div>

      <div className="mt-4">
        <Section pageName={"Jewelry Details"} />

        <table className="w-full border-collapse">
          <tbody>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-secondary">
                Jewelry Category
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.jewelryCategory}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Main Stone Size
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.mainStoneSize}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-secondary">
                Side Stone Type
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.sideStoneType}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Side Stone Quantity
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.sideStoneQuantity}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-secondary">
                Side Stone Weight
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.sideStoneWeight}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Gold Type
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.goldType}
              </td>
            </tr>
            <tr>
              <td className="border-2 border-input px-4 py-2 text-secondary">
                Gold Karat
              </td>
              <td className="border-2 border-input px-4 py-2 italic">
                {jewelryDetails.goldKarat}
              </td>
            </tr>
            <tr>
              <td className="w-[300px] border-2 border-input bg-slate-50 px-4 py-2 text-secondary">
                Gold Weight
              </td>
              <td className="border-2 border-input bg-slate-50 px-4 py-2 italic">
                {jewelryDetails.goldWeight}
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </>
  );
}

export default JewelryDetails;
