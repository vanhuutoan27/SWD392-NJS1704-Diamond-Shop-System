namespace DiamonShop.Core.Models.content.RequestModels
{
    public class OrderDetailRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
