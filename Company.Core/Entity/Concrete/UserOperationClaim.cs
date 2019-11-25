﻿using Company.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entity.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
