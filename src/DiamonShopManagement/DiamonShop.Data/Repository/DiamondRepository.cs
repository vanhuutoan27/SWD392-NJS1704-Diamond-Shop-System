using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class DiamondRepository : RepositoryBase<Diamond, Guid>, IDiamondRepository
    {
        public DiamondRepository(DiamondContext context) : base(context)
        {

        }
        //public async Task<IEnumerable<Diamond>> GetAllAsync()
        //{
        //    return await GetAllAsync();
        //}
    }
}
