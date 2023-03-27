using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
	public sealed class RoleNotFoundException: NotFoundException
	{
		public RoleNotFoundException(string errorInfo, string RoleName = null)
			: base( ((RoleName != null) ? "Роль под названием " + RoleName : "Данная роль")
				  + " не была найдена...\n Возможная причина: " + errorInfo)
		{

		}
	}
}
