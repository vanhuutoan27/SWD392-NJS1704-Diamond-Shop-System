using DiamonShop.Core.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Data.Configuration
{
    public class DiamondConfiguration : IEntityTypeConfiguration<Diamond>
    {
        public void Configure(EntityTypeBuilder<Diamond> builder)
        {
            builder.HasData(
                    new Diamond
                    {
                        DiamondId = new Guid("E655174B-F444-4AB8-BAA8-71AC382D73DF"),
                        Shape = "Pear",
                        Weight = 1.5,
                        ColorLevel = "F",
                        Clarity = "VVS2",
                        Certification = "GIA",
                        Size = 4.4,
                        Fluorescence = "MEDIUM",
                        QualityOfCut = "Excellent",
                        Price = 535790600,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                    },
                     new Diamond
                     {
                         DiamondId = new Guid("4F5CBE8A-A04A-484F-978D-4B26D2979063"),
                         Shape = "Round",
                         Weight = 2.5,
                         ColorLevel = "D",
                         Clarity = "VS3",
                         Certification = "GIA",
                         Size = 4.4,
                         Fluorescence = "MEDIUM",
                         QualityOfCut = "Excellent",
                         Price = 21924560,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                     new Diamond
                     {
                         DiamondId = new Guid("005DA949-DD83-438B-9EE9-AEA012D87068"),
                         Shape = "Round",
                         Weight = 2.7,
                         ColorLevel = "D",
                         Clarity = "IF",
                         Certification = "GIA",
                         Size = 4.3,
                         Fluorescence = "MEDIUM",
                         QualityOfCut = "Excellent",
                         Price = 32422800,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     }


                );
        }

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
    }
}
