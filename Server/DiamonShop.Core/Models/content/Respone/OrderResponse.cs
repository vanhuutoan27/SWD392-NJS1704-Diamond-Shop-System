using DiamonShop.Core.Shared.Enum;

namespace DiamonShop.Core.Models.content.Respone
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }
        public double Total { get; set; }
        public string? Note { get; set; }
        public DateTime? ReceiptDay { get; set; }
        public Guid CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? Status { get; set; }

        //navigate
        public List<OrderDetailsResponse> Items { get; set; }
    }
}
