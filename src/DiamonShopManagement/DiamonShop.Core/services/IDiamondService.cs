using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.RequestModels;
using DiamonShop.Core.Respone;

using DiamonShop.Core.ViewModels;

namespace DiamonShop.Core.services
{
    public interface IDiamondService
    {
        Task<IEnumerable<Diamond>> GetAllDiamond();
        Task<Diamond> GetDiamondbyId(Guid id);
        Task<DiamondRespone> UpdateById(Guid id, UpdateDiamondRequest updateadiamond);
        Task<DiamondRespone> AddDiamond(CreateDiamondRequest createDiamondRequest);
    }
}
