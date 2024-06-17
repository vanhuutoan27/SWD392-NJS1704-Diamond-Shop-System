using AutoMapper;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Data.Services;

namespace DiamonShop.Data.SeedWorks
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IDiamondService> _diamondService;
        private readonly Lazy<IJewelryService> _jewelryService;
        private readonly Lazy<IOrderService> _orderService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _diamondService = new Lazy<IDiamondService>(() => new DiamondService(repositoryManager, mapper));
            _jewelryService = new Lazy<IJewelryService>(() => new JewelryService(repositoryManager, mapper));
            _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, mapper));

        }
        public IProductService ProductService => _productService.Value;

        public IDiamondService DiamondService => _diamondService.Value;
        public IJewelryService JewelryService => _jewelryService.Value;

        public IOrderService OrderService => _orderService.Value;
    }
}
