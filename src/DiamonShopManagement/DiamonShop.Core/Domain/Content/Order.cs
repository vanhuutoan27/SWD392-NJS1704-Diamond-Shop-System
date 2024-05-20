using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Core.Domain.Content
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        [Required]
        public double Total { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //navigate
        public ICollection<OrderItem> Items { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
