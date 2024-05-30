using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task RemoveUserFromRoleAsync(Guid userId, string[] roles);
        Task AddRoleForUserAsync(Guid userId, Guid roleId);
    }
}
