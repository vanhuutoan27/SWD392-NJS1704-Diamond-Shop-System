function MemberList({ member }) {
  return (
    <div className="mx-auto w-1/6 max-w-xs overflow-hidden rounded text-center shadow-lg">
      <img className="w-full" src={member.img} alt={member.name} />
      <div className="px-6 py-4">
        <div className="mb-2 text-lg font-medium">{member.name}</div>
        <p className="text-sm text-gray-700">{member.role}</p>
      </div>
    </div>
  );
}

export default MemberList;
