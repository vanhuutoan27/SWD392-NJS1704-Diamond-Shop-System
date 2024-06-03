using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Models.content.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonShop.Core.services
{
    public interface IJewelryService
    {
        Task<IEnumerable<Jewelry>> GetAllJewelries();
        Task<Jewelry> GetJewelryById(Guid id);
        Task<CreateUpdateJewelryRequest> CreateJewelry(CreateUpdateJewelryRequest jewelryDto);
        Task<bool> DeleteJewelry(Guid id);
        Task<bool> UpdateJewelry(Guid id, CreateUpdateJewelryRequest jewelryDto);
    }
}
