using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Tables
{
    public class DataTableModel
    {
        /// <summary>
        /// Поиск
        /// </summary>
        public class DtSearch
        {
            public string value { get; set; }
            public bool regex { get; set; }
        }
        /// <summary>
        /// Порядок
        /// </summary>
        public class DtOrder
        {
            public string dir { get; set; }
            public int column { get; set; }
        }
        /// <summary>
        /// Колонка
        /// </summary>
        public class DtColumn
        {
            public string data { get; set; }
            public string name { get; set; }
            public bool searchable { get; set; }
            public bool orderable { get; set; }
            public DtSearch search { get; set; }
        }

        //базовый ответ
        public class DtResponse<T>:BaseModel
        {
            public int draw { get; set; }
            public int recordsTotal { get; set; }
            public int recordsFiltered { get; set; }
            public IReadOnlyList<T> data { get; set; }
            public string message { get; set; }

            /// <summary>
            /// Когда RecordsTotal и RecordsFiltered равны, то используем один параметр (большинство случаем)
            /// </summary>
            /// <param name="recordsTotal"></param>
            /// <param name="data"></param>
            /// <param name="draw"></param>
            public DtResponse(int recordsTotal, IReadOnlyList<T> data, int draw = 1):
                this(recordsTotal, recordsTotal,data,draw)
            {
               
            }
            public DtResponse(int recordsTotal, int recordsFiltered, IReadOnlyList<T> data, int draw=1):
                this()
            {
                this.draw = draw;
                this.data = data;
                this.recordsTotal = recordsTotal;
                this.recordsFiltered = recordsFiltered;
            }           
            public DtResponse()
            {
                this.draw = 1;
                this.Result = Common.DefaultConstants.Result.ok;
                this.data = new List<T>();
            }
            public DtResponse(Exception Exp)
            {
                this.draw = 1;
                this.Result = Common.DefaultConstants.Result.error;
                this.message = Exp != null ? (Exp.Message + (Exp.InnerException != null ? ", " + Exp.InnerException.Message : "")) : "";
            }  
        }
    }
}
