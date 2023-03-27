using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models.Entities
{
	/// <summary>
	/// модель данных о роли
	/// </summary>
	public class RoleDto: BaseTrackedModel
	{
		/// <summary>
		/// название роли
		/// </summary>
		public string RoleName { get; set; }
		/// <summary>
		/// флаг - роль удалена
		/// </summary>
		public bool IsRemoved { get; set; }
	}
}
