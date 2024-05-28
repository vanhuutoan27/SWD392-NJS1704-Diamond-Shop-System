using System.ComponentModel.DataAnnotations;

namespace DiamonShop.Core.Domain.Content
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string? CategoryImage { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //Navigate
        public ICollection<Product> Products { get; set; }

    }
}
