using AutoMapper;
using BussinessLogic.RequestModel;
using Data_Access.AuViewModel.LoginRespone;
using Data_Access.Models;
using Data_Access.Repositories;
using Microsoft.AspNetCore.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic.RequestModel;
using BussinessLogic.Enums;

namespace BussinessLogic.Services
{
    public class RegisterService
    {
        private readonly IMapper _mapper;
        private readonly RegistRepository _registerRepository;

        public RegisterService(IMapper mapper, RegistRepository registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }
        public async Task<LoginResponee> RegistUser(RegistRequests userCreate)
        {
            //ma hoa password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userCreate.Password);
            var userEntity = _mapper.Map<User>(userCreate);
            userEntity.Password = passwordHash;
            var existedUser = await _registerRepository.GetUserByEmailAsync(userCreate.Email);
            if (existedUser != null)
            {
                return new LoginResponee
                {
                    Message = "Email already exists",
                    Success = false
                };
            }

            await _registerRepository.RegistAsync(userEntity);
            await _registerRepository.SaveAsync();

            return new LoginResponee
            {
                Message = "Regist  successfully",
                Success = true,
                Data = userCreate,
            };
        }

    }
}