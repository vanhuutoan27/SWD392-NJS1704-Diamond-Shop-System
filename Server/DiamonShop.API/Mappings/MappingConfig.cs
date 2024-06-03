using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;

namespace DiamonShop.API.Mappings
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Diamond, UpdateDiamondRequest>().ReverseMap();
            CreateMap<Diamond , CreateDiamondRequest>().ReverseMap();
            CreateMap<Jewelry , CreateUpdateJewelryRequest>().ReverseMap();

            CreateMap<AppUser, UserResponse>().ReverseMap();
        }
    }
}
