using DiamonShop.Core.Shared.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }


        public DateTime? CreateDate { get; set; }
        public DateTime? AmountDate { get; set; }
        public double? InvoiceAmount { get; set; }
        public InvoiceStatus StatusInvoice { get; set; }
        public double? AmountDue { get; set; }

        //navigate
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
    }
}
