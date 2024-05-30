using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Core.Domain.Identity
{
    public class AppUser : IdentityUser<Guid>
    {

        [Required]
        [MaxLength(100)]
        public required string FullName { get; set; }
        public bool IsActive { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        [MaxLength(500)]
        public string? Avatar { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipExpireDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public double Balance { get; set; }
        public double RoyaltyAmountPerPost { get; set; }

    }
}
