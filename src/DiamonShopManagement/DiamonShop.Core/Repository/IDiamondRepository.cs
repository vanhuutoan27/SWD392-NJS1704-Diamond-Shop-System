using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.RequestModels;
using DiamonShop.Core.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.ViewModels;

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
