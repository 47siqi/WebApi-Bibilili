using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZhaoxiFlower.Model;
using ZhaoxiFlower.Service.User.Dto;

namespace ZhaoxiFlower.Service.Jwt
{
    public class CustomJWTService : ICustomJWTService
    {
        private readonly JWTTokenOptions _jWTTokenOptions;
        public CustomJWTService(IOptionsMonitor<JWTTokenOptions> jwtTokenOptions)
        {
            _jWTTokenOptions = jwtTokenOptions.CurrentValue;
        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetToken(UserRes user)
        {
            var claims = new[]
            {
            new Claim("id", user.Id.ToString()),
            new Claim("NickName", user.NickName),
            new Claim("UserName", user.UserName),
            new Claim("UserType", user.UserType.ToString()),
            };
            //需要加密：需要加密key
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jWTTokenOptions.SecurityKey));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //Nuget引入：System.IdentityModel.Tokens.Jwt
            JwtSecurityToken token = new JwtSecurityToken(
             issuer: _jWTTokenOptions.Issuer,
             audience: _jWTTokenOptions.Audience,
             claims: claims,
             expires: DateTime.Now.AddMinutes(10),//5分钟有效期
             signingCredentials: creds);

            string returnToken = new JwtSecurityTokenHandler().WriteToken(token);
            return returnToken;
        }
    }
}
