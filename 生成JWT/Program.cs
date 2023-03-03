using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

List<Claim> claims = new List<Claim>();
claims.Add(new Claim("Passport", "123456"));
claims.Add(new Claim("QQ", "2432342341"));
claims.Add(new Claim("ID", "001"));
claims.Add(new Claim(ClaimTypes.Name, "GreenDot"));
claims.Add(new Claim(ClaimTypes.HomePhone, "119"));
claims.Add(new Claim(ClaimTypes.Role, "admin"));
claims.Add(new Claim(ClaimTypes.NameIdentifier, "119"));
string key = "123345567sdqwasd_";
DateTime expires = DateTime.Now.AddHours(1); //过期时间
byte[] secBytes = Encoding.UTF8.GetBytes(key);
var secKey = new SymmetricSecurityKey(secBytes);
var credentials = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256Signature);
var tokenDescriptor = new JwtSecurityToken(claims: claims,
    expires: expires, signingCredentials: credentials);
string jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
Console.WriteLine(jwt);