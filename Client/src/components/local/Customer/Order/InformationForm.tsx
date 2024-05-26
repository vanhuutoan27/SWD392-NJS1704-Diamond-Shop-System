import { Checkbox } from "@/components/global/atoms/checkbox";

function InformationForm() {
  return (
    <div className="flex flex-col gap-8">
      <div>
        <h4 className="mb-2 pl-4">Contact Information</h4>

        <input type="email" placeholder="Email" className="input-field" />
      </div>

      <div>
        <h4 className="mb-2 pl-4">Billing Address</h4>

        <div className="flex flex-col gap-4">
          <input type="text" placeholder="Full name" className="input-field" />

          <input
            type="text"
            placeholder="Street address"
            className="input-field"
          />

          <input
            type="text"
            placeholder="Apartment, suite, unit etc. (optional)"
            className="input-field"
          />

          <input
            type="text"
            placeholder="Town / City"
            className="input-field"
          />

          <div className="flex justify-between gap-4">
            <input
              type="text"
              placeholder="Country / Region"
              className="input-field"
            />

            <input type="text" placeholder="State" className="input-field" />

            <input type="text" placeholder="ZIP Code" className="input-field" />
          </div>
        </div>
      </div>

      <div>
        <div className="flex justify-between px-4">
          <h4 className="mb-2">Ship to a different address?</h4>
          <Checkbox />
        </div>

        <textarea
          rows={3}
          placeholder="Order notes (Optional)"
          className="input-field resize-none"
        />
      </div>
    </div>
  );
}

export default InformationForm;
