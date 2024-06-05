using DiamonShop.Core.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiamonShop.Data.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                    new Image
                    {
                        ImageId = new Guid("C20D846C-A73B-4356-8736-A51273667BEE"),
                        ProductId = Guid.Parse("9F3519C6-1DF4-4125-BBEF-8E7825425DCD"),
                        Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_1.jpg?alt=media&token=ac90a06a-e325-4d08-bf75-5d6078da28f4",
                        DateCreated = DateTime.Now,

                    },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("9F3519C6-1DF4-4125-BBEF-8E7825425DCD"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6",
                         DateCreated = DateTime.Now,

                     },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("C2BC12A6-E878-4DA0-9B70-656CC94F3316"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482",
                     },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("C2BC12A6-E878-4DA0-9B70-656CC94F3316"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf"
                     },
                       new Image
                       {
                           ImageId = Guid.NewGuid(),
                           ProductId = Guid.Parse("AF32B397-0DC4-46FA-AA7F-EB31BFFD2821"),
                           Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3"
                       },
                        new Image
                        {
                            ImageId = Guid.NewGuid(),
                            ProductId = Guid.Parse("AF32B397-0DC4-46FA-AA7F-EB31BFFD2821"),
                            Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5"
                        },
                           new Image
                           {
                               ImageId = Guid.NewGuid(),
                               ProductId = Guid.Parse("4FD47F59-6149-48C2-B1AD-E454438D08C3"),
                               Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939"
                           },
                           new Image
                           {
                               ImageId = Guid.NewGuid(),
                               ProductId = Guid.Parse("4FD47F59-6149-48C2-B1AD-E454438D08C3"),
                               Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5"
                           },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("6ABB1F7D-1BAB-4405-8F72-A817C2FE9B05"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6"
                     },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("6ABB1F7D-1BAB-4405-8F72-A817C2FE9B05"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97"
                     },
                     new Image
                     {
                         ImageId = Guid.NewGuid(),
                         ProductId = Guid.Parse("E8447232-F062-423C-AC95-EAAD6FC8D8B1"),
                         Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a"
                     },
                       new Image
                       {
                           ImageId = Guid.NewGuid(),
                           ProductId = Guid.Parse("E8447232-F062-423C-AC95-EAAD6FC8D8B1"),
                           Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790"
                       },
                       new Image
                       {
                           ImageId = Guid.NewGuid(),
                           ProductId = Guid.Parse("361C08C6-49C7-4DA0-96C3-9062ACD03BFF"),
                           Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615"
                       },
                        new Image
                        {
                            ImageId = Guid.NewGuid(),
                            ProductId = Guid.Parse("361C08C6-49C7-4DA0-96C3-9062ACD03BFF"),
                            Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872"
                        },
                         new Image
                         {
                             ImageId = Guid.NewGuid(),
                             ProductId = Guid.Parse("BCE4345D-D1CB-4D01-B904-BE38FCB9CACA"),
                             Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7"
                         },
                           new Image
                           {
                               ImageId = Guid.NewGuid(),
                               ProductId = Guid.Parse("BCE4345D-D1CB-4D01-B904-BE38FCB9CACA"),
                               Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5"
                           },
                          new Image
                          {
                              ImageId = Guid.NewGuid(),
                              ProductId = Guid.Parse("1876FA93-1502-4D84-93AE-5BA6301D63CB"),
                              Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b"
                          },
                          new Image
                          {
                              ImageId = Guid.NewGuid(),
                              ProductId = Guid.Parse("1876FA93-1502-4D84-93AE-5BA6301D63CB"),
                              Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412"
                          },
                           new Image
                           {
                               ImageId = Guid.NewGuid(),
                               ProductId = Guid.Parse("734AAB01-8668-4E5C-8AFB-473B05FC52C0"),
                               Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733"
                           },
                          new Image
                          {
                              ImageId = Guid.NewGuid(),
                              ProductId = Guid.Parse("734AAB01-8668-4E5C-8AFB-473B05FC52C0"),
                              Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f"
                          },
                             new Image
                             {
                                 ImageId = Guid.NewGuid(),
                                 ProductId = Guid.Parse("1CC86444-85B6-4CD7-B002-AFE58CA36A39"),
                                 Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be"
                             },
                              new Image
                              {
                                  ImageId = Guid.NewGuid(),
                                  ProductId = Guid.Parse("1CC86444-85B6-4CD7-B002-AFE58CA36A39"),
                                  Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7"
                              },
                                new Image
                                {
                                    ImageId = Guid.NewGuid(),
                                    ProductId = Guid.Parse("5D411445-BA01-46D2-92A4-C690F1E19DB4"),
                                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d"
                                },
                                 new Image
                                 {
                                     ImageId = Guid.NewGuid(),
                                     ProductId = Guid.Parse("5D411445-BA01-46D2-92A4-C690F1E19DB4"),
                                     Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f"
                                 }









                );
        }
    }
}
