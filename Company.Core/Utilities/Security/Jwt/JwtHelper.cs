using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Company.Core.Entity.Concrete;
using Company.Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Company.Core.Extensions;
using System.Linq;

namespace Company.Core.Utilities.Security.Jwt
{
    //Dependencies
    //Microsoft.Extensions.Configuration 
    //Microsoft.IdentityModel.Tokens
    //JwtSecurityToken
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            //securityKey : helps to create a token
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            
            var token = jwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            return new JwtSecurityToken(
                    issuer: tokenOptions.Issuer,
                    audience: tokenOptions.Audience,
                    claims: SetClaims(user, operationClaims),
                    expires: _accessTokenExpiration,
                    notBefore: DateTime.Now,
                    signingCredentials: signingCredentials
            );
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());
            return claims;
        }
    }
}
