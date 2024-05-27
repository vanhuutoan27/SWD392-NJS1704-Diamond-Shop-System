using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Diamond
    {
        [Key, ForeignKey(nameof(Product))]
        public Guid DiamondId { get; set; }
        [Required]
        public string Shape { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public string ColorLevel { get; set; }
        [Required]
        public string Clarity { get; set; }
        [Required]
        public string Certification { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public string Fluorescence { get; set; }
        [Required]
        public string QualityOfCut { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //naviagte 
        public Product Product { get; set; }

    }
}
