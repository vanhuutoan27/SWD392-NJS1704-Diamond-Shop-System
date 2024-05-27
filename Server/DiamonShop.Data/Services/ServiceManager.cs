using AutoMapper;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IDiamondService> _diamondService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper )
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _diamondService = new Lazy<IDiamondService>(() => new DiamondService(repositoryManager, mapper));
        }
        public IProductService ProductService => _productService.Value;

        public IDiamondService DiamondService => _diamondService.Value;
    }
}
