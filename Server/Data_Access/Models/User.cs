using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? Status { get; set; }
        public int Role { get; set; }
        public Role RoleNavigation { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

    }
}
