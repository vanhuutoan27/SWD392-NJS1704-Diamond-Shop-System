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
                    CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
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
                      CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
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
                      CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                      Status = 0,
                      DateCreated = DateTime.Now,
                      DateModified = DateTime.Now,
                  }





                );
        }
    }
}
