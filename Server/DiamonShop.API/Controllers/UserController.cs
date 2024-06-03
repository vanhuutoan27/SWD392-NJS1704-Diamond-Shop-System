﻿using AutoMapper;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;
using DiamonShop.Core.SeedWorks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ResultModel resp;

        private readonly UserManager<AppUser> _userManager;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public UserController(UserManager<AppUser> userManager,
IRepositoryManager repositoryManager,
IMapper mapper)
        {
            this._userManager = userManager;
            resp = new ResultModel();
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<ActionResult<ResultModel>> GetUsers()
        {
            var query = _userManager.Users;
            query = query.OrderBy(u => u.FullName);
            var userLists = _mapper.ProjectTo<UserResponse>(query).ToList();
            foreach (var item in userLists)
            {
                var user = await _userManager.FindByIdAsync(item.id.ToString());
                item.Roles = await _userManager.GetRolesAsync(user);
            }
            resp.IsSuccess = true;
            resp.Message = "Succesful";
            resp.Code = (int)HttpStatusCode.OK;
            resp.Data = userLists;
            return resp;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultModel>> GetUserById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) { return NotFound(user); }
            var roles = await _userManager.GetRolesAsync(user);
            var userDto = _mapper.Map<UserResponse>(user); ;
            userDto.Roles = roles;
            resp.IsSuccess = true;
            resp.Message = "Succesful";
            resp.Code = (int)HttpStatusCode.OK;
            resp.Data = userDto;
            return resp;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<ResultModel>> CreateUser([FromBody] CreateUserRequest request)
        {
            ResultModel resp = new ResultModel();
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            var user = new AppUser
            {
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.Phone,
                UserName = request.FullName.Replace(" ", ""),
                Address = request.Address,
                IsActive = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                DateCreated = DateTime.Now
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(ModelState);
            }
            await _userManager.AddToRoleAsync(user, request.Role);
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultModel>> UpdateUser(Guid id, [FromBody] UpdateUserRequest request)
        {
            if (!ModelState.IsValid || id == null) { return BadRequest(ModelState); }
            var UserToEdit = await _userManager.FindByIdAsync(id.ToString());
            if (UserToEdit == null) { return NotFound(ModelState); }

            var roles = await _userManager.GetRolesAsync(UserToEdit);
            if (roles.FirstOrDefault() != request.Role)
            {
                await _repositoryManager.User.RemoveUserFromRoleAsync(UserToEdit.Id, roles.ToArray());
                _repositoryManager.Save();
                var addedResult = await _userManager.AddToRoleAsync(UserToEdit, request.Role);
                if (!addedResult.Succeeded)
                {
                    foreach (var error in addedResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return BadRequest(ModelState);
                }
            }

            if (UserToEdit.Email != request.Email)
                UserToEdit.Email = request.Email;

            if (UserToEdit.FullName != request.FullName)
            {
                UserToEdit.FullName = request.FullName;
                UserToEdit.UserName = request.FullName.Replace(" ", "");
            }

            if (UserToEdit.PhoneNumber != request.Phone)
                UserToEdit.PhoneNumber = request.Phone;

            if (UserToEdit.Address != request.Address)
                UserToEdit.Address = request.Address;

            var result = await _userManager.UpdateAsync(UserToEdit);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
                return BadRequest(ModelState);
            }
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultModel>> DeleteUser(Guid id)
        {
            if (id == null) return BadRequest(ModelState);
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound();
            user.LockoutEnabled = true;
            user.IsActive = false;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded) { return BadRequest(result.Errors); }
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;
        }

        [HttpPut("change-status/{id}")]
        public async Task<ActionResult<ResultModel>> EnableUser(Guid id)
        {
            if (id == null) return BadRequest(ModelState);
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound();
            if (user.IsActive)
            {
                user.IsActive = false;
                user.LockoutEnabled = true;
            }
            user.IsActive = true;
            user.LockoutEnabled = false;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded) { return BadRequest(result.Errors); }
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;

        }


    }
}
