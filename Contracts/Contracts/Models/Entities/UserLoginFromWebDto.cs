using Contracts.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class UserLoginFromWebDto:UserLoginBaseDto
    {
        public CheckAuthUserHeader CheckUserInfo { get; set; }
    }
}
