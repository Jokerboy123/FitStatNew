using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.Base
{
    public class EntityRulesViolationException:Exception
    {
        public EntityRulesViolationException(string message)
        : base(message)
        {
        }
    }
}
