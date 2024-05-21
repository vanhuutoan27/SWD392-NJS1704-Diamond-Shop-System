using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.RequestModels;
using DiamonShop.Core.ViewModels;

namespace DiamonShop.API.Mappings
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Diamond, UpdateDiamondRequest>().ReverseMap();
        }
    }
}
