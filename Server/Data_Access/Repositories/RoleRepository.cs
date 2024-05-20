using Data_Access.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repositories
{
    public class RoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<bool> RoleExistsAsync(int roleId)
        {
            return await _context.Roles.AnyAsync(r => r.RoleId == roleId);
        }
    }
}
