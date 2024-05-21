using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IDiamondRepository : IRepository<Diamond, Guid>
    {
        //Task<IEnumerable<Diamond>> GetAllAsync();
    }
}
