using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Views
{
    /// <summary>
    /// Модель для построения пейджинга
    /// </summary>
    public class PaginatorCurrentPage
    {
        public PaginatorCurrentPage(int CurrentPage,int TotalPage)
        {
            this.CurrentPage = CurrentPage;
            this.TotalPage = TotalPage;
        }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
    }
}
