using Company.Core.Entity.Concrete;
using Company.Core.Utilities;
using Company.Core.Utilities.Security.Jwt;
using Company.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
