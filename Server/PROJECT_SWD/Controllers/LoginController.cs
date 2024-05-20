using BussinessLogic.Services;
using Data_Access.Repositories;
using BussinessLogic.RequestModel;
using Microsoft.AspNetCore.Mvc;
using BussinessLogic.ViewModels;

namespace PROJECT_SWD.Controllers
{
    public class LoginController : ControllerBase
    {

        private readonly LoginService _loginService;
    
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var response = await _loginService.LoginAsync(loginRequest);
            if (!ModelState.IsValid)
            {
               return BadRequest();
            }
           if(response.Success)
            {
                return Ok(response);
            }
           return Unauthorized(response);
        }
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenModel tokenModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _loginService.VerifyAndGenerateToken(tokenModel);
                if (result == null)
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
