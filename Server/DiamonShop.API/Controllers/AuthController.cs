using DiamonShop.API.Extensions;
using DiamonShop.API.Services;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.auth;
using DiamonShop.Core.Models.system;
using DiamonShop.Core.SeedWorks.Constants;
using DiamonShop.Core.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text.Json;
using static DiamonShop.Core.SeedWorks.Constants.Permission;

namespace DiamonShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IEmailSender emailSender;
        private readonly IConfiguration _config;
        private readonly ResultModel _resp;
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService,
            RoleManager<AppRole> roleManager, IEmailSender emailSender, IConfiguration config)
        {
            _userManager = userManager;
            this._signInManager = signInManager;
            this._tokenService = tokenService;
            this._roleManager = roleManager;
            this.emailSender = emailSender;
            this._config = config;
            _resp = new ResultModel();
        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthenticatedResult>> Login([FromBody] LoginRequests request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request");
            }
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null || user.IsActive == false || user.LockoutEnabled)
            {
                return Unauthorized();
            }
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                return Unauthorized("Invalid Password");
            }

            //authorization 
            var roles = await _userManager.GetRolesAsync(user);
            var permissions = await this.GetPermissionsByUserIdAsync(user.Id.ToString());
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(UserClaims.Id, user.Id.ToString()),
                // new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(UserClaims.FullName, user.FullName),
                 //new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(UserClaims.Roles, string.Join(";", roles)),
                    new Claim(UserClaims.Permissions, JsonSerializer.Serialize(permissions)),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);
            await _userManager.UpdateAsync(user);

            return Ok(new AuthenticatedResult() { Token = accessToken, RefreshToken = refreshToken, ExpiryTime = user.RefreshTokenExpiryTime });
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var users = new AppUser
            {
                FullName = request.FullName,
                UserName = request.FullName.Replace(" ", ""),
                Email = request.Email,
                IsActive = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                DateCreated = DateTime.Now
            };
            var result = await _userManager.CreateAsync(users, request.Password);

            if (result.Succeeded)
            {
                users = await _userManager.FindByEmailAsync(request.Email);
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(users);
                var confirmationLink = $"http://localhost:1412/?token={Uri.EscapeDataString(token)}&email={Uri.EscapeDataString(user.Email)}&success=true";
                var message = new Message(new string[] { users.Email! }, "Confirmation email link", confirmationLink!);
                await emailSender.SendEmailAsync(message);

                await _userManager.AddToRoleAsync(users, Core.SeedWorks.Constants.Roles.Customer);
                return Ok(new { Message = "Register Succesfull!" });
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return BadRequest(ModelState);
        }
        [HttpPost("ConfirmEmail")]
        public async Task<ActionResult<ResultModel>> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    _resp.IsSuccess = true;
                    _resp.Message = "Confirmation Succesfull, You can login now!";
                    _resp.Code = 200;

                    return _resp;
                }

            }
            _resp.Message = "Verify Token Fail";
            _resp.IsSuccess = false;
            _resp.Code = 500;
            return _resp;

        }


        [HttpGet("Test")]
        public async Task<IActionResult> TestEmail()
        {
            var message = new Message(new string[] { "dainqse160959@fpt.edu.vn", "duyphse160496@fpt.edu.vn",
                "khanhnpse160945@fpt.edu.vn" }, "Warning about project", "<h1>Hello nha ku, code PRN toi dau roi </h1>");

            await emailSender.SendEmailAsync(message);
            return StatusCode(StatusCodes.Status200OK);
        }

        private async Task<List<string>> GetPermissionsByUserIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            var permissions = new List<string>();

            var allPermissions = new List<RoleClaimsDto>();
            if (roles.Contains(Core.SeedWorks.Constants.Roles.Admin))
            {
                var types = typeof(Permission).GetTypeInfo().DeclaredNestedTypes;
                foreach (var type in types)
                {
                    allPermissions.GetPermissions(type);
                }
                permissions.AddRange(allPermissions.Select(x => x.Value));
            }
            else
            {
                foreach (var roleName in roles)
                {
                    var role = await _roleManager.FindByNameAsync(roleName);
                    var claims = await _roleManager.GetClaimsAsync(role);
                    var roleClaimValues = claims.Select(x => x.Value).ToList();
                    permissions.AddRange(roleClaimValues);
                }

            }
            return permissions.Distinct().ToList();
        }
    }
}
