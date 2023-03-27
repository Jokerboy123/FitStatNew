
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{/// <summary>
/// Настройки системы
/// </summary>
    public class SystemSettings: TrackedEntity
    {
        /// <summary>    
        /// Сервер почты    
        /// </summary>
        public string EmailHost { get; set; }
        /// <summary>    
        /// Порт почты    
        /// </summary>
        public int EmailPort { get; set; }
        /// <summary>    
        /// Использовать SSL для почты  
        /// </summary>
        public bool EmailUseSSL { get; set; }
        /// <summary>    
        /// Логин почты    
        /// </summary>
        public string EmailUserName { get; set; }
        /// <summary>    
        /// Пароль почты    
        /// </summary>
        public string EmailPassword { get; set; }
        /// <summary>    
        /// Отображаемый email отправителя
        /// </summary>
        public string EmailSenderDisplayName { get; set; }    
        public Guid? UserId { get; set; }
        public User User { get; set; }                
    }
}
