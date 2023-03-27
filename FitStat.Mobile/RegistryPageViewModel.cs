using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contracts.Models.Entities;

namespace FitStat.Mobile
{
    public class RegistryPageViewModel : UserDto
    {
        public UserDto RegisterUser { get; set; }

        public RegistryPageViewModel()
        {

            RegisterUser = new UserDto();
            string example = "hehgd rhllo";
            RegisterUser.Email = example;
            RegisterUser.FirstName = example;  
            RegisterUser.UserName = example.ToString();// - проверка на работоспособность и правильность привязки. Все работает!
        
        }
        
    }
}
