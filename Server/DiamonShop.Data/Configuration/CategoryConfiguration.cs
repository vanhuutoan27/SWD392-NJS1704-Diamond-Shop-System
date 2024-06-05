using DiamonShop.Core.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                    new Category
                    {
                        CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                        Name = "Diamond",
                        Description = "Kim Cuong vien nhap khau ",
                        CategoryImage = null,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    },
                     new Category
                     {
                         CategoryId = new Guid("420FCF35-560E-4FC9-86DB-7AC3C5C7A38C"),
                         Name = "Pendant",
                         Description = null,
                         CategoryImage = null,
                         DateCreated = DateTime.Now,
                         DateModified = DateTime.Now
                     },
                         new Category
                         {
                             CategoryId = new Guid("419CA5BE-F464-48AB-A7F4-B756673D28AF"),
                             Name = "Ring",
                             Description = null,
                             CategoryImage = null,
                             DateCreated = DateTime.Now,
                             DateModified = DateTime.Now
                         },
                          new Category
                          {
                              CategoryId = new Guid("C9522945-FEC5-417F-90DA-820CC66AAF6C"),
                              Name = "Bracelet",
                              Description = null,
                              CategoryImage = null,
                              DateCreated = DateTime.Now,
                              DateModified = DateTime.Now
                          },
                            new Category
                            {
                                CategoryId = new Guid("131FF973-AC23-49D3-8880-04498FBA1FA8"),
                                Name = "Earrings",
                                Description = null,
                                CategoryImage = null,
                                DateCreated = DateTime.Now,
                                DateModified = DateTime.Now
                            }



                );
        }

        public Guid CategoryId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string? CategoryImage { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
