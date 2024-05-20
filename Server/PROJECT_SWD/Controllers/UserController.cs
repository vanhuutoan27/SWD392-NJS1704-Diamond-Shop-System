using BussinessLogic.RequestModel;
using BussinessLogic.Services;
using Data_Access.AuViewModel.LoginRespone;
using Data_Access.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PROJECT_SWD.Controllers
{
    public class UserController : ControllerBase
    {

        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateRequest userCreateRequest)
        {
            var userCreated = await _userService.CreateUser(userCreateRequest);

            return userCreated is not null ? Created("Create User Success", userCreated) : BadRequest("Failed to create user");
        }

        [HttpGet]
        [Route("getUserById")]
        [Authorize]
        public async Task<ActionResult<LoginResponee>> GetUserById(GetUserByIdRequest getUserByIdRequest)
        {


            var user = await _userService.GetUserById(getUserByIdRequest.UserId);
            if (user == null) return BadRequest();
            return new LoginResponee
            {
                Success = true,
                Message = "sucess",
                Data = user
            };
        }
    }

}


