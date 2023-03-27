using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{   /// <summary>
    /// Файл
    /// </summary>
    public class DataFile: DataFileBase
    { 
        /// <summary>
        /// Содержание
        /// </summary>
        public byte[] FileContent { get; set; }
       /// <summary>
       /// Пользователь, добавивший файл
       /// </summary>
        public User User { get; set; }
       

    }
}
