using Domain.Entities;
using Domain.IRepositories;
using Persistence.Repositories.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(string dbPath) : base(dbPath) { }

        public async Task DeleteUserAsync(User User)
        {
            await database.Table<User>().DeleteAsync(m => m.Id != null);
        }

        /// <summary>
        /// Сохраняет пользователя из БД
        /// </summary>
        /// <param name="User">Сущность пользователя (или строчка в бД)</param>
        /// <returns></returns>
        public async Task SaveUserAsync(User User)     
        {

            await database.Table<User>().DeleteAsync(m => m.Id != null);
            await database.InsertAsync(User);
        }
        /// <summary>
        /// Получить из БД текущего пользователя
        /// </summary>
        /// <returns></returns>        
        public async Task<User> GetUserAsync()
        {
            return await database.Table<User>().FirstOrDefaultAsync();
        }

    }
}
