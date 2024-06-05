﻿using Microsoft.IdentityModel.Tokens;
using RAD.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RAD.Services.Helpers;

public class AuthHepler
{
    public static string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(EnvironmentHelper.JWTKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim("PhoneNumber", user.PhoneNumber),
                new Claim(ClaimTypes.Role, nameof(user.UserRole)),
            }),

            Expires = DateTime.UtcNow.AddHours(
                Convert.ToInt32(EnvironmentHelper.TokenLifeTimeInHours)),

            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}