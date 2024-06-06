using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class JewelryRepository : RepositoryBase<Jewelry, Guid>, IJewelryRepository
    {
        public JewelryRepository(DiamondContext context) : base(context)
        {

        }


        public async Task<string> GenerateSkuAsync()
        {
            var lastProduct = await _context.Jewelrys.OrderByDescending(p => p.SkuID).FirstOrDefaultAsync();
            string newSku;
            if (lastProduct == null || string.IsNullOrEmpty(lastProduct.SkuID))
            {
                newSku = "J001";
            }
            else
            {
                var lastNumber = int.Parse(lastProduct.SkuID.Substring(1));
                newSku = "J" + (lastNumber + 1).ToString("D3");
            }
            return newSku;
        }

        public async Task<IEnumerable<Jewelry>> GetAllJewelryAsync()
        {
            return await _context.Jewelrys
                .Include(j => j.Product).ThenInclude(p => p.Images)
                .Include(j => j.Product).ThenInclude(p => p.Category)
                .ToListAsync();
        }

        public async Task<Jewelry> GetJewelryAsync(Guid id)
        {
            return await _context.Jewelrys.Where(j => j.JewelryId == id).Include(j => j.Product)
                .ThenInclude(p => p.Category).FirstOrDefaultAsync();
        }

        public void UpdateJewelry(Guid id, Jewelry jewelry)
        {
            _context.Update(jewelry);
        }
    }
}
