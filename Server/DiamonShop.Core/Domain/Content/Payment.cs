using DiamonShop.Core.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid OrderId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public EnumStatus.Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //navigate 
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }


    }
}
