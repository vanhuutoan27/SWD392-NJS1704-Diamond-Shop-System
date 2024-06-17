using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class OrderItemsRepository : RepositoryBase<OrderItem, Guid>, IOrderItemsRepository
    {
        public OrderItemsRepository(DiamondContext context) : base(context)
        {

        }
    }
}
