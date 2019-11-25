using Company.Core.Entity.Concrete;
using Company.Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}