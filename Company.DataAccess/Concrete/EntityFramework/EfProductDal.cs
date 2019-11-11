using Company.Core.DataAccess.EntityFramework;
using Company.DataAccess.Abstract;
using Company.DataAccess.Concrete.EntityFramework.Contexts;
using Company.Entities.Concrete;

namespace Company.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
