using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IUserStateRepository : IRepository<UserState>
    {
        /// <summary>
        /// Добавление нового статуса для Пользователя
        /// </summary>
        /// <param name="NewState">Новый статус</param>
        /// <returns></returns>
        Task<UserState> AddUserState(UserState NewState);
        /// <summary>
        /// Получаем текущий статус пользователя
        /// </summary>
        /// <param name="UserId">Код Пользователя</param>
        /// <returns></returns>
        Task<UserState> GetActualUserState(Guid UserId);
    }
}
