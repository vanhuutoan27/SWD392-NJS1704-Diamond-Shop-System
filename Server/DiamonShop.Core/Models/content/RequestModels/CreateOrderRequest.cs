using DiamonShop.Core.Shared.Enum;

namespace DiamonShop.Core.Models.content.RequestModels
{
    public class CreateOrderRequest
    {
        public List<OrderDetailRequest> Products { get; set; }
        public double Total { get; set; }
        public string? Note { get; set; }

        public DateTime? ReceiptDay { get; set; }
        public Guid CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
