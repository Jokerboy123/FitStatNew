using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.CommonInterfaces
{
    public interface IBaseEntityModel
    {
        public Guid Id { get; set; }
    }
}
