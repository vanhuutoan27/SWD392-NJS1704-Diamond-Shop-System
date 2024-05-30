using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class UserRepository : RepositoryBase<AppUser, Guid>, IUserRepository
    {
        public UserRepository(DiamondContext context) : base(context)
        {

        }

        public async Task AddRoleForUserAsync(Guid userId, Guid roleId)
        {
            //if (userId == null || roleId == null)
            //{
            //    return;
            //}

            //_context.UserRoles.Add()
        }

        public async Task RemoveUserFromRoleAsync(Guid userId, string[] roles)
        {
            if (roles.Length == 0 || roles == null)
            {
                return;
            }
            foreach (var role in roles)
            {
                var roledb = await _context.Roles.FirstOrDefaultAsync(r => r.Name == role);
                if (roledb == null)
                {
                    return;
                }
                var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roledb.Id);
                if (userRole == null)
                {
                    return;
                }
                _context.UserRoles.Remove(userRole);
            }

        }
    }
}
