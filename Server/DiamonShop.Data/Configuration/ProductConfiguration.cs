using DiamonShop.Core.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiamonShop.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductId = new Guid("E655174B-F444-4AB8-BAA8-71AC382D73DF"),
                    Name = "Kim Cương Viên",
                    Description = "Kinh cương tự nhiên 100%",
                    Price = 535790600,
                    CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                    Status = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                  new Product
                  {
                      ProductId = new Guid("4F5CBE8A-A04A-484F-978D-4B26D2979063"),
                      Name = "Kim Cương Viên",
                      Description = "Kinh cương tự nhiên 99%",
                      Price = 21924560,
                      CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                      Status = 0,
                      DateCreated = DateTime.Now,
                      DateModified = DateTime.Now,
                  },

                  new Product
                  {
                      ProductId = new Guid("005DA949-DD83-438B-9EE9-AEA012D87068"),
                      Name = "Kim Cương Viên",
                      Description = "Kinh cương tự nhiên 98%",
                      Price = 32422800,
                      CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                      Status = 0,
                      DateCreated = DateTime.Now,
                      DateModified = DateTime.Now,
                  },
                   new Product
                   {
                       ProductId = new Guid("F376D66D-CF4A-4103-836F-43811290F18C"),
                       Name = "Kim Cương Viên",
                       Description = "Kinh cương tự nhiên 98%",
                       Price = 32422800,
                       CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                       Status = 0,
                       DateCreated = DateTime.Now,
                       DateModified = DateTime.Now,
                   },
                     new Product
                     {
                         ProductId = new Guid("76B4BB4A-3435-4876-AF7F-FFB9B0301E00"),
                         Name = "Kim Cương Viên",
                         Description = "Kinh cương tự nhiên 98%",
                         Price = 32422800,
                         CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                         Status = 0,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                     new Product
                     {
                         ProductId = new Guid("53EDC0AD-98AD-41E9-9A1B-ADA8950090CB"),
                         Name = "Kim Cương Viên",
                         Description = "Kinh cương tự nhiên 98%",
                         Price = 32422800,
                         CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                         Status = 0,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                     new Product
                     {
                         ProductId = new Guid("D2C73200-1AE0-4066-9475-0BDA2E220D57"),
                         Name = "Kim Cương Viên",
                         Description = "Kinh cương tự nhiên 98%",
                         Price = 32422800,
                         CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                         Status = 0,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now,
                     },
                      new Product
                      {
                          ProductId = new Guid("C9807CFC-98B8-4B48-9CA8-FD4C44B6933C"),
                          Name = "Kim Cương Viên",
                          Description = "Kinh cương tự nhiên 98%",
                          Price = 32422800,
                          CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                          Status = 0,
                          DateCreated = DateTime.Now,
                          DateModified = DateTime.Now,
                      },
                       new Product
                       {
                           ProductId = new Guid("AA298DFB-004C-4008-B0A1-C143AF1D15D5"),
                           Name = "Kim Cương Viên",
                           Description = "Kinh cương tự nhiên 98%",
                           Price = 32422800,
                           CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                           Status = 0,
                           DateCreated = DateTime.Now,
                           DateModified = DateTime.Now,
                       },
                             new Product
                             {
                                 ProductId = new Guid("87340BC6-A7CB-4A10-BE79-77AE910348EF"),
                                 Name = "Kim Cương Viên",
                                 Description = "Kinh cương tự nhiên 98%",
                                 Price = 32422800,
                                 CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                 Status = 0,
                                 DateCreated = DateTime.Now,
                                 DateModified = DateTime.Now,
                             },
                             new Product
                             {
                                 ProductId = new Guid("751EA591-6934-4C48-A64B-BC64EF26C724"),
                                 Name = "Kim Cương Viên",
                                 Description = "Kinh cương tự nhiên 98%",
                                 Price = 32422800,
                                 CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                 Status = 0,
                                 DateCreated = DateTime.Now,
                                 DateModified = DateTime.Now,
                             },
                                    new Product
                                    {
                                        ProductId = new Guid("B9948C96-E456-471D-B523-159B7CF3242C"),
                                        Name = "Kim Cương Viên",
                                        Description = "Kinh cương tự nhiên 98%",
                                        Price = 32422800,
                                        CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                        Status = 0,
                                        DateCreated = DateTime.Now,
                                        DateModified = DateTime.Now,
                                    },
                                    new Product
                                    {
                                        ProductId = new Guid("27C26FA1-C62B-408B-99A3-BD36531B2A16"),
                                        Name = "Kim Cương Viên",
                                        Description = "Kinh cương tự nhiên 98%",
                                        Price = 32422800,
                                        CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                        Status = 0,
                                        DateCreated = DateTime.Now,
                                        DateModified = DateTime.Now,
                                    },
                                      new Product
                                      {
                                          ProductId = new Guid("84B37CF4-2AE5-4A07-A5DC-E2703F93C129"),
                                          Name = "Kim Cương Viên",
                                          Description = "Kinh cương tự nhiên 98%",
                                          Price = 32422800,
                                          CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                          Status = 0,
                                          DateCreated = DateTime.Now,
                                          DateModified = DateTime.Now,
                                      },
                                       new Product
                                       {
                                           ProductId = new Guid("48B3B08E-D266-4EEC-B82C-B71C7303C446"),
                                           Name = "Kim Cương Viên",
                                           Description = "Kinh cương tự nhiên 98%",
                                           Price = 32422800,
                                           CategoryId = Guid.Parse("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                                           Status = 0,
                                           DateCreated = DateTime.Now,
                                           DateModified = DateTime.Now,
                                       },
                                       new Product
                                       {
                                           ProductId = new Guid("9F3519C6-1DF4-4125-BBEF-8E7825425DCD"),
                                           Name = "Jewelry",
                                           Description = "Kinh cương tự nhiên 98%",
                                           Price = 32422800,
                                           CategoryId = Guid.Parse("420FCF35-560E-4FC9-86DB-7AC3C5C7A38C"),
                                           Status = 0,
                                           DateCreated = DateTime.Now,
                                           DateModified = DateTime.Now,
                                       },
                                        new Product
                                        {
                                            ProductId = new Guid("C2BC12A6-E878-4DA0-9B70-656CC94F3316"),
                                            Name = "Jewelry",
                                            Description = "Kinh cương tự nhiên 98%",
                                            Price = 32422800,
                                            CategoryId = Guid.Parse("420FCF35-560E-4FC9-86DB-7AC3C5C7A38C"),
                                            Status = 0,
                                            DateCreated = DateTime.Now,
                                            DateModified = DateTime.Now,
                                        },
                                        new Product
                                        {
                                            ProductId = new Guid("AF32B397-0DC4-46FA-AA7F-EB31BFFD2821"),
                                            Name = "Jewelry",
                                            Description = "Kinh cương tự nhiên 98%",
                                            Price = 32422800,
                                            CategoryId = Guid.Parse("420FCF35-560E-4FC9-86DB-7AC3C5C7A38C"),
                                            Status = 0,
                                            DateCreated = DateTime.Now,
                                            DateModified = DateTime.Now,
                                        },
                                         new Product
                                         {
                                             ProductId = new Guid("4FD47F59-6149-48C2-B1AD-E454438D08C3"),
                                             Name = "Jewelry",
                                             Description = "Kinh cương tự nhiên 98%",
                                             Price = 32422800,
                                             CategoryId = Guid.Parse("419CA5BE-F464-48AB-A7F4-B756673D28AF"),
                                             Status = 0,
                                             DateCreated = DateTime.Now,
                                             DateModified = DateTime.Now,
                                         },
                                           new Product
                                           {
                                               ProductId = new Guid("6ABB1F7D-1BAB-4405-8F72-A817C2FE9B05"),
                                               Name = "Jewelry",
                                               Description = "Kinh cương tự nhiên 98%",
                                               Price = 32422800,
                                               CategoryId = Guid.Parse("419CA5BE-F464-48AB-A7F4-B756673D28AF"),
                                               Status = 0,
                                               DateCreated = DateTime.Now,
                                               DateModified = DateTime.Now,
                                           }
                                           ,
                                              new Product
                                              {
                                                  ProductId = new Guid("E8447232-F062-423C-AC95-EAAD6FC8D8B1"),
                                                  Name = "Jewelry",
                                                  Description = "Kinh cương tự nhiên 98%",
                                                  Price = 32422800,
                                                  CategoryId = Guid.Parse("419CA5BE-F464-48AB-A7F4-B756673D28AF"),
                                                  Status = 0,
                                                  DateCreated = DateTime.Now,
                                                  DateModified = DateTime.Now,
                                              },
                                               new Product
                                               {
                                                   ProductId = new Guid("361C08C6-49C7-4DA0-96C3-9062ACD03BFF"),
                                                   Name = "Jewelry",
                                                   Description = "Kinh cương tự nhiên 98%",
                                                   Price = 32422800,
                                                   CategoryId = Guid.Parse("C9522945-FEC5-417F-90DA-820CC66AAF6C"),
                                                   Status = 0,
                                                   DateCreated = DateTime.Now,
                                                   DateModified = DateTime.Now,
                                               },
                                                 new Product
                                                 {
                                                     ProductId = new Guid("BCE4345D-D1CB-4D01-B904-BE38FCB9CACA"),
                                                     Name = "Jewelry",
                                                     Description = "Kinh cương tự nhiên 98%",
                                                     Price = 32422800,
                                                     CategoryId = Guid.Parse("C9522945-FEC5-417F-90DA-820CC66AAF6C"),
                                                     Status = 0,
                                                     DateCreated = DateTime.Now,
                                                     DateModified = DateTime.Now,
                                                 },
                                                     new Product
                                                     {
                                                         ProductId = new Guid("1876FA93-1502-4D84-93AE-5BA6301D63CB"),
                                                         Name = "Jewelry",
                                                         Description = "Kinh cương tự nhiên 98%",
                                                         Price = 32422800,
                                                         CategoryId = Guid.Parse("C9522945-FEC5-417F-90DA-820CC66AAF6C"),
                                                         Status = 0,
                                                         DateCreated = DateTime.Now,
                                                         DateModified = DateTime.Now,
                                                     }
                                                     ,
                                                       new Product
                                                       {
                                                           ProductId = new Guid("734AAB01-8668-4E5C-8AFB-473B05FC52C0"),
                                                           Name = "Jewelry",
                                                           Description = "Kinh cương tự nhiên 98%",
                                                           Price = 32422800,
                                                           CategoryId = Guid.Parse("131FF973-AC23-49D3-8880-04498FBA1FA8"),
                                                           Status = 0,
                                                           DateCreated = DateTime.Now,
                                                           DateModified = DateTime.Now,
                                                       },
                                                          new Product
                                                          {
                                                              ProductId = new Guid("1CC86444-85B6-4CD7-B002-AFE58CA36A39"),
                                                              Name = "Jewelry",
                                                              Description = "Kinh cương tự nhiên 98%",
                                                              Price = 32422800,
                                                              CategoryId = Guid.Parse("131FF973-AC23-49D3-8880-04498FBA1FA8"),
                                                              Status = 0,
                                                              DateCreated = DateTime.Now,
                                                              DateModified = DateTime.Now,
                                                          },
                                                         new Product
                                                         {
                                                             ProductId = new Guid("5D411445-BA01-46D2-92A4-C690F1E19DB4"),
                                                             Name = "Jewelry",
                                                             Description = "Kinh cương tự nhiên 98%",
                                                             Price = 32422800,
                                                             CategoryId = Guid.Parse("131FF973-AC23-49D3-8880-04498FBA1FA8"),
                                                             Status = 0,
                                                             DateCreated = DateTime.Now,
                                                             DateModified = DateTime.Now,
                                                         }










                );
        }
    }
}
