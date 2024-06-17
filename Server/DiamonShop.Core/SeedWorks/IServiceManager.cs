using DiamonShop.Core.services;

namespace DiamonShop.Core.SeedWorks
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IDiamondService DiamondService { get; }
        IJewelryService JewelryService { get; }
        IOrderService OrderService { get; }
    }
}
