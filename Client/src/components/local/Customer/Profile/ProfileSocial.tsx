import { Facebook, Github, Instagram, Twitter } from "lucide-react"

function ProfileSocial() {
  return (
    <div className="mt-10 flex flex-col items-center justify-center">
      <h3 className="flex justify-center font-medium">Follow Me On</h3>
      <div className="mt-4 flex w-full cursor-pointer justify-center gap-6 text-gray-600">
        <Facebook
          size={20}
          className="slow text-primary hover:text-secondary"
        />
        <Twitter size={20} className="slow text-primary hover:text-secondary" />
        <Instagram
          size={20}
          className="slow text-primary hover:text-secondary"
        />
        <Github size={20} className="slow text-primary hover:text-secondary" />
      </div>
    </div>
  )
}

export default ProfileSocial
