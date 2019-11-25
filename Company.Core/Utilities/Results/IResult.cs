using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Utilities
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
