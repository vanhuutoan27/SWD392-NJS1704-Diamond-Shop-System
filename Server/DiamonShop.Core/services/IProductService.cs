using DiamonShop.Core.Domain.Content;

namespace DiamonShop.Core.services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();

    }
}
