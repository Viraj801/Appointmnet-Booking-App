using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PatientAPI.Services
{
    public class Tokengenrerator : ITokengeneratorcs
    {
        public string GenerateToken(int id, string name)
        {
            var patientClaims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,new Guid().ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName,name)
            };

            var patientSecurityKey = Encoding.UTF8.GetBytes("askjhehsgdhtjrheggsgsgwgkjhfddyyu");
            var patientSymmetricSecurityKey = new SymmetricSecurityKey(patientSecurityKey);
            var patientSercurityCredentials=  new SigningCredentials(patientSymmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var patientJwtSecurityToken = new JwtSecurityToken
                (
                 issuer: "PatientApi",
                 audience: "AppointmentPaients",
                 claims: patientClaims,
                 signingCredentials: patientSercurityCredentials
                );
           var patientSecurityTokenHandler = new JwtSecurityTokenHandler().WriteToken(patientJwtSecurityToken);
            return patientSecurityTokenHandler;
        }

    }
}
