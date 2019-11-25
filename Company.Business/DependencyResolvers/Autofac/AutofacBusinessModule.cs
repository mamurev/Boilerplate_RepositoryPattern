using Autofac;
using Company.Business.Abstract;
using Company.Business.Concrete;
using Company.DataAccess.Abstract;
using Company.DataAccess.Concrete.EntityFramework;

namespace Company.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<ProductManager>().As<IProductService>();
            
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}
