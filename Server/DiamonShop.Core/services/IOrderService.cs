using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;

namespace DiamonShop.Core.services
{
    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request);
        Task<IEnumerable<OrderResponse>> GetAllOrders();
        Task<OrderResponse> GetOrderByIdAsync(Guid id);
        Task DeleteOrder(Guid id);
        Task<IEnumerable<OrderResponse>> GetOrderByCustomerIdAsync(Guid id);
    }
}
