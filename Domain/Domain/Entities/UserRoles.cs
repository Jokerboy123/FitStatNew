using Domain.Entities.Base;
using System;

namespace Domain.Entities
{
	/// <summary>
	/// роль пользователя
	/// </summary>
	public class UserRoles : Entity
	{
		/// <summary>
		/// ID пользователя
		/// </summary>
		public Guid UserId { get; set; }
		public User User { get; set; }
		/// <summary>
		/// ID роли
		/// </summary>
		public Guid RoleId { get; set; }
		public Role Role { get; set; }
	}
}
