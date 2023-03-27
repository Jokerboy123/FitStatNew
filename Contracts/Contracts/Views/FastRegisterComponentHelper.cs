using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Views
{
    public class FastRegisterComponentHelper
    {
        public FastRegisterComponentHelper(string RegisterButtonName,string RegisterButtonClass="")
        {
            this.RegisterButtonName = RegisterButtonName ?? "";
            this.RegisterButtonClass = RegisterButtonClass ?? "";
        }
        public string RegisterButtonName { get; set; }
        public string RegisterButtonClass { get; set; }
    }
}
