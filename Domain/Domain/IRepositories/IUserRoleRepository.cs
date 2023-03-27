using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public interface IUserRolesRepository : IRepository<UserRoles>
	{
		/// <summary>
		/// метод прикрепления роли к пользователю
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="roleId"></param>
		/// <returns></returns>
		Task<UserRoles> AttachRoleToUser(Guid userId, Guid roleId);
		/// <summary>
		/// метод удаления роли пользователя
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="roleId"></param>
		/// <returns></returns>
		Task<UserRoles> DetachRoleFromUser(Guid userId, Guid roleId);
	}
}
