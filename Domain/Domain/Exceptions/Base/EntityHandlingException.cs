using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.Base
{
    public class EntityHandlingException:Exception
    {
        public EntityHandlingException(Exception exp):base("Ошибка в процессе сохранения сущностей базы данных", exp)
        {

        }
        public EntityHandlingException(string message)
          : base(message)
        {
        }
    }
}
