using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
	public sealed class UserNotFoundException: NotFoundException
	{
		public UserNotFoundException( string errorInfo, string userName = null)
			: base((userName != null) ? "Пользователь с именем " + userName : "Данный пользователь "
				  + " не был найден...\n Возможная причина: " + errorInfo)
		{

		}
	}
}
