using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public partial class RefreshToken
    {
        public Guid RefreshTokenId { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; } = null!;
        public DateTime IssuedAt { get; set; }
        public DateTime ExpriedAt { get; set; }
        public string JwtId { get; set; } = null!;
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
