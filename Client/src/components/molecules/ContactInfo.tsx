import { Mails, Smartphone, MapPin } from "lucide-react";

function ContactInfo() {
  return (
    <div className="flex w-1/2">
      <div className="flex flex-col justify-center">
        <div className="mb-4 flex text-gray-600">
          <MapPin className="mr-2" />
          D1, Long Thanh My, Thu Duc, Ho Chi Minh
        </div>
        <div className="mb-4 flex text-gray-600">
          <Mails className="mr-2" />
          Diamoon@gmail.com
        </div>
        <div className="mb-4 flex text-gray-600">
          <Smartphone className="mr-2" />
          0963188759 / 0954168748
        </div>
      </div>
    </div>
  );
}

export default ContactInfo;
