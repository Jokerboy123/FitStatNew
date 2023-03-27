using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
	public sealed class UsersTableNotBuiltException: BadRequestException
	{
		public UsersTableNotBuiltException(string errorInfo)
			:base("Не удалось построить талицу пользователей.\n" +
				 "Возможная причина: " + errorInfo)
		{

		}
	}
}
