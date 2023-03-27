using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Controls
{
    public class SelectView<T>
    {
        public T id { get; set; }
        public string text { get; set; }
        public SelectView() { }
        public SelectView(T Id, string Text)
        {
            this.id = Id;
            this.text = Text;
        }
    }
}
