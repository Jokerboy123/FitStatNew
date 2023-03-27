using Common;
using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class UserStateDto: BaseTrackedModel
	{
		// <summary>
		/// ID пользователя
		/// </summary>
		public Guid UserId { get; set; }	 
		/// <summary>
		/// Статус
		/// </summary>
		public UserStateValue CurrentState { get; set; }
		/// <summary>
		/// Примечания
		/// </summary>
		public string Notes { get; set; }
		public string StatusDescription
		{
			get
			{
				return CurrentState.GetCurrentDescription();

			}
		}
	}
}
