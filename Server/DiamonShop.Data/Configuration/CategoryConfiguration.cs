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
                        Name = "Kim Cương Viên",
                        Description = "Kim Cuong vien nhap khau ",
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
