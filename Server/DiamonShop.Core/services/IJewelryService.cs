using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;

namespace DiamonShop.Core.services
{
    public interface IJewelryService
    {
        Task<IEnumerable<JewelryResponse>> GetAllJewelries();
        Task<Jewelry> GetJewelryById(Guid id);
        Task<CreateUpdateJewelryRequest> CreateJewelry(CreateUpdateJewelryRequest jewelryDto);
        Task<bool> DeleteJewelry(Guid id);
        Task<bool> UpdateJewelry(Guid id, CreateUpdateJewelryRequest jewelryDto);
    }
}
