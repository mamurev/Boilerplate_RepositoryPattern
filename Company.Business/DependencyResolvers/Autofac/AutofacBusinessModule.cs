using Autofac;
using Company.Business.Abstract;
using Company.Business.Concrete;
using Company.Core.Utilities.Security;
using Company.Core.Utilities.Security.Jwt;
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

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
