namespace DiamonShop.Core.Models.content.Respone
{
    public class OrderDetailsResponse
    {
        public Guid OrderItemId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public List<string>? Images { get; set; }
    }
}
