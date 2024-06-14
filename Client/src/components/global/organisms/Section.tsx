function Section({ pageName }: { pageName: string }) {
  return (
    <div className="relative mb-8">
      <h3 className="w-fit select-none border-b-4 border-primary text-xl font-semibold uppercase leading-[60px]">
        {pageName}
      </h3>
      <div className="absolute inset-x-0 bottom-0 h-[2px] bg-primary" />
    </div>
  )
}

export default Section
