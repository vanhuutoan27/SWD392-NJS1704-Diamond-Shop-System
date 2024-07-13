using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IImageRepository : IRepository<Image, Guid>
    {
        Task<IEnumerable<Image>> GetImagesByProductIdAsync(Guid productId);
    }
}
