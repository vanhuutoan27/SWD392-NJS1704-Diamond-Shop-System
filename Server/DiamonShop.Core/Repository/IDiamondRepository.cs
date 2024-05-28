using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IDiamondRepository : IRepository<Diamond, Guid>
    {
        Task<IEnumerable<Diamond>> GetAllAsync();
        Task<Diamond> GetByIdAsync(Guid id);
        void Update(Diamond diamond);
        void Add(Diamond diamond);
        void Delete(Diamond diamond);
        Diamond Findid(Guid id);
    }
}
