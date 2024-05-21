import { Facebook, Github, Instagram, Twitter } from "lucide-react";

function FollowMe() {
  return (
    <div className="container">
      <div className="flex justify-center text-xs font-medium text-secondary">
        Follow me on
      </div>
      <div className="mt-1 flex w-full cursor-pointer justify-center gap-6 text-gray-600">
        <Facebook size={20} />
        <Twitter size={20} />
        <Instagram size={20} />
        <Github size={20} />
      </div>
    </div>
  );
}

export default FollowMe;
