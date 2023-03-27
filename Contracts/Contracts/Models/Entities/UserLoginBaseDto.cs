using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class UserLoginBaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
