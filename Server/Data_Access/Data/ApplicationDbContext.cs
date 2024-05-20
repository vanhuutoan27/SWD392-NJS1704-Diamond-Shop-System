using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.UserId);
                entity.Property(x => x.Name).IsRequired();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(x => x.RoleId);
                entity.Property(x => x.Name).IsRequired();

                // Thiết lập mối quan hệ một nhiều: Một Role có nhiều User
                entity.HasMany(r => r.Users) // Một Role có nhiều User
                      .WithOne(u => u.RoleNavigation)   // Mỗi User thuộc về một Role
                      .HasForeignKey(u => u.Role) // Khóa ngoại trong bảng User
                      .IsRequired(); // RoleId là bắt buộc
            });

            modelBuilder.Entity<UserPermission>()
                        .HasKey(up => up.PermissionId);

            modelBuilder.Entity<Role>()
                .HasKey(r => r.RoleId);

            modelBuilder.Entity<Role>()
                .HasOne(r => r.UserPermissions)
                .WithOne(up => up.Role)
                .HasForeignKey<UserPermission>(up => up.RoleId);

            // Configure primary key for User
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            // Configure primary key for RefreshToken
            modelBuilder.Entity<RefreshToken>()
                .HasKey(rt => rt.RefreshTokenId);

            // Configure one-to-many relationship between User and RefreshToken
            modelBuilder.Entity<User>()
                .HasMany(u => u.RefreshTokens)
                .WithOne(rt => rt.User)
                .HasForeignKey(rt => rt.UserId);
        }



    }
}

