import { useState } from "react";
import { Button } from "@/components/atoms/button";
import { contactSchema } from "@/schemas/ContactForm";
import { z } from "zod";

interface Errors {
  name?: string;
  email?: string;
  subject?: string;
  content?: string;
}

function ContactForm() {
  const formUrl =
    "https://docs.google.com/forms/u/0/d/e/1FAIpQLSe86NtCNVbYjdxVNmGLoGAuypfrS2kDCpZiJnZ5hV-FiKUWlg/formResponse";

  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [subject, setSubject] = useState("");
  const [content, setContent] = useState("");
  const [errors, setErrors] = useState<Errors>({});

  const handleReset = () => {
    setName("");
    setEmail("");
    setSubject("");
    setContent("");
    setErrors({});
  };

  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    const formData = {
      name,
      email,
      subject,
      content,
    };

    try {
      contactSchema.parse(formData);

      const form = new FormData();
      form.append("entry.992756596", name);
      form.append("entry.289138189", email);
      form.append("entry.1193730251", subject);
      form.append("entry.764643230", content);

      console.log(
        "Submitting form with data:",
        Object.fromEntries(form.entries()),
      );

      await fetch(formUrl, {
        method: "POST",
        mode: "no-cors",
        body: form,
      });
      console.log("Form submitted successfully");
      handleReset();
    } catch (error) {
      if (error instanceof z.ZodError) {
        const fieldErrors = error.flatten().fieldErrors;
        const formattedErrors: Errors = {};
        for (const key in fieldErrors) {
          if (fieldErrors.hasOwnProperty(key)) {
            formattedErrors[key as keyof Errors] = fieldErrors[key]?.join(" ");
          }
        }
        setErrors(formattedErrors);
        console.error("Validation errors:", formattedErrors);
      } else {
        console.error("Error submitting form:", error);
      }
    }
  };

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
  ) => {
    const { name, value } = e.target;
    switch (name) {
      case "name":
        setName(value);
        break;
      case "email":
        setEmail(value);
        break;
      case "subject":
        setSubject(value);
        break;
      case "content":
        setContent(value);
        break;
      default:
        break;
    }

    setErrors((prevErrors) => ({
      ...prevErrors,
      [name]: undefined,
    }));
  };

  return (
    <div className="flex h-full">
      <div className="w-full rounded-xl border-input bg-white px-7 py-10 shadow-md">
        <form className="flex flex-col" onSubmit={handleSubmit}>
          <h3 className="mb-4 text-3xl font-semibold">Message for us!</h3>

          <input
            type="text"
            name="name"
            placeholder="Your Name"
            value={name}
            onChange={handleInputChange}
            className="mb-1 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />
          {errors.name && (
            <p className="ml-2 text-xs text-red-500">{errors.name}</p>
          )}

          <input
            type="email"
            name="email"
            placeholder="Your Email"
            value={email}
            onChange={handleInputChange}
            className="mb-1 mt-2 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />
          {errors.email && (
            <p className="ml-2 text-xs text-red-500">{errors.email}</p>
          )}

          <input
            type="text"
            name="subject"
            placeholder="Your Subject"
            value={subject}
            onChange={handleInputChange}
            className="mb-1 mt-2 w-full rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />
          {errors.subject && (
            <p className="ml-2 text-xs text-red-500">{errors.subject}</p>
          )}

          <textarea
            name="content"
            rows={7}
            placeholder="Your Message"
            value={content}
            onChange={handleInputChange}
            className="mb-1 mt-2 w-full resize-none rounded-md border-[1.5px] border-input bg-transparent px-5 py-3 text-sm outline-none"
          />
          {errors.content && (
            <p className="ml-2 text-xs text-red-500">{errors.content}</p>
          )}

          <Button type="submit" className="mt-4 py-6">
            Send
          </Button>
        </form>
      </div>
    </div>
  );
}

export default ContactForm;
