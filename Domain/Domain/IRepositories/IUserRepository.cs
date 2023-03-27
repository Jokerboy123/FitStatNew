using Domain.Entities;
using Domain.Entities.EntitiesQueryModels;
using Domain.IRepositories.Base;
using Domain.TableSearch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public interface IUserRepository : IRepository<User>
	{
        Task DeleteUserAsync(User user);// реализовано 6.11.2022
        /// <summary>
        /// Сохраняет пользователя из БД
        /// </summary>
        /// <param name="User">Сущность пользователя (или строчка в бД)</param>
        /// <returns></returns>
        Task SaveUserAsync(User user);
        /// <summary>
        /// Получить из БД текущего пользователя
        /// </summary>
        /// <returns></returns>       
        Task<User> GetUserAsync();
    }
}
