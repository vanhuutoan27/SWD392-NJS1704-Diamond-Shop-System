using AutoMapper;
using Data_Access.AuViewModel.LoginRespone;
using Data_Access.Models;
using Data_Access.Repositories;
using BussinessLogic.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.ViewModels;
using BussinessLogic.Enums;

namespace BussinessLogic.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly UserRepository _userRepository;
        public UserService(IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<LoginResponee> CreateUser(UserCreateRequest userCreate)
        {
            //ma hoa password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userCreate.Password);
            var userEntity = _mapper.Map<User>(userCreate);

          
           
            userEntity.CreatedOn = DateTime.UtcNow;

            if (userCreate.RoleId < 1 || userCreate.RoleId > Enum.GetValues(typeof(RoleENum)).Length)
            {
                return new LoginResponee
                {
                    Message = "Role not exist",
                    Success = false
                };
            }

            userEntity.Password = passwordHash;
            userEntity.Role = userCreate.RoleId;
            userEntity.UserId = Guid.NewGuid();
            var existedUser = await _userRepository.GetUserByEmailAsync(userCreate.Email);
            if (existedUser != null)
            {
                return new LoginResponee
                {
                    Message = "Email already exists",
                    Success = false
                };
            }

            await _userRepository.CreateUserAsync(userEntity);
                await _userRepository.SaveAsync();

            return new LoginResponee
            {
                Message = "User created successfully",
                Success = true,
                Data = userCreate,
            };
        }
        public async Task<UserViewModel> GetUserById(Guid userId)
        {
            var getuserid = await _userRepository.GetUserById(userId);
            var userModel = _mapper.Map<UserViewModel>(getuserid);
            return userModel;
        }
    }

}

