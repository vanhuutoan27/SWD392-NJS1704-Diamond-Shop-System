using DiamonShop.Core.Repository;

namespace DiamonShop.Core.SeedWorks
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IDiamondRepository Diamond { get; }
        IJewelryRepository Jewelry { get; }
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
        IOrderRepository Order { get; }
        IOrderItemsRepository OrderItems { get; }
        Task SaveAsync();

    }
}
