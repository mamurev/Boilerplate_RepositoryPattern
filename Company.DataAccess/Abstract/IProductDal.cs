using Company.Core.DataAccess;
using Company.Entities.Concrete;

namespace Company.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Add new methods consists of complex queries here
    }
}
