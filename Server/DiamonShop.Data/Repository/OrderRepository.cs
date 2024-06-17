using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(DiamondContext context) : base(context)
        {

        }
    }
}
