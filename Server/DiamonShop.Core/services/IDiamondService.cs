using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;

namespace DiamonShop.Core.services
{
    public interface IDiamondService
    {
        Task<IEnumerable<DiamondResponses>> GetAllDiamond();
        Task<DiamondResponses> GetDiamondbyId(Guid id);
        Task<DiamondRespone> UpdateById(Guid id, UpdateDiamondRequest updateadiamond);
        Task<DiamondRespone> AddDiamond(CreateDiamondRequest createDiamondRequest);
        Task RemoveDiamondById(Guid id);
    }
}
