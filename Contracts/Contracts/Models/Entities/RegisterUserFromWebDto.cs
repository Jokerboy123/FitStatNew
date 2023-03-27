using Contracts.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class RegisterUserFromWebDto: RegisterUserDto
    {
        /// <summary>
        /// Проверочная информация регистрации
        /// </summary>
        public CheckAuthUserHeader CheckUserInfo { get; set; }
    }
}
