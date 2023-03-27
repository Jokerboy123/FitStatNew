using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
	public sealed class RolesTableNotBuiltException: BadRequestException
	{
		public RolesTableNotBuiltException(string errorInfo)
			: base("Не удалось построить талицу ролей.\n" +
				 "Возможная причина: " + errorInfo)
		{ }
	}

}
