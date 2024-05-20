using AutoMapper;
using Data_Access.AuViewModel.LoginRespone;
using Data_Access.Repositories;
using BussinessLogic.RequestModel;
using Data_Access.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic.Enums;
using Data_Access.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using BussinessLogic.ViewModels;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace BussinessLogic.Services
{

    public class LoginService
    {
        private readonly IMapper _mapper;
        private readonly LoginRepository _loginRepository;
        private readonly IConfiguration _config;
        private readonly RefreshtokenRepository _refreshtokenRepository;
        private readonly TokenValidationParameters _tokenValidationParameters;
        public readonly UserRepository _userRepository;
        public LoginService(IMapper mapper, LoginRepository loginRepository, IConfiguration config
            , RefreshtokenRepository refreshtokenRepository, TokenValidationParameters tokenValidationParameters, UserRepository userRepository)
        {
            _mapper = mapper;
            _loginRepository = loginRepository;
            _config = config;
            _refreshtokenRepository = refreshtokenRepository;
            _tokenValidationParameters = tokenValidationParameters;
            _userRepository = userRepository;
        }

        public async Task<LoginResponee> LoginAsync(LoginRequest login)
        {
            var user = await _loginRepository.GetUserByEmailAsync(login.Email);
            var userModel = _mapper.Map<UserViewModel>(user);

            if (user == null)
            {
                return new LoginResponee
                {
                    Success = false,
                    Message = "Email does not exist!"
                };
            }
            string passwordtoCheck = login.Password;
            bool passwordVerified = false;
            string storedPassword = user.Password;
            if (storedPassword.Length == 60 && storedPassword.StartsWith("$2a$"))
            {
                // Mật khẩu đã được mã hóa, sử dụng Verify của BCrypt để xác minh
                passwordVerified = BCrypt.Net.BCrypt.Verify(passwordtoCheck, storedPassword);
            }
            else
            {
                // Mật khẩu chưa được mã hóa, mã hóa mật khẩu trước khi xác minh
                passwordVerified = (passwordtoCheck == storedPassword);
            }

            if (!passwordVerified)
            {
                return new LoginResponee
                {
                    Success = false,
                    Message = "Wrong password"
                };
            }



            return new LoginResponee
            {
                Success = true,
                Data = GenerateJwtToken(userModel),
                Message = "Login successful!"
            };

        }
        public TokenModel GenerateJwtToken(UserViewModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            var expries = DateTime.Now.Add(TimeSpan.Parse(_config.GetSection("JwtSettings:ExpiryTimeFrame").Value));
            var handler = new JwtSecurityTokenHandler();


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JwtSettings:Key").Value));
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sid,user.UserId.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name,user.Name),
                    new Claim(JwtRegisteredClaimNames.Email,user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat,DateTime.Now.ToUniversalTime().ToString()),
                    new Claim(ClaimTypes.Role, Enum.GetName(typeof(RoleENum), user.Role))
        }),
                Expires = expries,
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)

            };
            var token = handler.CreateToken(tokenDescription);
            var accessToken = handler.WriteToken(token);
            var refreshToken = new RefreshToken
            {
                RefreshTokenId = Guid.NewGuid(),
                JwtId = token.Id,
                Token = RandomStringGeneration(),
                IssuedAt = DateTime.Now,
                ExpriedAt = DateTime.UtcNow.AddDays(1),
                IsRevoked = false,
                IsUsed = false,
                UserId = user.UserId

            };
            _refreshtokenRepository.CreateToken(refreshToken);


            return new TokenModel
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken.Token
            };
        }
        public async Task<LoginResponee> VerifyAndGenerateToken(TokenModel token)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            try
            {
                //_tokenValidationParameters.ValidateLifetime = false;
                var tokenVerification = jwtTokenHandler.ValidateToken(token.AccessToken, _tokenValidationParameters, out var validatedToken);
                if (validatedToken is JwtSecurityToken jwtToken)
                {
                    var result = jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);
                    if (result == false)

                        return null;

                }
                var utcExpiryDate = long.Parse(tokenVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

                var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);
                if (expiryDate > DateTime.Now)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Token is not expired yet"
                    };
                }
                else
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Token has expired"
                    };
                }
                var storedToken = _refreshtokenRepository.FindToken(token.RefreshToken);
                if (storedToken == null)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Refresh token does not exist"
                    };
                }
                if (storedToken.Result.IsUsed)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Refresh token has been used"
                    };
                }
                if (storedToken.Result.IsRevoked)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Refresh token has been revoked"
                    };
                }
                var jti = tokenVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                if (storedToken.Result.JwtId != jti)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Invalid Token"
                    };
                }
                if (storedToken.Result.ExpriedAt < DateTime.UtcNow)
                {
                    return new LoginResponee
                    {
                        Success = false,
                        Message = "Exprired Token"
                    };
                }
                storedToken.Result.IsUsed = true;
                _refreshtokenRepository.UpadateToken(storedToken.Result);

                var dbUser = _userRepository.GetUserById(storedToken.Result.UserId);
                var userModel = _mapper.Map<UserViewModel>(dbUser);
                var accessToken = GenerateJwtToken(userModel);
                return new LoginResponee
                {
                    Success = true,
                    Data = accessToken,
                    Message = "Verify And GenerateToken success"
                };
            }
            catch (Exception ex)
            {
                var storedToken = _refreshtokenRepository.FindToken(token.RefreshToken);
                storedToken.Result.IsUsed = true;
                _refreshtokenRepository.UpadateToken(storedToken.Result);
               var dbUser = _userRepository.GetUserById(storedToken.Result.UserId);
                var userModel = _mapper.Map<UserViewModel>(dbUser);
                var accessToken = GenerateJwtToken(userModel);
                return new LoginResponee
                {
                    Success = true,
                    Data = accessToken,
                    Message = "Verify And GenerateToken success"
                };
            }

        }
        private DateTime UnixTimeStampToDateTime(long utcExpiryDate)
        {
            var dateTimeVal = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(utcExpiryDate).ToLocalTime();
            return dateTimeVal;
        }
        private string RandomStringGeneration()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);

                return Convert.ToBase64String(random);
            }
        }
    }
}
