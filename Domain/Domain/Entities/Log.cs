using Common;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Журнал событий
    /// </summary>
    public class Log:Entity
    {
        /// <summary>
        /// Тип.
        /// </summary>
        public LogType Type { get; set; }
        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid? UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        public Log() { }
    }
}
