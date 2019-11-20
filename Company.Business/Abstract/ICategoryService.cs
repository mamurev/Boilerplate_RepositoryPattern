using Company.Core.Utilities;
using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
    }
}
