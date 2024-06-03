using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonShop.Core.Repository
{
    public interface IJewelryRepository : IRepository<Jewelry, Guid>
    {
        void UpdateJewelry(Guid id, Jewelry jewelry);
    }
}
