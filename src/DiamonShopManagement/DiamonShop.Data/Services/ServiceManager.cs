using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IDiamondService> _diamondService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager));
            _diamondService = new Lazy<IDiamondService>(() => new DiamondService(repositoryManager));
        }
        public IProductService ProductService => _productService.Value;

        public IDiamondService DiamondService => _diamondService.Value;
    }
}
