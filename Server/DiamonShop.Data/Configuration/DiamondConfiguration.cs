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
                        SkuID = "D001",
                        Shape = "Round",
                        Weight = 0.31,
                        ColorLevel = "E",
                        Clarity = "IF",
                        Certification = "GIA",
                        Size = 4.4,
                        Fluorescence = "None",
                        QualityOfCut = "Good",
                        Price = 13500000,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                    },
                     new Diamond
                     {
                         DiamondId = new Guid("4F5CBE8A-A04A-484F-978D-4B26D2979063"),
                         SkuID = "D002",
                         Shape = "Round",
                         Weight = 2.8,
                         ColorLevel = "D",
                         Clarity = "VS2",
                         Certification = "AGS",
                         Size = 6.2,
                         Fluorescence = "Faint",
                         QualityOfCut = "Poor",
                         Price = 83000000,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                     new Diamond
                     {
                         DiamondId = new Guid("005DA949-DD83-438B-9EE9-AEA012D87068"),
                         SkuID = "D003",
                         Shape = "Round",
                         Weight = 1.4,
                         ColorLevel = "F",
                         Clarity = "I2",
                         Certification = "EGL",
                         Size = 9.1,
                         Fluorescence = "Medium",
                         QualityOfCut = "Fair",
                         Price = 470000000,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                     new Diamond
                     {
                         DiamondId = new Guid("F376D66D-CF4A-4103-836F-43811290F18C"),
                         SkuID = "D004",
                         Shape = "Emerald",
                         Weight = 2.1,
                         ColorLevel = "H",
                         Clarity = "VVS1",
                         Certification = "HRD",
                         Size = 8.5,
                         Fluorescence = "Strong",
                         QualityOfCut = "Very Good",
                         Price = 364000000,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                      new Diamond
                      {
                          DiamondId = new Guid("76B4BB4A-3435-4876-AF7F-FFB9B0301E00"),
                          SkuID = "D005",
                          Shape = "Emerald",
                          Weight = 3.1,
                          ColorLevel = "J",
                          Clarity = "SL1",
                          Certification = "IGI",
                          Size = 5.3,
                          Fluorescence = "Faint",
                          QualityOfCut = "Excellent",
                          Price = 29400000,
                          DateCreated = DateTime.Now,
                          DateModified = DateTime.Now,
                      },
                        new Diamond
                        {
                            DiamondId = new Guid("53EDC0AD-98AD-41E9-9A1B-ADA8950090CB"),
                            SkuID = "D006",
                            Shape = "Emerald",
                            Weight = 0.8,
                            ColorLevel = "I",
                            Clarity = "SL2",
                            Certification = "GIA",
                            Size = 4.6,
                            Fluorescence = "Strong",
                            QualityOfCut = "Very Good",
                            Price = 15900000,
                            DateCreated = DateTime.Now,
                            DateModified = DateTime.Now,
                        },
                         new Diamond
                         {
                             DiamondId = new Guid("D2C73200-1AE0-4066-9475-0BDA2E220D57"),
                             SkuID = "D007",
                             Shape = "Heart",
                             Weight = 0.4,
                             ColorLevel = "K",
                             Clarity = "I2",
                             Certification = "AGS",
                             Size = 8.7,
                             Fluorescence = "Medium",
                             QualityOfCut = "Good",
                             Price = 615000000,
                             DateCreated = DateTime.Now,
                             DateModified = DateTime.Now,
                         },
                            new Diamond
                            {
                                DiamondId = new Guid("C9807CFC-98B8-4B48-9CA8-FD4C44B6933C"),
                                SkuID = "D008",
                                Shape = "Heart",
                                Weight = 0.32,
                                ColorLevel = "L",
                                Clarity = "IF",
                                Certification = "EGL",
                                Size = 6.8,
                                Fluorescence = "None",
                                QualityOfCut = "Fair",
                                Price = 268000000,
                                DateCreated = DateTime.Now,
                                DateModified = DateTime.Now,
                            },
                            new Diamond
                            {
                                DiamondId = new Guid("AA298DFB-004C-4008-B0A1-C143AF1D15D5"),
                                SkuID = "D009",
                                Shape = "Heart",
                                Weight = 1.19,
                                ColorLevel = "G",
                                Clarity = "IF",
                                Certification = "IGI",
                                Size = 5.8,
                                Fluorescence = "None",
                                QualityOfCut = "Poor",
                                Price = 61000000,
                                DateCreated = DateTime.Now,
                                DateModified = DateTime.Now,
                            },
                                  new Diamond
                                  {
                                      DiamondId = new Guid("87340BC6-A7CB-4A10-BE79-77AE910348EF"),
                                      SkuID = "D010",
                                      Shape = "Cushion",
                                      Weight = 1.3,
                                      ColorLevel = "M",
                                      Clarity = "VVS2",
                                      Certification = "GIA",
                                      Size = 5.1,
                                      Fluorescence = "Medium",
                                      QualityOfCut = "Excellent",
                                      Price = 26000000,
                                      DateCreated = DateTime.Now,
                                      DateModified = DateTime.Now,
                                  }
                    ,
                     new Diamond
                     {
                         DiamondId = new Guid("751EA591-6934-4C48-A64B-BC64EF26C724"),
                         SkuID = "D011",
                         Shape = "Cushion",
                         Weight = 0.6,
                         ColorLevel = "E",
                         Clarity = "VS1",
                         Certification = "HRD",
                         Size = 9.2,
                         Fluorescence = "Strong",
                         QualityOfCut = "Excellent",
                         Price = 668350000,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                       new Diamond
                       {
                           DiamondId = new Guid("B9948C96-E456-471D-B523-159B7CF3242C"),
                           SkuID = "D012",
                           Shape = "Cushion",
                           Weight = 0.7,
                           ColorLevel = "K",
                           Clarity = "I1",
                           Certification = "HRD",
                           Size = 7.4,
                           Fluorescence = "Strong",
                           QualityOfCut = "Very Good",
                           Price = 392740000,
                           DateCreated = DateTime.Now,
                           DateModified = DateTime.Now,
                       },
                        new Diamond
                        {
                            DiamondId = new Guid("27C26FA1-C62B-408B-99A3-BD36531B2A16"),
                            SkuID = "D013",
                            Shape = "Pear",
                            Weight = 2.5,
                            ColorLevel = "J",
                            Clarity = "VVS2",
                            Certification = "AGS",
                            Size = 4.9,
                            Fluorescence = "Faint",
                            QualityOfCut = "Fair",
                            Price = 21000000,
                            DateCreated = DateTime.Now,
                            DateModified = DateTime.Now,
                        },
                         new Diamond
                         {
                             DiamondId = new Guid("84B37CF4-2AE5-4A07-A5DC-E2703F93C129"),
                             SkuID = "D014",
                             Shape = "Pear",
                             Weight = 3.2,
                             ColorLevel = "K",
                             Clarity = "VVS1",
                             Certification = "EGL",
                             Size = 6.3,
                             Fluorescence = "None",
                             QualityOfCut = "Poor",
                             Price = 105740000,
                             DateCreated = DateTime.Now,
                             DateModified = DateTime.Now,
                         },
                           new Diamond
                           {
                               DiamondId = new Guid("48B3B08E-D266-4EEC-B82C-B71C7303C446"),
                               SkuID = "D015",
                               Shape = "Pear",
                               Weight = 0.9,
                               ColorLevel = "L",
                               Clarity = "I1",
                               Certification = "IGI",
                               Size = 7.2,
                               Fluorescence = "Strong",
                               QualityOfCut = "Good",
                               Price = 292740000,
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
