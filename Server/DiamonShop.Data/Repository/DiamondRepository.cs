using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class DiamondRepository : RepositoryBase<Diamond, Guid>, IDiamondRepository
    {

        public DiamondRepository(DiamondContext context) : base(context)
        {

        }

        public void Delete(Diamond diamond) => Remove(diamond);

        public Diamond Findid(Guid id) => Find(c => c.DiamondId == id).SingleOrDefault();

        public async Task<string> GenerateSkuAsync()
        {
            var lastProduct = await _context.Diamonds.OrderByDescending(p => p.SkuID).FirstOrDefaultAsync();
            string newSku;
            if (lastProduct == null || string.IsNullOrEmpty(lastProduct.SkuID))
            {
                newSku = "D001";
            }
            else
            {
                var lastNumber = int.Parse(lastProduct.SkuID.Substring(1));
                newSku = "D" + (lastNumber + 1).ToString("D3");
            }
            return newSku;
        }

        public async Task<IEnumerable<Diamond>> GetAllDiamondAsync()
        {
            return await _context.Diamonds.Include(d => d.Product).ThenInclude(p => p.Images).ToListAsync();
        }

        public async Task<Diamond> GetDiamondById(Guid id)
        {
            return await _context.Diamonds.Include(d => d.Product).ThenInclude(p => p.Images)
                .Where(d => d.DiamondId == id).FirstOrDefaultAsync();
        }
    }
}
