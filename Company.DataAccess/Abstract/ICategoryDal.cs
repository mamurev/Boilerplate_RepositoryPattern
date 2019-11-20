using Company.Core.DataAccess;
using Company.Entities.Concrete;

namespace Company.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
