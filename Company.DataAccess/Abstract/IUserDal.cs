using Company.Core.DataAccess;
using Company.Core.Entity.Concrete;
using System.Collections.Generic;

namespace Company.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
