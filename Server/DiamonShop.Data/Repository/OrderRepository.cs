using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(DiamondContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Order>> GetAllOrderAsync()
        {
            return await _context.Orders.AsNoTracking().AsQueryable()
                .Include(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images)

                .ToListAsync();
        }
    }
}
