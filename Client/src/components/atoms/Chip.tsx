function Chip({ content }: { content: string }) {
  return (
    <div className="cursor-pointer rounded-md border-[1px] border-slate-700 px-4 py-1 text-sm slow hover:bg-primary hover:text-white">
      {content}
    </div>
  );
}

export default Chip;
