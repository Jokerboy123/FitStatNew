using Common;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserState : TrackedEntity
	{
		// <summary>
		/// ID пользователя
		/// </summary>
		public Guid UserId { get; set; }
		public User User { get; set; }
		/// <summary>
		/// Статус
		/// </summary>
		public UserStateValue CurrentState { get; set; }
		/// <summary>
		/// Примечания
		/// </summary>
		public string Notes { get; set; }
	}
}
