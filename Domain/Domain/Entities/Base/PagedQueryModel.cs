using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class PagedQueryModel<T>
        where T:class
    {
        public PagedQueryModel(int Page,int TotalPages,List<T> Data)
        {
            this.Page = Page;
            this.TotalPages = TotalPages;
            this.Data = Data;
        }
        public List<T> Data { get; set; } = new List<T>();
        public int Page { get; set; }
        private int _TotalPages;
        public int TotalPages
        {
            get
            {
                if (Data == null || Data.Count == 0)
                {
                    return 0;
                }
                return _TotalPages;
            }
            set
            {
                _TotalPages = value;
            }
        }
    }
}
