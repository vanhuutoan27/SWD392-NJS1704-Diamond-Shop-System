using DiamonShop.Core.Shared.Enum;

namespace DiamonShop.Core.Models.content.RequestModels
{
    public class ChangeOrderStatusRequest
    {
        public Guid OrderId { get; set; }
        public OrderStatus orderStatus { get; set; }
    }
}
