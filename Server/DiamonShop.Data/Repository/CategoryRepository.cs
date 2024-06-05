using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class CategoryRepository : RepositoryBase<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(DiamondContext context) : base(context)
        {

        }

        public async Task<Category> GetByNameAsync(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return _context.Categorys.Where(c => c.Name.ToLower().Equals(name.ToLower())).FirstOrDefault();

        }
    }
}
