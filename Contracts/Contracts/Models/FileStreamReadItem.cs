using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models
{
    public class FileStreamReadItem
    {
        /// <summary>
        /// Контент с инфорамцией о файле
        /// </summary>
        public MemoryStream StreamContent { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Индекс номера файла
        /// </summary>
        public int Index { get; set; }
    }
}
