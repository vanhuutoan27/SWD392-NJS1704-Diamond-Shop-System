using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductService(IRepositoryManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }
        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
