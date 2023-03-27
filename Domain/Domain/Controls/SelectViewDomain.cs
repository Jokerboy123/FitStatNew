using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Controls
{
    public class SelectViewDomain<T>
    {
        public T id { get; set; }
        public string text { get; set; }
        public SelectViewDomain() { }
        public SelectViewDomain(T Id, string Text)
        {
            this.id = Id;
            this.text = Text;
        }
    }
}
