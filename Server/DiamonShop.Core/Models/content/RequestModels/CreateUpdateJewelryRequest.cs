using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Core.Models.content.RequestModels
{
    public class CreateUpdateJewelryRequest
    {
        public string Name { get; set; }
        public string ProductType { get; set; }

        [Required(ErrorMessage = "MainStoneSize name is a required field.")]
        [MaxLength(100)]
        public string MainStoneSize { get; set; }
        [Required(ErrorMessage = "SideStoneType name is a required field.")]
        [MaxLength(100)]
        public string SideStoneType { get; set; }
        [Required(ErrorMessage = "SideStoneQuantity name is a required field.")]
        [Range(0, int.MaxValue, ErrorMessage = "SideStoneQuantity have to greater than 0.")]
        public int SideStoneQuantity { get; set; }
        [Required(ErrorMessage = "StoneWeight name is a required field.")]
        [Range(0, double.MaxValue, ErrorMessage = "StoneWeight have to greater than 0.")]
        public double StoneWeight { get; set; }
        [Required(ErrorMessage = "GoldType name is a required field.")]
        [MaxLength(100)]
        public string GoldType { get; set; }
        [Required(ErrorMessage = "GoldKarat name is a required field.")]
        [MaxLength(100)]
        public string GoldKarat { get; set; }
        [Required(ErrorMessage = "GoldWeight name is a required field.")]
        [Range(0, double.MaxValue, ErrorMessage = "GoldWeight have to greater than 0.")]
        public double GoldWeight { get; set; }
        [Required(ErrorMessage = "Price name is a required field.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price have to greater than 0.")]
        public double Price { get; set; }
        //public Product? Product { get; set; }

        public List<string> Images { get; set; }

    }
}
