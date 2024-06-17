using DiamonShop.Core.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Core.Domain.Content
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        [Required]
        public double Total { get; set; }
        public string? Note { get; set; }
        public DateTime? ReceiptDay;
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
        public ICollection<OrderItem> Items
        { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
