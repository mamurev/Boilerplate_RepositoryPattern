using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Business.Abstract
{
    public interface IProductService
    {
        Product GetProductById(int productId);
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
