using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Jewelry
    {
        [Key, ForeignKey(nameof(Product))]
        public Guid JewelryId { get; set; }

        public string SkuID { get; set; }

        [Required]
        public string Name { get; set; }
        public string ProductType { get; set; }

        [Required]

        public string MainStoneSize { get; set; }
        [Required]

        public string sideStoneType { get; set; }
        [Required]

        public int sideStoneQuantity { get; set; }
        [Required]

        public double StoneWeight { get; set; }
        [Required]

        public string GoldType { get; set; }
        [Required]

        public string GoldKarat { get; set; }
        [Required]
        public double GoldWeight { get; set; }
        [Required]
        public double Price { get; set; }

        //navigate 
        public Product Product { get; set; }
    }
}
