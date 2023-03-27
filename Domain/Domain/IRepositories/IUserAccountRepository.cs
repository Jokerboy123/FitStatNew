using Common;
using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IUserAccountRepository:IRepository<UserAccount>
    {
		/// <summary>
		/// Метод получения аккаунта пользователя
		/// </summary>
		/// <param name="parentId">Код пользователя</param>
		/// <param name="accountType">тип аккаунта</param>
		Task<UserAccount> GetUserAccountAsync(Guid parentId, AccountType accountType);
		/// <summary>
		/// Добавляем \ редактируем доп. учетную запись для пользователя
		/// </summary>
		/// <param name="UserAccount">Аккаунт для добавления\редактирования</param>
		/// <returns></returns>
		Task<UserAccount> CreateOrEditAccount(UserAccount UserAccount);

	}
}
