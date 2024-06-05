using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
        Task<Category> GetByNameAsync(string name);
    }
}
