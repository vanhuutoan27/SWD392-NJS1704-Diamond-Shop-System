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
            CreateMap<Diamond, DiamondResponses>()
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Product.Images.Select(i => i.Url).FirstOrDefault()))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Product.Status.ToString()));
            CreateMap<Diamond, CreateDiamondRequest>().ReverseMap();
            CreateMap<Jewelry, CreateUpdateJewelryRequest>().ReverseMap();

            CreateMap<Jewelry, JewelryResponse>()
            .ForMember(dest => dest.jewelryCategory, opt => opt.MapFrom(src => src.Product.Category.Name))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Product.Status))
            .ForMember(dest => dest.JewelryName, opt => opt.MapFrom(src => src.Name.ToString()))
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Product.Images.Select(i => i.Url).ToList()));
            CreateMap<AppUser, UserResponse>().ReverseMap();

            CreateMap<Order, OrderResponse>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items.ToList()));
            CreateMap<OrderItem, OrderDetailsResponse>()
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Product.Images.Select(i => i.Url).ToList()));

            CreateMap<Invoice, InvoiceResponse>()
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
        }
    }
}
