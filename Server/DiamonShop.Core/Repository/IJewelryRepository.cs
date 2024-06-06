using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IJewelryRepository : IRepository<Jewelry, Guid>
    {
        void UpdateJewelry(Guid id, Jewelry jewelry);
        Task<string> GenerateSkuAsync();
        Task<IEnumerable<Jewelry>> GetAllJewelryAsync();
        Task<Jewelry> GetJewelryAsync(Guid id);


    }
}
