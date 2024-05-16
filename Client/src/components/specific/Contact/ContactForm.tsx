import { Button } from "@/components/atoms/button";

function ContactForm() {
  return (
    <div className="flex h-full">
      <div className="w-full rounded-xl border-input bg-white px-7 py-10 shadow-md">
        <form className="flex flex-col gap-4">
          <h3 className="mb-4 text-3xl font-semibold">Message for us!</h3>

          <input
            type="text"
            placeholder="Your Name"
            className="mb-1 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />

          <input
            type="email"
            placeholder="Your Email"
            className="mb-1 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />

          <input
            type="text"
            placeholder="Your Subject"
            className="mb-1 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />

          <textarea
            rows={7}
            placeholder="Your Message"
            className="mb-1 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none resize-none"
            
          />

          <Button type="submit" className="mt-4 py-6">
            Send
          </Button>
        </form>
      </div>
    </div>
  );
}

export default ContactForm;
