using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ResultModel resp;

        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
            resp = new ResultModel();
        }
        [HttpGet(Name = "GetUsers")]
        public async Task<ActionResult<ResultModel>> GetUsers()
        {
            var users = _userManager.Users.ToList();
            if (users is null)
            {
                //resultModel.IsSuccess = false;
                //resultModel.
            }
            resp.IsSuccess = true;
            resp.Message = "Succesful";
            resp.Code = (int)HttpStatusCode.OK;
            resp.Data = users;
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
            var currenRole = roles.FirstOrDefault();
            if (currenRole != request.Role && roles.Any())
            {
                var removeResult = await _userManager.RemoveFromRolesAsync(UserToEdit, roles);
                if (!removeResult.Succeeded) return BadRequest($"Failed to remove role: {string.Join(", ", removeResult.Errors.Select(e => e.Description))}");

                var currentRole = roles.FirstOrDefault().ToString();
                var adddResult = await _userManager.AddToRoleAsync(UserToEdit, request.Role);
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

        [HttpPut("enable-user/{id}")]
        public async Task<ActionResult<ResultModel>> EnableUser(Guid id)
        {
            if (id == null) return BadRequest(ModelState);
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound();
            user.LockoutEnabled = false;
            user.IsActive = true;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded) { return BadRequest(result.Errors); }
            resp.IsSuccess = true;
            resp.Message = "Successfull";
            resp.Code = (int)HttpStatusCode.OK;
            return resp;

        }


    }
}
