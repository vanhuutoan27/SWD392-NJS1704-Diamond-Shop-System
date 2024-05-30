using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IProductRepository : IRepository<Product, Guid> 
    {
        void UpdateProduct(Guid id, Product product);
    }
    
}
