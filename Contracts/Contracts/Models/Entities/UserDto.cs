using Common;
using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models.Entities
{
	/// <summary>
	/// модель данных о пользователе
	/// </summary>
	public class UserDto: UserDtoBaseData
	{		
		/// <summary>
		/// флаг - удален
		/// </summary>
		public bool IsRemoved { get; set; }
		/// <summary>
		/// Пароль.
		/// </summary>
		public string Password { get; set; }
		 
		/// <summary>
		/// Описание.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Адрес.
		/// </summary>
		public string Address1 { get; set; }
		/// <summary>
		/// Адрес.
		/// </summary>
		public string Address2 { get; set; }
		/// <summary>
		/// Город.
		/// </summary>
		public string City { get; set; }
		/// <summary>
		/// Индекс.
		/// </summary>
		public string ZipCode { get; set; }
		/// <summary>
		/// Телефон.
		/// </summary>
		public string PhoneNumber { get; set; }
		
		 

		
	}
}
