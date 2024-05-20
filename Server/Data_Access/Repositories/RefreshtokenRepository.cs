using Data_Access.Data;
using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Access.Repositories
{
    public class RefreshtokenRepository
    {
        private readonly ApplicationDbContext _context;

        public RefreshtokenRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<RefreshToken> FindToken(string refreshToken)
        {
            var storedToken = await _context.RefreshTokens.Where(x => x.Token == refreshToken).FirstOrDefaultAsync();
            return storedToken;
        }
        public async Task CreateToken(RefreshToken refreshtoken)
        {
            await _context.RefreshTokens.AddAsync(refreshtoken);
            _context.SaveChanges();

        }
        public bool UpadateToken(RefreshToken refreshToken)
        {
            _context.RefreshTokens.Update(refreshToken);

            _context.SaveChanges();
            return true;
        }

    }
}
