using Company.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entity.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
