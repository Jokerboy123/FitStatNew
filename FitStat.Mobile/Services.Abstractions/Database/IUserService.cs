using Contracts.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Database
{
    public interface IUserService
    {
        /// <summary>
		/// Получить текущего пользователя
		/// </summary>
		/// <returns></returns>
		Task<UserDto> GetCurrentUser();
        Task<UserDto> SaveUser();
        Task<bool> DeleteUserAsync(UserDto User);// реализовано 6.11.2022

    }
}
