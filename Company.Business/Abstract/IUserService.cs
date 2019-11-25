using Company.Core.Entity.Concrete;
using System.Collections.Generic;

namespace Company.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByEmail(string email);
    }
}
