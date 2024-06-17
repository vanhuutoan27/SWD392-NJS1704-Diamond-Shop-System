using DiamonShop.Core.Shared.Enum;

namespace DiamonShop.Core.Models.content.Respone
{
    public class InvoiceResponse
    {
        public Guid InvoiceId { get; set; }
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }


        public DateTime? CreateDate { get; set; }
        public DateTime? AmountDate { get; set; }
        public double? InvoiceAmount { get; set; }
        public InvoiceStatus StatusInvoice { get; set; }
        public double? AmountDue { get; set; }

        public OrderResponse Order { get; set; }
        public UserResponse User { get; set; }

    }
}
