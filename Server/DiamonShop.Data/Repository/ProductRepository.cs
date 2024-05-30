using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product, Guid>, IProductRepository
    {
        public ProductRepository(DiamondContext context) : base(context)
        {

        }

        public void UpdateProduct(Guid id, Product product)
        {
            var productFromDb = _context.Products.FirstOrDefault(u => u.ProductId == id);
            if (productFromDb != null)
            {
                productFromDb.Name = product.Name;
            }
            _context.SaveChanges();
        }
    }
}
