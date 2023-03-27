using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DataFileBase:Entity
    { 
        /// <summary>
        /// Наименование
         /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public string FileType { get; set; }
      
        /// <summary>
        /// Код родителя
        /// </summary>
        public Guid ParentCode { get; set; }
        /// <summary>
        /// Номер файла в спике файлов родителя
        /// </summary>
        public int FileIndex { get; set; }
        public string ParentType { get; set; } 
        public Guid? UserId { get; set; }
    }
}
