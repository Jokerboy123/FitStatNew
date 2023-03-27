using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Base
{
	public class BaseTrackedModel : BaseEntityModel
	{
		public DateTime? DateCreated { get; set; }
		public DateTime? DateChanged { get; set; }
		public string WhoChanged { get; set; }
	}
}
