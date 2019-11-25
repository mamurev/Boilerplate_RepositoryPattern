using Company.Core.DataAccess.EntityFramework;
using Company.Core.Entity.Concrete;
using Company.DataAccess.Abstract;
using Company.DataAccess.Concrete.EntityFramework.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Company.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims on oc.Id equals uoc.OperationClaimId
                             where uoc.UserId == user.Id
                             select new OperationClaim { Id = oc.Id, Name = oc.Name };
                return result.ToList();
            }
        }
    }
}
