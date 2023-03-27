using System.Collections.Generic;
using Domain.Entities.Base;

namespace Domain.Entities
{
	/// <summary>
	/// пользователь
	/// </summary>
	public class User : TrackedEntity
	{
		/// <summary>
		/// логин пользователя
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// имя пользователя
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// фамилия пользователя
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// отчество пользователя
		/// </summary>
		public string MiddleName { get; set; }
		/// <summary>
		/// эл. почта
		/// </summary>
		public string Email { get; set; }		
		/// <summary>
		/// Пароль.
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// Хеш пароля.
		/// </summary>
		public byte[] HashedPassword { get; set; }		
	}
}
