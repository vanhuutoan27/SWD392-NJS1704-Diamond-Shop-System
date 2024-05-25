import { useRef } from "react";
import { jsPDF } from "jspdf";
import { toPng } from "html-to-image";
import { Button } from "@/components/global/atoms/button";
import BreadcrumbComponent from "@/components/global/molecules/BreadcrumbComponent";
import Section from "@/components/global/organisms/Section";

const InvoicePage = () => {
  const invoiceRef = useRef(null);

  const downloadPDF = () => {
    const input = invoiceRef.current;
    if (input) {
      toPng(input, { cacheBust: true })
        .then((dataUrl) => {
          const pdf = new jsPDF("p", "mm", "a4");
          const imgProps = pdf.getImageProperties(dataUrl);
          const pdfWidth = pdf.internal.pageSize.getWidth();
          const pdfHeight = (imgProps.height * pdfWidth) / imgProps.width;
          pdf.addImage(dataUrl, "PNG", 0, 0, pdfWidth, pdfHeight);
          pdf.save("invoice.pdf");
        })
        .catch((error) => {
          console.error("Error generating PDF: ", error);
        });
    }
  };

  const invoiceData = {
    invoiceId: "#STK83084398239",
    dateIssued: "29, Nov 2027",
    dueDate: "29, Dec 2027",
    dueAmount: "$2,578.90",
    billingFrom: {
      name: "Super Technologies",
      email: "contact@example.com",
      address: "2972 Westheimer Rd. Santa Ana",
    },
    billingTo: {
      name: "Devid Wilium",
      email: "contact@example.com",
      address: "New York, USA 2707 Davis Anenue",
    },
    items: [
      {
        brand: "Techno",
        description: "Kemon 24 smart phone",
        quantity: 1,
        price: 200,
        total: 200,
      },
      {
        brand: "Vivo",
        description: "Vivo 32 smart phone",
        quantity: 3,
        price: 300,
        total: 900,
      },
      {
        brand: "Samsung",
        description: "S23 Ultra",
        quantity: 1,
        price: 1300,
        total: 1300,
      },
      {
        brand: "Apple",
        description: "iPhone 15Pro Max",
        quantity: 2,
        price: 1200,
        total: 2400,
      },
      {
        brand: "Oppo",
        description: "Fold X",
        quantity: 1,
        price: 900,
        total: 900,
      },
    ],
    subtotal: 4700,
    shippingCost: 10,
    discount: 470,
    vat: 235,
    total: 4475,
  };

  return (
    <div className="container">
      <BreadcrumbComponent
        lastPage={"Home"}
        lastPageUrl="/"
        currentPage="Invoices"
      />

      <Section pageName="Invoices" />

      <div className="border-2 border-input shadow-md">
        <div className="p-10" ref={invoiceRef}>
          <div className="mb-10 flex justify-between gap-5">
            <div>
              <p className="mb-1.5 font-medium">Billing From:</p>
              <h4 className="mb-3 text-xl font-semibold text-primary">
                Super Technologies
              </h4>
              <p className="text-sm text-secondary">
                <span className="font-medium text-primary">Email: </span>
                contact@example.com
              </p>
              <p className="mt-1.5 text-sm text-secondary">
                <span className="font-medium text-primary">Address: </span>
                2972 Westheimer Rd. Santa Ana.
              </p>
            </div>

            <div>
              <p className="mb-1.5 font-medium">Billing To:</p>
              <h4 className="mb-3 text-xl font-semibold text-primary">
                Devid wilium
              </h4>
              <p className="text-sm text-secondary">
                <span className="font-medium text-primary">Email: </span>
                contact@example.com
              </p>
              <p className="mt-1.5 text-sm text-secondary">
                <span className="font-medium text-primary">Address: </span>
                New York, USA 2707 Davis Anenue
              </p>
            </div>
          </div>

          <div className="mb-10 grid grid-cols-1 border-2 border-input sm:grid-cols-4">
            <div className="border-r-2 border-input px-5 py-4">
              <h5 className="mb-1.5 font-semibold">Invoice ID:</h5>
              <span className="text-sm font-medium">
                {invoiceData.invoiceId}
              </span>
            </div>
            <div className="border-r-2 border-input px-5 py-4">
              <h5 className="mb-1.5 font-semibold">Date Issued:</h5>
              <span className="text-sm font-medium">
                {invoiceData.dateIssued}
              </span>
            </div>
            <div className="border-r-2 border-input px-5 py-4">
              <h5 className="mb-1.5 font-semibold">Due Date:</h5>
              <span className="text-sm font-medium">{invoiceData.dueDate}</span>
            </div>
            <div className="px-5 py-4">
              <h5 className="mb-1.5 font-semibold">Due Amount:</h5>
              <span className="text-sm font-medium">
                {invoiceData.dueAmount}
              </span>
            </div>
          </div>

          <div className="grid grid-cols-12 border-2 border-input py-3.5 pl-5 pr-6">
            <div className="col-span-3">
              <h5 className="font-semibold">Brand name</h5>
            </div>
            <div className="col-span-4">
              <h5 className="font-semibold">Description</h5>
            </div>
            <div className="col-span-2">
              <h5 className="font-semibold">Quantity</h5>
            </div>
            <div className="col-span-2">
              <h5 className="font-semibold">Price Per Unit</h5>
            </div>
            <div className="col-span-1">
              <h5 className="text-right font-semibold">Total</h5>
            </div>
          </div>

          {invoiceData.items.map((item, index) => (
            <div
              key={index}
              className="grid grid-cols-12 border-2 border-t-0 border-input py-3.5 pl-5 pr-6"
            >
              <div className="col-span-3">
                <p className="text-sm font-medium text-secondary">
                  {item.brand}
                </p>
              </div>
              <div className="col-span-4">
                <p className="text-sm font-medium text-secondary">
                  {item.description}
                </p>
              </div>
              <div className="col-span-2">
                <p className="text-sm font-medium text-secondary">
                  {item.quantity}
                </p>
              </div>
              <div className="col-span-2">
                <p className="text-sm font-medium text-secondary">
                  ${item.price}
                </p>
              </div>
              <div className="col-span-1">
                <p className="text-right font-medium text-secondary">
                  ${item.total}
                </p>
              </div>
            </div>
          ))}

          <div className="mt-10">
            <div className="flex justify-between px-4">
              <div className="w-1/2"></div>
              <div className="flex w-1/2 flex-col gap-4">
                <p className="flex justify-between font-medium">
                  <span>Subtotal</span>
                  <span>${invoiceData.subtotal}</span>
                </p>
                <p className="flex justify-between font-medium">
                  <span>Shipping Cost (+)</span>
                  <span>$10.00</span>
                </p>
                <p className="flex justify-between font-medium">
                  <span>
                    Coupon Discount<span className="text-meta-3">(10%)</span>
                  </span>
                  <span>${invoiceData.discount}</span>
                </p>
                <p className="flex justify-between font-medium">
                  <span>
                    Vat <span className="text-red">(5%)</span>
                  </span>
                  <span>${invoiceData.vat}</span>
                </p>
                <p className="flex justify-between">
                  <span className="font-medium">Total</span>
                  <span className="text-meta-3 font-semibold">
                    ${invoiceData.total}
                  </span>
                </p>
              </div>
            </div>
          </div>
        </div>

        <div className="flex w-full justify-end p-10 pt-0">
          <Button onClick={downloadPDF}>Download</Button>
        </div>
      </div>
    </div>
  );
};

export default InvoicePage;
