using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class ImageRepository : RepositoryBase<Image, Guid>, IImageRepository
    {
        public ImageRepository(DiamondContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Image>> GetImagesByProductIdAsync(Guid productId)
        {
            return await _context.Images.Where(i => i.ProductId == productId).ToListAsync();
        }
    }
}
