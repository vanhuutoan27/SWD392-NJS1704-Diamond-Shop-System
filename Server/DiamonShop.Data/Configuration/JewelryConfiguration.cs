using DiamonShop.Core.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiamonShop.Data.Configuration
{
    public class JewelryConfiguration : IEntityTypeConfiguration<Jewelry>
    {
        public void Configure(EntityTypeBuilder<Jewelry> builder)
        {
            builder.HasData(
                    new Jewelry
                    {
                        JewelryId = new Guid("9F3519C6-1DF4-4125-BBEF-8E7825425DCD"),
                        SkuID = "J001",
                        Name = "18K DIAMOND PENDANT",
                        MainStoneSize = "Round 5ly",
                        ProductType = "Jewelry",
                        sideStoneType = "Diamond",
                        sideStoneQuantity = 23,
                        StoneWeight = 1.1,
                        GoldType = "White gold",
                        GoldKarat = "18K",
                        GoldWeight = 0.53,
                        Price = 28300000,

                    },
                     new Jewelry
                     {
                         JewelryId = new Guid("C2BC12A6-E878-4DA0-9B70-656CC94F3316"),
                         SkuID = "J002",
                         Name = "18K DIAMOND PENDANT",
                         MainStoneSize = "Round 5.1ly",
                         ProductType = "Jewelry",

                         sideStoneType = "Diamond",
                         sideStoneQuantity = 27,
                         StoneWeight = 1.12,
                         GoldType = "White gold",
                         GoldKarat = "18K",
                         GoldWeight = 0.61,
                         Price = 31200000,

                     },
                       new Jewelry
                       {
                           JewelryId = new Guid("AF32B397-0DC4-46FA-AA7F-EB31BFFD2821"),
                           SkuID = "J003",
                           Name = "18K DIAMOND PENDANT",
                           MainStoneSize = "Round 6.3ly",
                           ProductType = "Jewelry",
                           sideStoneType = "Diamond",
                           sideStoneQuantity = 20,
                           StoneWeight = 1.2,
                           GoldType = "White gold",
                           GoldKarat = "18K",
                           GoldWeight = 0.58,
                           Price = 33450000,

                       },
                     new Jewelry
                     {
                         JewelryId = new Guid("4FD47F59-6149-48C2-B1AD-E454438D08C3"),
                         SkuID = "J004",
                         Name = "18K DIAMOND RING",
                         MainStoneSize = "Round 4.5ly",
                         ProductType = "Jewelry",
                         sideStoneType = "Diamond",
                         sideStoneQuantity = 38,
                         StoneWeight = 1.07,
                         GoldType = "White gold",
                         GoldKarat = "18K",
                         GoldWeight = 1.05,
                         Price = 38589000,

                     },
                     new Jewelry
                     {
                         JewelryId = new Guid("6ABB1F7D-1BAB-4405-8F72-A817C2FE9B05"),
                         SkuID = "J005",
                         Name = "18K DIAMOND RING",
                         MainStoneSize = "Round 4.0ly",
                         ProductType = "Jewelry",
                         sideStoneType = "Diamond",
                         sideStoneQuantity = 63,
                         StoneWeight = 2,
                         GoldType = "White gold",
                         GoldKarat = "18K",
                         GoldWeight = 1.09,
                         Price = 37430000,

                     },
                       new Jewelry
                       {
                           JewelryId = new Guid("E8447232-F062-423C-AC95-EAAD6FC8D8B1"),
                           SkuID = "J006",
                           Name = "18K DIAMOND RING",
                           MainStoneSize = "Round 5.2ly",
                           ProductType = "Jewelry",
                           sideStoneType = "Diamond",
                           sideStoneQuantity = 2,
                           StoneWeight = 1.1,
                           GoldType = "White gold",
                           GoldKarat = "18K",
                           GoldWeight = 1.17,
                           Price = 41246000,

                       },
                        new Jewelry
                        {
                            JewelryId = new Guid("361C08C6-49C7-4DA0-96C3-9062ACD03BFF"),
                            SkuID = "J007",
                            Name = "18K DIAMOND BRACELET",
                            ProductType = "Jewelry",
                            MainStoneSize = "Round 5.4ly",
                            sideStoneType = "Diamond",
                            sideStoneQuantity = 43,
                            StoneWeight = 2.2,
                            GoldType = "White gold",
                            GoldKarat = "18K",
                            GoldWeight = 6.6,
                            Price = 135371000,

                        },
                         new Jewelry
                         {
                             JewelryId = new Guid("BCE4345D-D1CB-4D01-B904-BE38FCB9CACA"),
                             SkuID = "J008",
                             Name = "18K DIAMOND BRACELET",
                             MainStoneSize = "Round 6.3ly",
                             ProductType = "Jewelry",
                             sideStoneType = "Diamond",
                             sideStoneQuantity = 92,
                             StoneWeight = 2.8,
                             GoldType = "White gold",
                             GoldKarat = "18K",
                             GoldWeight = 7.1,
                             Price = 148239000,

                         },
                          new Jewelry
                          {
                              JewelryId = new Guid("1876FA93-1502-4D84-93AE-5BA6301D63CB"),
                              SkuID = "J009",
                              Name = "18K DIAMOND BRACELET",
                              MainStoneSize = "Round 6.1ly",
                              ProductType = "Jewelry",
                              sideStoneType = "Diamond",
                              sideStoneQuantity = 57,
                              StoneWeight = 2.7,
                              GoldType = "White gold",
                              GoldKarat = "18K",
                              GoldWeight = 5.9,
                              Price = 139800000,

                          },

                            new Jewelry
                            {
                                JewelryId = new Guid("734AAB01-8668-4E5C-8AFB-473B05FC52C0"),
                                SkuID = "J010",
                                Name = "18K DIAMOND ERRINGS",
                                MainStoneSize = "Round 5ly",
                                ProductType = "Jewelry",
                                sideStoneType = "Diamond",
                                sideStoneQuantity = 15,
                                StoneWeight = 0.04,
                                GoldType = "White gold",
                                GoldKarat = "18K",
                                GoldWeight = 1.04,
                                Price = 31317000,

                            },
                            new Jewelry
                            {
                                JewelryId = new Guid("1CC86444-85B6-4CD7-B002-AFE58CA36A39"),
                                SkuID = "J011",
                                Name = "18K DIAMOND ERRINGS",
                                MainStoneSize = "Round 5.3ly",
                                ProductType = "Jewelry",
                                sideStoneType = "Diamond",
                                sideStoneQuantity = 60,
                                StoneWeight = 0.1,
                                GoldType = "White gold",
                                GoldKarat = "18K",
                                GoldWeight = 1.08,
                                Price = 47239000,

                            },
                              new Jewelry
                              {
                                  JewelryId = new Guid("5D411445-BA01-46D2-92A4-C690F1E19DB4"),
                                  SkuID = "J012",
                                  Name = "18K DIAMOND ERRINGS",
                                  MainStoneSize = "Round 4.9ly",
                                  ProductType = "Jewelry",
                                  sideStoneType = "Diamond",
                                  sideStoneQuantity = 23,
                                  StoneWeight = 0.03,
                                  GoldType = "White gold",
                                  GoldKarat = "18K",
                                  GoldWeight = 1.07,
                                  Price = 44650000,

                              }


                );
        }
    }
}
