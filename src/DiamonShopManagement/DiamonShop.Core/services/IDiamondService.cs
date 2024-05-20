using DiamonShop.Core.Domain.Content;

namespace DiamonShop.Core.services
{
    public interface IDiamondService
    {
        Task<IEnumerable<Diamond>> GetAllDiamond();
    }
}
