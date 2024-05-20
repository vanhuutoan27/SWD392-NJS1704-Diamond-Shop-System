using Data_Access.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Services
{
    public class RefreshtokenService
    {
        private readonly RefreshtokenRepository _refreshtokenRepository;
        public  RefreshtokenService(RefreshtokenRepository refreshtokenRepository)
        {
            _refreshtokenRepository = refreshtokenRepository;
        }
       
           
    }
}
