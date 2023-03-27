using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
	public abstract class NotFoundException: Exception
	{
		protected NotFoundException(string message): base(message) { }
	}
}
