using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Settings
{
    public class JwtSettings
    {
        public string Key { get; set; } = null;
        public TimeSpan ExpiryTimeFrame { get; set; }
    }
}
