using DiamonShop.Core.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Required]
        public double Price { get; set; }

        public Guid CategoryId { get; set; }

        public EnumStatus.Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //FK 
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        //Navigate
        public ICollection<Image> Images { get; set; }
        public ICollection<Inventory> Inventorys { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Diamond Diamond { get; set; }
        public Jewelry Jewelry { get; set; }


    }

}
