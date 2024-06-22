using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IOrderRepository : IRepository<Order, Guid>
    {
        Task<IEnumerable<Order>> GetAllOrderAsync();
        Task<Order> GetOrderByIdAsync(Guid orderId);
        void DeleteOrder(Guid orderId);
        Task<IEnumerable<Order>> GetOrderByCustomerIdAsync(Guid id);
    }
}
