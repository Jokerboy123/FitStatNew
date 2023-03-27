using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiesQueryModels
{
    public class TableQueryData<T>
    {
        public TableQueryData()
        {
            this.Data = null;
            this.TotalRecords = 0;
        }
        public TableQueryData(IReadOnlyList<T> Data,int TotalRecords)
        {
            this.Data = Data;
            this.TotalRecords = TotalRecords;
        }
        /// <summary>
        /// Список записей для таблицы
        /// </summary>
        public IReadOnlyList<T> Data { get; set; }
        /// <summary>
        /// Всего записей (если используется разбиение на страницы)
        /// </summary>
        public int TotalRecords { get; set; }
    }
}
