using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }
        [HttpGet(Name = "GetUsers")]
        public async Task<ActionResult<ResultModel>> GetUsers()
        {
            ResultModel resultModel = new ResultModel();
            var users = _userManager.Users.ToList();
            if (users is null)
            {
                //resultModel.IsSuccess = false;
                //resultModel.
            }
            resultModel.IsSuccess = true;
            resultModel.Message = "Succesful";
            resultModel.Code = (int)HttpStatusCode.OK;
            resultModel.Data = users;
            return resultModel;
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
    }
}
