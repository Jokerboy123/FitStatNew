using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Base
{
    public class ValidateItem
    {
        public ValidateItem(string FieldName,string Text)
        {
            this.FieldName = FieldName;
            this.Text = Text;
        }
        public string FieldName { get; set; }
        public string Text { get; set; }
    }
}
