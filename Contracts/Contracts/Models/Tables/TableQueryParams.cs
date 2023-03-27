using Contracts.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Tables
{
    public class TableQueryParams
    {
        public TableQueryParams(int Draw,int Skip,int Take, DataTableModel.DtOrder[] Order, DataTableModel.DtColumn[] Columns)
        {
            this.Draw = Draw;
            this.Skip = Skip;
            this.Take = Take;
            this.Order = Order;
            this.Columns = Columns;
        }
        public int Draw { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public DataTableModel.DtOrder[] Order { get; set; }
        public DataTableModel.DtColumn[] Columns { get; set; }
    }
}
