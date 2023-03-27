using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Tables
{
    public class TableRequestParams
    {
        public int start { get; set; }
        public int length { get; set; }
        public DataTableModel.DtOrder[] order { get; set; }
        public DataTableModel.DtColumn[] columns { get; set; }
    }
}
