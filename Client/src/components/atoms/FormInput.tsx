function FormInput() {
  return (
    <div className="form_input flex w-1/2 justify-center">
      <div className="mx-auto w-full max-w-md rounded-md bg-white p-6 shadow-md">
        <form>
          <div className="mb-4">
            <label
              htmlFor="name"
              className="mb-2 block font-semibold text-gray-700"
            >
              Name
            </label>
            <input
              type="text"
              id="name"
              name="name"
              placeholder="Your Name"
              className="w-full rounded-md border border-gray-300 p-2"
              required
            />
          </div>
          <div className="mb-4">
            <label
              htmlFor="email"
              className="mb-2 block font-semibold text-gray-700"
            >
              Email
            </label>
            <input
              type="email"
              id="email"
              name="email"
              placeholder="Your Email"
              className="w-full rounded-md border border-gray-300 p-2"
              required
            />
          </div>
          <div className="mb-4">
            <label
              htmlFor="subject"
              className="mb-2 block font-semibold text-gray-700"
            >
              Subject
            </label>
            <input
              type="subject"
              id="subject"
              name="subject"
              placeholder="Your Subject"
              className="w-full rounded-md border border-gray-300 p-2"
              required
            />
          </div>
          <div className="mb-4">
            <label
              htmlFor="message"
              className="mb-2 block font-semibold text-gray-700"
            >
              Message
            </label>
            <textarea
              id="message"
              name="message"
              placeholder="Your Message"
              className="h-32 w-full rounded-md border border-gray-300 p-2"
              required
            ></textarea>
          </div>
          <button
            type="submit"
            className="rounded-md bg-black px-4 py-2 text-white transition duration-300 hover:bg-blue-600"
          >
            Send
          </button>
        </form>
      </div>
    </div>
  );
}

export default FormInput;
