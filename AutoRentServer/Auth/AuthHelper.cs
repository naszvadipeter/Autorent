using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoRentServer.Models.Autorent;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace AutoRentServer.Auth;

public class AuthHelper
{
    private WebApplicationBuilder builder;

    public AuthHelper(WebApplicationBuilder builder)
    {
        this.builder = builder;
    }
    
    public string GenerateJtwBearer(User user)
    {
        string k = builder.Configuration["Authentication:Schemes:Bearer:SigningKeys:0"];
        Byte[] key = Encoding.UTF8.GetBytes(k);
        SymmetricSecurityKey skey = new SymmetricSecurityKey(key);
        SigningCredentials SignedCredential = new SigningCredentials(skey, SecurityAlgorithms.HmacSha256Signature);
    
        string? issuer = builder.Configuration["Authentication:Schemes:Bearer:ValidIssuer"];
        string[] audiences = builder.Configuration.GetSection("Authentication:Schemes:Bearer:ValidAudiences").Get<string[]>();
    
        ClaimsIdentity uClains = new ClaimsIdentity(new []
        {
            new Claim("userId", user.Id.ToString()),
            new Claim(ClaimTypes.Role, user.Role)
        });
        DateTime expires = DateTime.UtcNow.AddDays(1);
    
        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = uClains,
            Expires = expires,
            Issuer = issuer,
            SigningCredentials = SignedCredential
        };

        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        JwtSecurityToken tokenJwt = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
    
        tokenJwt.Payload["aud"] = audiences;
        
        string? bearer = new JwtSecurityTokenHandler().WriteToken(tokenJwt);
    
        return bearer;
    }
}