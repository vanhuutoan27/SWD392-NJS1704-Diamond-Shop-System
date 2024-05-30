using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonShop.Data.Repository
{
    public class JewelryRepository : RepositoryBase<Jewelry, Guid>, IJewelryRepository
    {
        public JewelryRepository(DiamondContext context) : base(context)
        {

        }

        public void UpdateJewelry(Guid id, Jewelry jewelry)
        {
            _context.Update(jewelry);
            _context.SaveChanges();
        }
    }
}
