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
        public void Update(Diamond diamond);
        public void Add(Diamond diamond);
    }
}
