using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
	/// <summary>
	/// роль пользователя
	/// </summary>
	public class Role : TrackedEntity
	{
		/// <summary>
		/// название роли
		/// </summary>
		public string RoleName { get; set; }
		/// <summary>
		/// флаг - роль удалена
		/// </summary>
		public bool IsRemoved { get; set; }

		public List<UserRoles> UserRoles { get; set; } = new List<UserRoles>();
	}
}
