using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamonShop.Core.Domain.Content
{
    public class Inventory
    {
        [Key]
        public Guid InventoryId { get; set; }
        public Guid ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //navigate 
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

    }
}
