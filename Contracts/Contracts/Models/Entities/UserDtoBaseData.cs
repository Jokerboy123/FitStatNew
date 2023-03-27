using Common;
using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class UserDtoBaseData: BaseEntityImageContainerModel
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
		/// Роли пользователя
		/// </summary>
		public List<UserRolesDto> UserRoles { get; set; }
		/// <summary>
		/// Статусы пользователя
		/// </summary>
		public List<UserStateDto> UserStates { get; set; }
		public bool HasRole(Guid RoleCode)
		{
			if (UserRoles == null)
			{
				return false;
			}
			return UserRoles.Where(m => m.RoleId == RoleCode).Count() != 0;
		}
		/// <summary>
		/// Флаг продавца
		/// </summary>
		public bool IsSeller
		{
			get
			{
				return HasRole(DefaultConstants.SellerRoleId);				
			}
		}
		/// <summary>
		/// Флаг продавца
		/// </summary>
		public bool IsAdmin
		{
			get
			{
				return HasRole(DefaultConstants.AdminRoleId); 
			}
		}
		/// <summary>
		/// Флаг - пользователь является членом службы поддержки.
		/// </summary>
		public bool IsSupporter
		{
			get; set;
		}
	}
}
