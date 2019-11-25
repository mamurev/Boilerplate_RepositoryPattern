using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Utilities
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
