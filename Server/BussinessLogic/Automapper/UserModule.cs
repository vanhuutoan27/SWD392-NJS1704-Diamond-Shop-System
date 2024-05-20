using AutoMapper;
using BussinessLogic.RequestModel;
using Data_Access.Models;
using Data_Access.ViewModels;
using Microsoft.AspNetCore.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Automapper
{

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, UserCreateRequest>().ReverseMap();
            CreateMap<User, RegistRequests>().ReverseMap();
        
        }
    }
}

