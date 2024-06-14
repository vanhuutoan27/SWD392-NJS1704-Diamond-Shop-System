import { projectName } from "@/lib/constants"

function AboutInfo() {
  return (
    <div className="flex w-full gap-8">
      <div className="hidden justify-center lg:flex lg:w-1/2">
        <img
          src="https://images.unsplash.com/photo-1559006864-38a01f201f95?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
          alt={projectName}
          className="h-[630px] w-full rounded-md object-cover shadow-md"
        />
      </div>
      <div className="text-left lg:w-1/2">
        <h2 className="mb-2 text-4xl font-semibold uppercase">
          Welcome to {projectName}
        </h2>
        <p className="mb-2 text-sm">
          {projectName} is proud to be a diamond expert in Vietnam with the
          mission of helping customers protect their assets in the safest and
          most sustainable way. {projectName} products are increasingly popular
          with customers because of GIA standard diamond quality and a variety
          of new and modern jewelry designs.
        </p>
        <p className="mb-4 text-sm">
          {projectName} is increasingly perfecting and affirming its position in
          the diamond market in Vietnam and the world.
        </p>

        <h2 className="mb-2 text-2xl font-medium uppercase">Vision</h2>
        <p className="mb-6 text-sm">
          Becoming an expert company in Vietnam in the diamond field, bringing
          quality diamond products and creative jewelry designs that honor
          beauty and reach the world.
        </p>

        <h2 className="mb-2 text-2xl font-medium uppercase">Mission</h2>
        <p className="mb-6 text-sm">
          Help customers accumulate diamonds in a safe, sustainable way and
          constantly improve to bring valuable products worthy of customers.
        </p>

        <h2 className="mb-2 text-2xl font-medium uppercase">
          {projectName} Jewelry
        </h2>
        <p className="mb-6 text-sm">
          Bringing you a different experience with a private VIP room space,
          exquisite jewelry design, bold personal impression and guaranteed
          quality with the most modern diamond testing technology from GIA.
        </p>

        <h2 className="mb-2 text-2xl font-medium uppercase">
          {projectName} Diamond
        </h2>
        <p className="mb-6 text-sm">
          100% of diamonds at {projectName} are imported through official
          customs, possessing full transparent legal documents, firmly
          protecting your assets.
        </p>
      </div>
    </div>
  )
}

export default AboutInfo
