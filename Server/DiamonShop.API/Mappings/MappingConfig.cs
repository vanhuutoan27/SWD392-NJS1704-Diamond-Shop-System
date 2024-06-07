﻿using AutoMapper;
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
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Product.Images.Select(i => i.Url)))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Product.Status.ToString()));
            CreateMap<Diamond, CreateDiamondRequest>().ReverseMap();
            CreateMap<Jewelry, CreateUpdateJewelryRequest>().ReverseMap();

            CreateMap<Jewelry, JewelryResponse>()
            .ForMember(dest => dest.jewelryCategory, opt => opt.MapFrom(src => src.Product.Category.Name))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Product.Status))
            .ForMember(dest => dest.JewelryName, opt => opt.MapFrom(src => src.Name.ToString()))
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Product.Images.Select(i => i.Url).ToList()));
            CreateMap<AppUser, UserResponse>().ReverseMap();

        }
    }
}
