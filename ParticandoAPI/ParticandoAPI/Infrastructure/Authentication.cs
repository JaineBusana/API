using Microsoft.IdentityModel.Tokens;
using ParticandoAPI.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ParticandoAPI.Infrastructure
{
    public class Authentication
    {
        public static string GenerateToken (CollectionPointEntity collectionPoint)
        {
            var key = Encoding.ASCII.GetBytes(Configuration.JWTSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, collectionPoint.Name),
                    new Claim(ClaimTypes.MobilePhone, collectionPoint.Telephone)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        
    }
}
