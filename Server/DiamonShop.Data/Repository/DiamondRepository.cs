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

        public void Delete(Diamond diamond) => Remove(diamond);

        public Diamond Findid(Guid id) => Find(c => c.DiamondId == id).SingleOrDefault();
        
    }
}
