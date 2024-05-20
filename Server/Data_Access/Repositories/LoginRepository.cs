using AutoMapper;
using Data_Access.AuViewModel.LoginRespone;
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
    public class LoginRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public LoginRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(e => e.Email == email);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
