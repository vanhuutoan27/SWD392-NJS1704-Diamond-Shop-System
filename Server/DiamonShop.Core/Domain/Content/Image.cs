using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public Guid ProductId { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //FK
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
