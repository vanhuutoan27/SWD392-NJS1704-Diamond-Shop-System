using AutoMapper;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Data.Services;
using Microsoft.AspNetCore.Identity;

namespace DiamonShop.Data.SeedWorks
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IDiamondService> _diamondService;
        private readonly Lazy<IJewelryService> _jewelryService;
        private readonly Lazy<IOrderService> _orderService;
        private readonly Lazy<IInvoiceService> _invoiceService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _diamondService = new Lazy<IDiamondService>(() => new DiamondService(repositoryManager, mapper));
            _jewelryService = new Lazy<IJewelryService>(() => new JewelryService(repositoryManager, mapper));
            _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, mapper));
            _invoiceService = new Lazy<IInvoiceService>(() => new InvoiceService(repositoryManager, mapper, userManager));

        }
        public IProductService ProductService => _productService.Value;

        public IDiamondService DiamondService => _diamondService.Value;
        public IJewelryService JewelryService => _jewelryService.Value;

        public IOrderService OrderService => _orderService.Value;

        public IInvoiceService InvoiceService => _invoiceService.Value;
    }
}
