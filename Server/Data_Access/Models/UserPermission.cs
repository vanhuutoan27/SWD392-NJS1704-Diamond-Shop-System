using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public class UserPermission
    {
        public int PermissionId { get; set; }
        public string Diamond { get; set; }

        public string Jewelry { get; set; }
        public string UserManagement { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
