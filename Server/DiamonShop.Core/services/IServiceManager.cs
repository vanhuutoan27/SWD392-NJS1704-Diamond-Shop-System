namespace DiamonShop.Core.services
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IDiamondService DiamondService { get; }
    }
}
