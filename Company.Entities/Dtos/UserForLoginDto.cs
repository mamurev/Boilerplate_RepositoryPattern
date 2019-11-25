using Company.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Entities.Dtos
{
    //DTO : Data Tranformation Object
    //Also called complex types
    //Dto is used to join entities
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
