using Contracts.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class RegisterUserDto : UserDto
    {   /// <summary>
        /// Повтор пароля
        /// </summary>
        public string PasswordConfirm { get; set; } 
    }
}
