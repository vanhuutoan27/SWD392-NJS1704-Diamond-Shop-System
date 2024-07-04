using AutoMapper;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.auth;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;


using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;


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
        private readonly IEmailSender emailSender;

        public UserController(UserManager<AppUser> userManager,
IRepositoryManager repositoryManager,
IMapper mapper, IEmailSender emailSender)
        {
            this._userManager = userManager;
            resp = new ResultModel();
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            this.emailSender = emailSender;
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
                IsActive = false,
                Avatar = request.Avatar,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                DateCreated = DateTime.Now,
                EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            user = await _userManager.FindByEmailAsync(request.Email);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(ModelState);
            }
            await _userManager.AddToRoleAsync(user, request.Role);

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //send email to confirm
            var confirmationLink = Url.ActionLink("ConfirmEmail", "Identity", new { userId = user.Id, @token = token });
            //await emailSender.SendEmailAsync("quocdai904@gmail.com", user.Email, "Confirm your email address", confirmationLink);


            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;
        }
        private async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _userManager.FindByEmailAsync(userId);
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return new OkResult();

            }
            return NotFound(result);
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
                _repositoryManager.SaveAsync();
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
            if (UserToEdit.Avatar != request.Avatar)
            {
                UserToEdit.Avatar = request.Avatar;
            }
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
            else
            {
                user.IsActive = true;
                user.LockoutEnabled = false;
            }
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded) { return BadRequest(result.Errors); }
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;

        }

        [HttpPut("change-password")]
        [Authorize]
        public async Task<ActionResult<ResultModel>> ChangeMyPassword([FromBody] ChangePasswordRequest request)
        {
            if (request.OldPassword.ToLower().Equals(request.NewPassword.ToLower()))
            {
                return BadRequest("Old Password is The Same with New Password");
            }
            var userId = ((ClaimsIdentity)User.Identity).FindFirst("Id").Value;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();
            var result = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            if (!result.Succeeded)
            {
                return BadRequest(string.Join("<br>", result.Errors.Select(x => x.Description)));
            }
            resp.IsSuccess = true;
            resp.Message = "Change Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;


        }
    }
}