using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Base
{
    public class BaseValidatedResponseModel<T> : BaseResponseModel
        where T : class
    {
		public BaseValidatedResponseModel() : base()
		{

		}
		public BaseValidatedResponseModel(T Entity) : base()
		{
			 
		}
		public BaseValidatedResponseModel(Exception exp, T Entity = null) : base(exp)
		{
			 
		}
		public BaseValidatedResponseModel(Exception exp, List<ValidateItem> ValidatedFields, T Entity = null) : base(exp)
		{
			this.ValidatedFields = ValidatedFields;
		}
		public List<ValidateItem> ValidatedFields { get; set; } = new List<ValidateItem>();
    }
}
