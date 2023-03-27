using Domain.Controls;
using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public interface IRoleRepository : IRepository<Role>
	{
		/// <summary>
		/// поиск ролей по наименованию
		/// </summary>
		/// <param name="search"></param>
		/// <returns></returns>
		Task<List<Role>> GetRolesBySearch(string search);
		/// <summary>
		/// Список ролей для Select
		/// </summary>
		/// <returns></returns>
		Task<IReadOnlyList<SelectViewDomain<Guid>>> GetRolesForSelect();
	}
}
