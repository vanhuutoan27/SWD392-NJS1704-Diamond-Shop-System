using AutoMapper;
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
    public class RegistRepository
    {
        private readonly ApplicationDbContext _context;
       
        public RegistRepository(ApplicationDbContext context)
        {
            _context = context;
           
        }
        public async Task<User> RegistAsync(User user)
        {
            await _context.Users.AddAsync(user);
            return user;
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
       
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

