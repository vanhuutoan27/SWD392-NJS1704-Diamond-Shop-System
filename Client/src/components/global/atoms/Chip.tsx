interface ChipProps {
  content: string
  color: string
  outline?: boolean
  icon?: React.ReactNode
}

function Chip({ content, color, outline, icon }: ChipProps) {
  const chipClasses = `inline-flex select-none cursor-pointer items-center rounded-[50px] px-4 py-[6px] text-xs text-white ${outline ? "border-2" : ""}`

  const chipStyles = {
    backgroundColor: outline ? "white" : color,
    borderColor: outline ? color : "",
    color: outline ? color : "white"
  }

  return (
    <div className={chipClasses} style={chipStyles}>
      <span>{content}</span>
      {icon && <span className="ml-1">{icon}</span>}
    </div>
  )
}

export default Chip
