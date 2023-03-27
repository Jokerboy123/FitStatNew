using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Base
{
    public class BasePagedModel<T>
        where T : class
    {
        public BasePagedModel() { }
        public BasePagedModel(int Page, int TotalPages, List<T> Data)
        {
            this.Page = Page;
            this.TotalPages = TotalPages;
            this.Data = Data;
        }
        public List<T> Data { get; set; } = new List<T>();
        public int Page { get; set; }
        public int TotalPages { get; set; }
    }
}
